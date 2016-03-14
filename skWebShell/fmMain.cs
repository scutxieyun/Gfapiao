using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using wbOps;
using mshtml;
using System.Diagnostics;
using QRCoder;

namespace skWebShell
{
    public partial class fmMain : Form
    {

        WebClient mWorkClient = new WebClient();
        Uri m_url;
        String m_sent_printed_ids = null;
        String m_pending_printed_ids = null;
        ISkInteract sk_ops;
        int doc_loaded_cnt = 0;

        public fmMain(String init_data)
        {
            InitializeComponent();
            String url = String.Format("{0:s}/fppos/index?pos_id={1:s}", system_const.entry, Program.pos_id);
            m_url = new Uri(url);

            this.plCrArea.Height = scMain.Panel2.Height - fpOperation.Height;
            tcMain.Height = this.plCrArea.Height - this.plStoreInfo.Height;


            hideToolPanel();

            sk_ops = ISkInteract.create(wbMain);
            if (init_data != null) {
                FapiaoItems res = FapiaoItems.create(init_data);
                if (res != null) { this.Handle_Incomming_Request(res); }
            }
            mWorkClient.OpenReadCompleted += MWorkClient_OpenReadCompleted;
        }


        private void MWorkClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                m_sent_printed_ids = null;
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                StreamReader reader = new StreamReader(e.Result, encode);
                String str = reader.ReadToEnd();
                FapiaoItems res = FapiaoItems.create(str);
                if (res == null) return;
                this.Invoke((MethodInvoker)delegate
                {
                    this.Handle_Incomming_Request(res);
                });
            }
        }
        private void Handle_Incomming_Request(FapiaoItems req)
        {
            bool new_item = false;
            if (req.items != null)
            {
                if (btShowPanel.Visible) {
                    btShowPanel.BackColor = Color.Red;
                }
                foreach (FapiaoEntity item in req.items)
                {
                    ListViewItem n = new ListViewItem(item.id);
                    n.Text = item.created_at;
                    n.SubItems.Add(String.Format("台/单:{0:s} {1:s}元",item.position,item.amount));
                    n.SubItems.Add(item.fapiao_title);
                    n.Tag = item;
                    if (item.result == null || item.result == "finished")
                    {
                        if (item.status == "打印被拒绝") n.BackColor = Color.Red;
                        lvDoneList.Items.Add(n);
                    }
                    else
                    {
                        lvActReq.Items.Add(n);
                        new_item = true;
                    }
                }
            }
            if (new_item) {
                notifyForNewItem();
            }
        }

        private void kickoff_rpt_retrieve()
        {
            if (mWorkClient.IsBusy) return;
            Uri my_url = m_url;
            m_sent_printed_ids = m_pending_printed_ids;
            m_pending_printed_ids = null;
            if (m_sent_printed_ids != null)
            {
                my_url = new Uri(String.Format("{0:s}&rpt_ids={1:s}", my_url.ToString(), m_sent_printed_ids));
            }
            mWorkClient.OpenReadAsync(my_url);
        }


        
        private void scMain_Panel2_Resize(object sender, EventArgs e)
        {
            this.plCrArea.Height = scMain.Panel2.Height - fpOperation.Height;
            tcMain.Height = this.plCrArea.Height - this.plStoreInfo.Height;
            //tcMain.Height = scMain.Panel2.Height - fpOperation.Height;
        }

        private void lvActReq_DoubleClick(object sender, EventArgs e)
        {
            ListView lvReqList = (ListView)sender;
            if (lvReqList.SelectedItems.Count > 0)
            {
                ListViewItem item = lvReqList.SelectedItems[0];
                FapiaoEntity fp = ((FapiaoEntity)item.Tag);
                if (!sk_ops.IsInFPWnd()) {
                    MessageBox.Show("请进入发票打印页面");
                    return;
                }

                if (fp != null && sk_ops.InsertAmount(fp.amount) && sk_ops.InsertTitle(fp.fapiao_title))
                {
                    if (m_pending_printed_ids == null)
                        m_pending_printed_ids = fp.id;
                    else
                    {
                        m_pending_printed_ids = m_pending_printed_ids + "|" + fp.id;
                    }
                    item.Remove();
                    lvDoneList.Items.Add(item);
                    kickoff_rpt_retrieve();
                    return;
                }
            }
            MessageBox.Show("数据异常，请重新选择数据");
            return;
        }

        private void lvActReq_Delete_Item_Action(object sender, EventArgs e) {
            ListView lvReqList = (ListView)sender;
            if (lvReqList.SelectedItems.Count > 0)
            {
                ListViewItem item = lvReqList.SelectedItems[0];
                FapiaoEntity fp = ((FapiaoEntity)item.Tag);
                if(MessageBox.Show("确认拒绝该请求","拒绝打印请求",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (m_pending_printed_ids == null)
                        m_pending_printed_ids = fp.id + ",d";
                    else
                    {
                        m_pending_printed_ids = m_pending_printed_ids + "|" + fp.id+",d";
                    }
                    item.Remove();
                    fp.status = "打印被拒绝";
                    lvDoneList.Items.Add(item);
                    item.BackColor = Color.Red;
                    kickoff_rpt_retrieve();
                    return;
                }
            }
            MessageBox.Show("数据异常，请重新选择数据");
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            kickoff_rpt_retrieve();
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            hideToolPanel();
        }

        private void hideToolPanel() {
            scMain.Panel2Collapsed = true;
            btShowPanel.Visible = true;
            btShowPanel.BackColor = Color.Silver;
            btShowPanel.Text = "显示工具";
        }

        private void notifyForNewItem() {
            if (btShowPanel.Visible == true) {
                btShowPanel.BackColor = Color.Red;
                btShowPanel.Text = "有新请求";
            }
        }

        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            doc_loaded_cnt++;
            this.Text = "开票易 - " + wbMain.Document.Title;
            if (e.Url.ToString().Contains("https://fp.gdltax.gov.cn/fpzx/jsp/fpzx/common/transition.jsp")) {
                /*if (forceUrl == false)
                {
                    wbMain.Url = e.Url;
                    forceUrl = true;
                }
                else {*/
                    tmDelayInject.Enabled = true;
                //}
            }
            /*try
            {
                HtmlElementCollection heads = wbMain.Document.GetElementsByTagName("head");


                if (heads != null && heads.Count > 0)
                {
                    HtmlElement head = heads[0];
                    String[] args = { "input[name=\"zyhhm\"]" };
                    injectCSS(head, system_const.customized_css);
                    injectScript(head, system_const.jquery_2_1_3_min);
                    injectScript(head, system_const.cmp_idx);
                    wbMain.Document.InvokeScript("install_hook", args);
                }
                else
                {
                    MessageBox.Show("no head found");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("install hook failed with " + ex.Message);
            }*/


        }
        private bool injectCSS(HtmlDocument _odoc, HtmlElement head, String css)
        {
            try
            {
                IHTMLDocument2 doc = (IHTMLDocument2)(_odoc.DomDocument);
                IHTMLStyleSheet ss = doc.createStyleSheet("", 0);
                ss.cssText = system_const.customized_css;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool injectScript(HtmlDocument _odoc,HtmlElement head, String spt)
        {
            try
            {
                HtmlElement elm = _odoc.CreateElement("script");
                elm.SetAttribute("type", "text/javascript");

                IHTMLScriptElement scriptElm = (IHTMLScriptElement)elm.DomElement;
                scriptElm.text = spt;
                head.AppendChild(elm);
                return true;
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool injectScriptWithUrl(HtmlDocument _odoc, HtmlElement head, String url)
        {
            try
            {
                HtmlElement elm = _odoc.CreateElement("script");
                elm.SetAttribute("type", "text/javascript");
                elm.SetAttribute("src", url);
                head.AppendChild(elm);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btShowPanel_Click(object sender, EventArgs e)
        {
            scMain.Panel2Collapsed = false;
            btShowPanel.Visible = false;
        }

        private void tmDelayInject_Tick(object sender, EventArgs e)
        {
            //HtmlWindow actPage = wbMain.Document.Window;// sk_ops.getActPage();
            HtmlDocument actDoc = sk_ops.getActPage().Document; //wbMain.Document;
            if (actDoc != null)
            {
                tmDelayInject.Enabled = false;
                try
                {
                    HtmlElementCollection heads = actDoc.GetElementsByTagName("head");
                    if (heads != null && heads.Count > 0)
                    {
                        HtmlElement head = heads[0];
                        //String[] args = { "input#fkfMc" };
                        //injectCSS(actDoc, head, system_const.customized_css);
                        //injectScript(actDoc, head, system_const.jquery_2_1_3_min);
                        //injectScript(actPage.Document, head, system_const.cmp_idx);
                        //injectScript(actDoc, head, system_const.new_plugin_mc);
                        //actDoc.InvokeScript("install_hook");
                        injectScriptWithUrl(actDoc, head, "https://aifapiao.duapp.com/js/fp_plugin.js");
                        Trace.WriteLine("install hook succeed");
                    }
                }
                catch (Exception ex)
                {
                    Trace.WriteLine("install hook to act page with error: " + ex.Message);
                }
                finally {
                    
                }
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            renderQRCode();
            this.llStoreURL.Links.Add(0, 4, String.Format("{0:s}/fpmgt/index?pos_id={1:s}&nic={2:s}",system_const.entry,Program.pos_id.Trim(),Program.nic.GetPhysicalAddress()));
        }

        private void renderQRCode()
        {
            string level = "M";
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(String.Format("{0:s}/fppos/anonymousindex?pos_id={1:s}",system_const.entry,Program.pos_id), eccLevel);
            QRCode qrCode = new QRCode(qrCodeData);

            pbScan.Image = qrCode.GetGraphic(10, Color.Black, Color.White, null, 0);
        }

        private void pbScan_Click(object sender, EventArgs e)
        {
    
            //pr1.Document = 
        }

        private void pdQRCode_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawImage(pbScan.Image, new Point(0, 0));
        }

        private void pbScan_DoubleClick(object sender, EventArgs e)
        {
            DialogResult res = pdMain.ShowDialog();
            if (res == DialogResult.OK)
            {
                pdQRCode.Print();
            }
        }

        private void tmPollRpt_Tick(object sender, EventArgs e)
        {
            kickoff_rpt_retrieve();
        }

        private void lvActReq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lvActReq_DoubleClick(sender, e);
            }
            if (e.KeyChar == (char)Keys.D)
            {
                lvActReq_Delete_Item_Action(sender, e);
            }
        }

        private void lvActReq_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Rectangle r = new Rectangle(e.Bounds.Location, new Size(e.Bounds.Width, e.Bounds.Height + 20));
            //e.Graphics.DrawImage(e.Item.ImageList.Images[e.Item.ImageIndex], r);
            e.Graphics.DrawString(e.Item.Text, e.Item.Font, new SolidBrush(e.Item.ForeColor), new Point(e.Bounds.X + 10, e.Bounds.Y + 30));
        }

        private void llStoreURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string targetUrl = e.Link.LinkData as string;
            System.Diagnostics.Process.Start(targetUrl);
        }

        private void lvActReq_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                lvActReq_Delete_Item_Action(sender, e);
            }
        }
    }
}
