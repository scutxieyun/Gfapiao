using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;
namespace skWebShell
{
    public partial class fmLogin : Form
    {
        WebClient wb = new WebClient();
        String hashed_code;
        public fmLogin()
        {
            InitializeComponent();
            lbRegister.Links.Add(0, lbRegister.Text.Length, String.Format("{0:s}/fpmgt/reg_view", system_const.entry)); 
        }

        private void btValidate_Click(object sender, EventArgs e)
        {
            String str = wb.DownloadString(String.Format("{0:s}/fpmgt/validphone?mobile={1:s}",system_const.entry,this.tbMobile.Text));
            if(str == "nok"){
                MessageBox.Show("系统错误，请稍后重试");
                hashed_code = null;
                return;
            }
            if (str == "unregistered")
            {
                MessageBox.Show("请点击注册链接");
                return;

            }
            hashed_code = str;
            btValidate.Enabled = true;
        }

        private void btGetConf_Click(object sender, EventArgs e)
        {
            if (hashed_code != null && hashed_code == generateMD5(tbValidate.Text))
            {
                MessageBox.Show("correct");
            }
            else {
                MessageBox.Show("验证码不正确");
            }
        }

        private String generateMD5(String str) { 
            MD5 md5Hash = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(str));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private void tbMobile_TextChanged(object sender, EventArgs e)
        {
            tbValidate.Enabled = false;
        }
    }
}
