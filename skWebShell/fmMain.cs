using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wbOps;
namespace skWebShell
{
    public partial class fmMain : Form
    {

        WebClient mWorkClient = new WebClient();
        Uri m_url;
        String m_sent_printed_ids = null;
        String m_pending_printed_ids = null;
        ISkInteract sk_ops;


        public fmMain()
        {
            InitializeComponent();
            String url = String.Format("{0:s}?pos_id={1:s}", system_const.service_url, ConfigurationManager.AppSettings["pos_id"]);
            m_url = new Uri(url);
            mWorkClient.OpenReadCompleted += MWorkClient_OpenReadCompleted;
            tcMain.Height = scMain.Panel2.Height - ssMain.Height;
            sk_ops = ISkInteract.create();
            wbMain.Url = new Uri(sk_ops.GetServUrl());
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
            if (req.items != null)
            {
                foreach (FapiaoEntity item in req.items)
                {
                    ListViewItem n = new ListViewItem(item.id);
                    n.Text = item.created_at;
                    n.SubItems.Add(item.position + " " + item.amount);
                    n.SubItems.Add(item.fapiao_title);
                    n.Tag = item;
                    lvActReq.Items.Add(n);
                }
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
            tcMain.Height = scMain.Panel2.Height - ssMain.Height;
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            kickoff_rpt_retrieve();
        }

        private void lvActReq_DoubleClick(object sender, EventArgs e)
        {
            ListView lvReqList = (ListView)sender;
            if (lvReqList.SelectedItems.Count > 0)
            {
                ListViewItem item = lvReqList.SelectedItems[0];
                FapiaoEntity fp = ((FapiaoEntity)item.Tag);
                if (fp == null) return;
                if (sk_ops.InsertAmount(wbMain, fp.amount) == false && sk_ops.InsertTitle(wbMain, fp.fapiao_title) == false) return;
                if (m_pending_printed_ids == null)
                    m_pending_printed_ids = fp.id;
                else
                {
                    m_pending_printed_ids = m_pending_printed_ids + "|" + fp.id;
                }
                item.Remove();
                //lvDoneList.Items.Add(item);
                kickoff_rpt_retrieve();
            }
        }
    }
}
