using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace GFapiaoClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            checkAndCreateShortcut();

            checkandCreateStartup();

            //checkSKScript();

            if (detectShuikong() == null) {

            }


            Application.Run(new fmMain());
        }

        static WebClient mWorkClient = new WebClient();

        static private bool checkandCreateStartup() {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                String myKey = "Aifapiao Shuikong Tool";
                String myValue = "\"" + Application.ExecutablePath + "\"";
                if (key.GetValue(myKey).ToString() != myValue)
                {
                    key.SetValue("My Program", "\"" + Application.ExecutablePath + "\"");
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
