using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ToBkInterface;
using QRCoder;
namespace GFapiaoClient
{
    public partial class fmMain : Form
    {
        WebClient mWorkClient = new WebClient();
        Uri m_url;
        String m_sent_printed_ids = null;
        String m_pending_printed_ids = null;
        //SysCfg m_cfg = null;

        public fmMain(string init_data)
        {
            WndInteract.Win32Locator.KickOffEnumWindows();
            InitializeComponent();
            String url = ServerConn.generateServerUrl(Program.pos_id);
            m_url = new Uri(url);
            mWorkClient.OpenReadCompleted += MWorkClient_OpenReadCompleted;

            plMain.Height = this.ClientSize.Height - this.fplOperator.Height - this.ssStatus.Height - this.pbScan.Height - 20;

            //m_cfg = SysCfg.create(system_const.local_cfg);
            OperatorAreaUpdate();


            if (init_data != null)
            {
                FapiaoItems res = FapiaoItems.create(init_data);
                if (res != null) { this.Handle_Incomming_Request(res); }
            }
        }

        private void StatusUpdate() {
            
        }

        private void tmSXX_Tick(object sender, EventArgs e)
        {
            kickoff_rpt_retrieve();
        }

        private void Handle_Incomming_Request(FapiaoItems req) {
            if (req.items != null)
            {
                foreach (FapiaoEntity item in req.items)
                {
                    ListViewItem n = new ListViewItem(item.id);
                    n.Text = String.Format("台/单:{0:s} {1:s}元", item.position, item.amount);
                    n.SubItems.Add(item.fapiao_title);
                    n.SubItems.Add(item.created_at);
                    n.Tag = item;
                    lvReqList.Items.Add(n);
                }
            }
        }
        private void MWorkClient_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            if (e.Error == null) {
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

        private void kickoff_rpt_retrieve() {
            if (mWorkClient.IsBusy) return;
            Uri my_url = m_url;
            m_sent_printed_ids = m_pending_printed_ids;
            m_pending_printed_ids = null;
            if (m_sent_printed_ids != null) {
                my_url = new Uri(ServerConn.generateRptIdsPushUrl(Program.pos_id,m_pending_printed_ids));
            }
            mWorkClient.OpenReadAsync(my_url);
        }
        
        
        private void lvReqList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvReqList.SelectedItems.Count > 0) {
                ListViewItem item = lvReqList.SelectedItems[0];
                int res;
                if ((res = SendRecipt((FapiaoEntity)item.Tag)) != 0) {
                    MessageBox.Show(String.Format("税控脚本执行错误，错误码:{0:d} {1:s}", res, WndInteract.ScriptExecuter.getLastError()));
                    return;
                }
                if (m_pending_printed_ids == null)
                    m_pending_printed_ids = ((FapiaoEntity)item.Tag).id;
                else {
                    m_pending_printed_ids = m_pending_printed_ids + "|" + ((FapiaoEntity)item.Tag).id;
                }
                item.Remove();
                lvDoneList.Items.Add(item);
                kickoff_rpt_retrieve();
                seStatus.Text = WndInteract.ScriptExecuter.getStatus();
            }
        }
        
        private void fmMain_Resize(object sender, EventArgs e)
        {
            plMain.Height = this.ClientSize.Height - this.fplOperator.Height - this.ssStatus.Height - this.pbScan.Height - 20;
        }

        private void lvReqList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperatorAreaUpdate();
        }

        private void OperatorAreaUpdate() {
            this.btRefresh.Enabled = true;
            if (lvReqList.SelectedItems.Count > 0 && this.tcMain.SelectedTab == this.tpPrint)
            {
            }
            if (this.tcMain.SelectedTab != this.tpPrint) {
                this.btRefresh.Enabled = false;
            }

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            kickoff_rpt_retrieve();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperatorAreaUpdate();
        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmDownload_Click(object sender, EventArgs e)
        {

        }


        public static int SendRecipt(FapiaoEntity req)
        {
            Dictionary<String, String> rec = new Dictionary<string, string>();
            rec.Add("Customer_Text", req.fapiao_title);
            rec.Add("Product_Code", "餐费");
            rec.Add("Amount", req.amount);
            return WndInteract.ScriptExecuter.execute(rec);
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            renderQRCode();
        }

        private void renderQRCode()
        {
            string level = "M";
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(String.Format("{0:s}/anonymousindex?pos_id={1:s}", system_const.service_url, ConfigurationManager.AppSettings["pos_id"]), eccLevel);
            QRCode qrCode = new QRCode(qrCodeData);
            pbScan.Image = qrCode.GetGraphic(10, Color.Black, Color.White, null, 0);
        }

        private void btTest_Click(object sender, EventArgs e)
        {
           
        }

        private void btReject_Click(object sender, EventArgs e)
        {
            ListView lvReqList = this.lvReqList;
            if (lvReqList.SelectedItems.Count > 0)
            {
                ListViewItem item = lvReqList.SelectedItems[0];
                FapiaoEntity fp = ((FapiaoEntity)item.Tag);
                if (MessageBox.Show("确认拒绝该请求", "拒绝打印请求", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (m_pending_printed_ids == null)
                        m_pending_printed_ids = fp.id + ",d";
                    else
                    {
                        m_pending_printed_ids = m_pending_printed_ids + "|" + fp.id + ",d";
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

        private void lvDoneList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lvReqList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lvReqList_MouseDoubleClick(sender,null);
            }
            if (e.KeyChar == (char)Keys.D)
            {
                btReject_Click(sender, null);
            }
        }

        private void lvDoneList_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void lvReqList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btReject_Click(sender, null);
            }
        }
    }
}
