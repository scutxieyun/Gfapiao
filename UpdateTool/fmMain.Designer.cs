namespace UpdateTool
{
    partial class fmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btBegin = new System.Windows.Forms.Button();
            this.tbFiles = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(65, 18);
            this.pbDownload.Margin = new System.Windows.Forms.Padding(2);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(245, 15);
            this.pbDownload.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "进度";
            // 
            // btBegin
            // 
            this.btBegin.Location = new System.Drawing.Point(260, 123);
            this.btBegin.Margin = new System.Windows.Forms.Padding(2);
            this.btBegin.Name = "btBegin";
            this.btBegin.Size = new System.Drawing.Size(50, 32);
            this.btBegin.TabIndex = 2;
            this.btBegin.Text = "开始";
            this.btBegin.UseVisualStyleBackColor = true;
            this.btBegin.Click += new System.EventHandler(this.btBegin_Click);
            // 
            // tbFiles
            // 
            this.tbFiles.Location = new System.Drawing.Point(65, 38);
            this.tbFiles.Multiline = true;
            this.tbFiles.Name = "tbFiles";
            this.tbFiles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbFiles.Size = new System.Drawing.Size(245, 80);
            this.tbFiles.TabIndex = 3;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(164, 123);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 32);
            this.btRun.TabIndex = 4;
            this.btRun.Text = "运行";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Visible = false;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 166);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.tbFiles);
            this.Controls.Add(this.btBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发票易升级程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBegin;
        private System.Windows.Forms.TextBox tbFiles;
        private System.Windows.Forms.Button btRun;
    }
}

