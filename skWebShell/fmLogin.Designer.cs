﻿namespace skWebShell
{
    partial class fmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.btValidate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValidate = new System.Windows.Forms.TextBox();
            this.btGetConf = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbRegister = new System.Windows.Forms.LinkLabel();
            this.trSuppress = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "手机号";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(83, 60);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(151, 21);
            this.tbMobile.TabIndex = 1;
            this.tbMobile.TextChanged += new System.EventHandler(this.tbMobile_TextChanged);
            // 
            // btValidate
            // 
            this.btValidate.Location = new System.Drawing.Point(240, 60);
            this.btValidate.Name = "btValidate";
            this.btValidate.Size = new System.Drawing.Size(75, 23);
            this.btValidate.TabIndex = 2;
            this.btValidate.Text = "获取验证码";
            this.btValidate.UseVisualStyleBackColor = true;
            this.btValidate.Click += new System.EventHandler(this.btValidate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "验证码";
            // 
            // tbValidate
            // 
            this.tbValidate.Enabled = false;
            this.tbValidate.Location = new System.Drawing.Point(83, 94);
            this.tbValidate.Name = "tbValidate";
            this.tbValidate.Size = new System.Drawing.Size(151, 21);
            this.tbValidate.TabIndex = 4;
            // 
            // btGetConf
            // 
            this.btGetConf.Enabled = false;
            this.btGetConf.Location = new System.Drawing.Point(159, 130);
            this.btGetConf.Name = "btGetConf";
            this.btGetConf.Size = new System.Drawing.Size(75, 23);
            this.btGetConf.TabIndex = 5;
            this.btGetConf.Text = "获取配置";
            this.btGetConf.UseVisualStyleBackColor = true;
            this.btGetConf.Click += new System.EventHandler(this.btGetConf_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(240, 130);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "取消";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Location = new System.Drawing.Point(153, 31);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(101, 12);
            this.lbRegister.TabIndex = 7;
            this.lbRegister.TabStop = true;
            this.lbRegister.Text = "点击链接进行注册";
            // 
            // trSuppress
            // 
            this.trSuppress.Interval = 1000;
            this.trSuppress.Tick += new System.EventHandler(this.trSuppress_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "软件配置与硬件信息不一致，或者该硬件没有注册过。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "如手机没有注册过，请";
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btGetConf);
            this.Controls.Add(this.tbValidate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btValidate);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "开票易登录与认证";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Button btValidate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValidate;
        private System.Windows.Forms.Button btGetConf;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.LinkLabel lbRegister;
        private System.Windows.Forms.Timer trSuppress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}