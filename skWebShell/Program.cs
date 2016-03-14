using System;
using System.Windows.Forms;
using System.Net;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
namespace skWebShell
{
    static class Program
    {
        static public String pos_id = "unknown";
        static public NetworkInterface nic = null;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WebClient wb = new WebClient();
            String init_data = null;
            try
            {

                if (NetworkInterface.GetAllNetworkInterfaces().Length > 0)
                {
                    nic = NetworkInterface.GetAllNetworkInterfaces()[0];
                }
                else {
                    MessageBox.Show("不能检测到网络连接，请检查网卡");
                    return;
                }
                pos_id = ConfigurationManager.AppSettings["pos_id"];
                wb.Encoding = System.Text.Encoding.UTF8;
                init_data = wb.DownloadString(String.Format("{0:s}/fppos/ping?pos_id={1:s}&pos_ver={2:s}&nic={3:s}", system_const.entry, pos_id, system_const.version,nic.GetPhysicalAddress()));
                if (init_data == "update")
                {
                    if (startUpdate()) return;
                }
                if (init_data == "unregistered") {
                    if((new fmLogin()).ShowDialog() == DialogResult.Cancel) return;
                }
                
            }
            catch(Exception e) {
                MessageBox.Show("系统错误，请联系技术支持 " + e.Message);
                return;
            }
            checkAndCreateShortcut();
            Application.Run(new fmMain(init_data));
        }
        static bool startUpdate() {
            try
            {
                Process p = Process.Start("UpdateTool.exe", String.Format("{0:s}/fpmgt/download", system_const.entry));
            }
            catch (Exception ex) {
                return false;
            }
            return true;
        }

        static private bool checkAndCreateShortcut()
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            String shortcutFn = deskDir + "\\" + "发票易税控工具web版" + ".url";
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
    }
}
