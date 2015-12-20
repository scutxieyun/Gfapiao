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

namespace GFapiaoClient
{
    public partial class fmMain : Form
    {
        WebClient mWorkClient = new WebClient();
        Uri m_url;
        String m_sent_printed_ids = null;
        String m_pending_printed_ids = null;
        SysCfg m_cfg = null;

        int sys_status = -1;
        public fmMain()
        {
            WndInteract.Win32Locator.KickOffEnumWindows();
            InitializeComponent();
            m_url = new Uri(String.Format("{0:s}?pos_id={1:s}", system_const.service_url, ConfigurationManager.AppSettings["pos_id"]));
            mWorkClient.OpenReadCompleted += MWorkClient_OpenReadCompleted;

            plMain.Height = this.ClientSize.Height - this.flpOperator.Height - this.ssStatus.Height;

            m_cfg = SysCfg.create(system_const.local_cfg);
            OperatorAreaUpdate();
        }

        private void StatusUpdate() {
            if (m_cfg == null) {

            }
        }

        private void tmSXX_Tick(object sender, EventArgs e)
        {
            //kickoff_rpt_retrieve();
        }

        private void Handle_Incomming_Request(FapiaoItems req) {
            if (req.items != null)
            {
                foreach (FapiaoEntity item in req.items)
                {
                    ListViewItem n = new ListViewItem(item.id);
                    n.Text = item.created_at;
                    n.SubItems.Add(item.position + " " + item.amount);
                    n.SubItems.Add(item.fapiao_title);
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
                my_url = new Uri(String.Format("{0:s}&rpt_ids={1:s}", my_url.ToString(), m_sent_printed_ids));
            }
            mWorkClient.OpenReadAsync(my_url);
        }
        
        
        private void lvReqList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvReqList.SelectedItems.Count > 0) {
                ListViewItem item = lvReqList.SelectedItems[0];
                if (m_pending_printed_ids == null)
                    m_pending_printed_ids = ((FapiaoEntity)item.Tag).id;
                else {
                    m_pending_printed_ids = m_pending_printed_ids + "|" + ((FapiaoEntity)item.Tag).id;
                }
                item.Remove();
                lvDoneList.Items.Add(item);
                kickoff_rpt_retrieve();
            }
        }
        
        private void fmMain_Resize(object sender, EventArgs e)
        {
            plMain.Height = this.ClientSize.Height - this.flpOperator.Height - this.ssStatus.Height;
        }

        private void lvReqList_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperatorAreaUpdate();
        }

        private void OperatorAreaUpdate() {
            btReject.Enabled = false;
            btPrint.Enabled = false;
            this.btRefresh.Enabled = true;
            if (lvReqList.SelectedItems.Count > 0 && this.tcMain.SelectedTab == this.tpPrint)
            {
                btReject.Enabled = true;
                btPrint.Enabled = true;
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
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (StreamWriter writer = new StreamWriter(deskDir + "\\" + "爱发票辅助打印工具" + ".url"))
            {
                string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("My Program", "\"" + Application.ExecutablePath + "\"");
            }
        }

        private void tsmDownload_Click(object sender, EventArgs e)
        {

        }

        private String detectShuikong() {
            String sk_list = getShuikongInfoList();
            if (sk_list != null) {
                foreach (String str in WndInteract.Win32Locator.GetWindows())
                {
                    if (WndInteract.Win32Locator.HasChinese(str) && sk_list.IndexOf(str) != -1)
                    {
                        return str;
                    }
                };
            }
            return null;
        }

        private String getShuikongInfoList() {
            Uri url = new Uri(system_const.service_url + "/shuikonglist");
            try
            {
                String res = mWorkClient.DownloadString(url);
                return res;
            }
            catch (Exception e) {
                return null;
            }
        }
       
    }
}
