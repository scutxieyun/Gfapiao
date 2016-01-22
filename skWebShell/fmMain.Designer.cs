namespace skWebShell
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpActive = new System.Windows.Forms.TabPage();
            this.lvActReq = new System.Windows.Forms.ListView();
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDone = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.wbMain);
            this.scMain.Panel1MinSize = 40;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.ssMain);
            this.scMain.Panel2.Controls.Add(this.tcMain);
            this.scMain.Panel2.Resize += new System.EventHandler(this.scMain_Panel2_Resize);
            this.scMain.Size = new System.Drawing.Size(1182, 894);
            this.scMain.SplitterDistance = 512;
            this.scMain.TabIndex = 0;
            // 
            // wbMain
            // 
            this.wbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(1182, 512);
            this.wbMain.TabIndex = 0;
            this.wbMain.Url = new System.Uri("https://fp.gdltax.gov.cn/", System.UriKind.Absolute);
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.ssMain.Location = new System.Drawing.Point(0, 348);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1182, 30);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(67, 28);
            this.toolStripSplitButton1.Text = "刷新";
            this.toolStripSplitButton1.Click += new System.EventHandler(this.toolStripSplitButton1_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpActive);
            this.tcMain.Controls.Add(this.tpDone);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1182, 311);
            this.tcMain.TabIndex = 0;
            // 
            // tpActive
            // 
            this.tpActive.Controls.Add(this.lvActReq);
            this.tpActive.Location = new System.Drawing.Point(4, 28);
            this.tpActive.Name = "tpActive";
            this.tpActive.Padding = new System.Windows.Forms.Padding(3);
            this.tpActive.Size = new System.Drawing.Size(1174, 279);
            this.tpActive.TabIndex = 0;
            this.tpActive.Text = "待打印";
            this.tpActive.UseVisualStyleBackColor = true;
            // 
            // lvActReq
            // 
            this.lvActReq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTime,
            this.clBrief,
            this.clTitle});
            this.lvActReq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvActReq.Location = new System.Drawing.Point(3, 3);
            this.lvActReq.Name = "lvActReq";
            this.lvActReq.Size = new System.Drawing.Size(1168, 273);
            this.lvActReq.TabIndex = 0;
            this.lvActReq.UseCompatibleStateImageBehavior = false;
            this.lvActReq.View = System.Windows.Forms.View.Details;
            this.lvActReq.DoubleClick += new System.EventHandler(this.lvActReq_DoubleClick);
            // 
            // clTime
            // 
            this.clTime.Text = "时间";
            this.clTime.Width = 211;
            // 
            // clBrief
            // 
            this.clBrief.Text = "交易信息";
            this.clBrief.Width = 311;
            // 
            // clTitle
            // 
            this.clTitle.Text = "抬头";
            this.clTitle.Width = 664;
            // 
            // tpDone
            // 
            this.tpDone.Location = new System.Drawing.Point(4, 28);
            this.tpDone.Name = "tpDone";
            this.tpDone.Padding = new System.Windows.Forms.Padding(3);
            this.tpDone.Size = new System.Drawing.Size(1174, 279);
            this.tpDone.TabIndex = 1;
            this.tpDone.Text = "已打印";
            this.tpDone.UseVisualStyleBackColor = true;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 894);
            this.Controls.Add(this.scMain);
            this.Name = "fmMain";
            this.Text = "税控系统";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpActive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpActive;
        private System.Windows.Forms.ListView lvActReq;
        private System.Windows.Forms.TabPage tpDone;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ColumnHeader clTime;
        private System.Windows.Forms.ColumnHeader clBrief;
        private System.Windows.Forms.ColumnHeader clTitle;
    }
}

