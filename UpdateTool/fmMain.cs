using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
namespace UpdateTool
{
    public partial class fmMain : Form
    {
        WebClient wbMain = new WebClient();
        String url = "http://aifapiao.duapp.com/public/index.php/fpmgt/download";
        public fmMain()
        {
            InitializeComponent();
            if(Environment.GetCommandLineArgs().Length >= 2){
                url = Environment.GetCommandLineArgs()[1];
            }
            wbMain.DownloadFileCompleted += new AsyncCompletedEventHandler(MWorkClient_DownloadCompleted);
            wbMain.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);

        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e) {
            pbDownload.Value = e.ProgressPercentage;
        }

        private void MWorkClient_DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    ZipInputStream zin = new ZipInputStream(File.OpenRead("_temp.zip"));
                    
                    ZipEntry entry;
                    while ((entry = zin.GetNextEntry())!= null)
                    {
                        if (entry.IsFile) {
                            tbFiles.AppendText("解压文件 " + entry.Name + Environment.NewLine);
                            FileStream nf = new FileStream(entry.Name, FileMode.Create);
                            int size = 2048;
                            byte[] data = new byte[2048];
                            while (true)
                            {
                                size = zin.Read(data, 0, data.Length);
                                if (size > 0)
                                {
                                    nf.Write(data, 0, size);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            nf.Close();
                        }
                    }
                    MessageBox.Show("升级成功");
                    File.Delete("_temp.zip");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                btBegin.Text = "退出";
                btRun.Visible = true;
            }
            else {
                MessageBox.Show(e.Error.Message);
                btBegin.Text = "开始";
            }
        }

        private void btBegin_Click(object sender, EventArgs e)
        {
            if (btBegin.Text == "开始")
            {
                try
                {
                    wbMain.DownloadFileAsync(new Uri(url), "_temp.zip", null);
                    btBegin.Text = "终止";
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                return;
            }
            if (btBegin.Text == "终止") {
                wbMain.CancelAsync();
                btBegin.Text = "开始";
            }
            if (btBegin.Text == "退出") {
                Application.Exit();
            }
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.Start("skWebShell.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("执行新程序失败，结束升级后请重试 " + ex.Message);
            }
            this.Close();
        }
    }
}
