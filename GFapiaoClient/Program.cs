using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WndInteract;

namespace GFapiaoClient
{
    static class Program
    {

        static WebClient mWorkClient = new WebClient();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Win32Locator.KickOffEnumWindows();



            mWorkClient.Encoding = System.Text.Encoding.UTF8;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WndInteract.ScriptExecuter.init();
            checkAndCreateShortcut();

            checkandCreateStartup();

            if(InitSKScriptEng() == false) {

                try {
                    String g_str = null;
                    g_str = detectShuikong();
                    if (g_str == null)
                    {
                        //prompt to select
                        MessageBox.Show("please select a shuikong winds");
                        return; 
                    }
                    if (!downloadSkCfg(g_str))
                    {
                        //upload env
                    }
                    if (InitSKScriptEng() == false) {
                        //fail
                        return;
                    }
                }
                catch (Exception e) {
                    return;
                }
            }
            Application.Run(new fmMain());
        }

        private static bool downloadSkCfg(String wnd_str) {
            System.Drawing.Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            String url = string.Format("{0:s}/cfgfile?wndtitle={1:s}&x_res={2:d}&y_res={3:d}",system_const.service_url , wnd_str, resolution.Width, resolution.Height);
            WebClient w_cli = new WebClient();
            try
            {
                w_cli.DownloadFile(url, "tmp_" + system_const.sk_script_fn);
                return true;
            }
            catch (IOException io_ex)
            {
                MessageBox.Show("写脚本文件错误" + wnd_str + io_ex.Message);
            }
            catch (WebException web_ex)
            {
                if (((HttpWebResponse)web_ex.Response).StatusCode == HttpStatusCode.NotFound)
                {
                    collectWndEnv(wnd_str);
                }
                else
                {
                    MessageBox.Show("网络故障" + web_ex.Message + " 请联系技术支持");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("系统故障");
            }
            return false;
        }

        private static bool collectWndEnv(string v)
        {
            IntPtr wnd = Win32Locator.locateWindow(String.Format("S({0:S})[0]", v), null);
            if (wnd == IntPtr.Zero)
            {
                MessageBox.Show(String.Format("定位窗口 {0:s} 失败", v));
                return false;
            }
            try
            {
                String fn = "shuikong-screen.jpg";
                Win32Locator.SetForeGWindow(wnd);
                Win32Locator.centerWindow(wnd);
                Bitmap pic = Win32Locator.CaptureScreen();
                MemoryStream mStream = new MemoryStream();
                pic.Save(mStream, ImageFormat.Jpeg);
                WebClient w_cli = new WebClient();
                String url = string.Format("{0:s}/uploaddata?pos_id={1:s}&tag={2:d}", system_const.service_url, ConfigurationManager.AppSettings["pos_id"], fn);
                w_cli.UploadData(new Uri(url), mStream.ToArray());
                MessageBox.Show("上载文件成功，请联系技术支持生成配置文件");
            }
            catch (IOException e)
            {
                MessageBox.Show("写文件错误，请检查磁盘空间");
                return false;
            }
            catch (WebException e)
            {
                MessageBox.Show("上载文件失败，请联系技术支持");
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("系统异常");
                return false;
            }
            return true;
        }

        private static bool InitSKScriptEng()
        {
            if (File.Exists(system_const.sk_script_fn)) {
                return WndInteract.ScriptExecuter.readScript(system_const.sk_script_fn);
            }
            return false;
        }
          
        

        static private bool checkandCreateStartup() {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                String myKey = "Aifapiao Shuikong Tool";
                String myValue = "\"" + Application.ExecutablePath + "\"";
                if (key.GetValue(myKey) == null || key.GetValue(myKey).ToString() != myValue)
                {
                    key.SetValue(myKey, "\"" + Application.ExecutablePath + "\"");
                    return true;
                }
            }
            return false;
        }

        static private bool checkAndCreateShortcut()
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            String shortcutFn = deskDir + "\\" + "爱发票辅助打印工具" + ".url";
            if (!File.Exists(shortcutFn))
            {
                using (StreamWriter writer = new StreamWriter(shortcutFn))
                {
                    string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    writer.WriteLine("[InternetShortcut]");
                    writer.WriteLine("URL=file:///" + app);
                    writer.WriteLine("IconIndex=0");
                    string icon = app.Replace('\\', '/');
                    writer.WriteLine("IconFile=" + icon);
                    writer.Flush();
                }
                return true;
            }
            return false;
        }


        static private String detectShuikong()
        {
            String sk_list = getShuikongInfoList();
            if (sk_list != null)
            {
                foreach (String str in Win32Locator.GetWindows())
                {
                    if (WndInteract.Win32Locator.HasChinese(str) && sk_list.IndexOf(str) != -1)
                    {
                        return str;
                    }
                };
            }
            return null;
        }

        static private String getShuikongInfoList()
        {
            Uri url = new Uri(system_const.service_url + "/skcaptionlist");
            try
            {
                String res = mWorkClient.DownloadString(url);
                return res;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
