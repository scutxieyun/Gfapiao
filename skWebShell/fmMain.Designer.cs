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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpActive = new System.Windows.Forms.TabPage();
            this.lvActReq = new System.Windows.Forms.ListView();
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDone = new System.Windows.Forms.TabPage();
            this.fpOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.lvDoneList = new System.Windows.Forms.ListView();
            this.clDoneTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDoneBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDoneTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpActive.SuspendLayout();
            this.tpDone.SuspendLayout();
            this.fpOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Margin = new System.Windows.Forms.Padding(2);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.wbMain);
            this.scMain.Panel1MinSize = 40;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.fpOperation);
            this.scMain.Panel2.Controls.Add(this.tcMain);
            this.scMain.Panel2.Resize += new System.EventHandler(this.scMain_Panel2_Resize);
            this.scMain.Size = new System.Drawing.Size(1058, 475);
            this.scMain.SplitterDistance = 752;
            this.scMain.SplitterWidth = 3;
            this.scMain.TabIndex = 0;
            // 
            // wbMain
            // 
            this.wbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.Margin = new System.Windows.Forms.Padding(2);
            this.wbMain.MinimumSize = new System.Drawing.Size(13, 13);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(752, 475);
            this.wbMain.TabIndex = 0;
            this.wbMain.Url = new System.Uri("https://fp.gdltax.gov.cn/", System.UriKind.Absolute);
            this.wbMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMain_DocumentCompleted);
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMain.Controls.Add(this.tpActive);
            this.tcMain.Controls.Add(this.tpDone);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcMain.Location = new System.Drawing.Point(0, 34);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(303, 441);
            this.tcMain.TabIndex = 0;
            // 
            // tpActive
            // 
            this.tpActive.Controls.Add(this.lvActReq);
            this.tpActive.Location = new System.Drawing.Point(4, 4);
            this.tpActive.Margin = new System.Windows.Forms.Padding(2);
            this.tpActive.Name = "tpActive";
            this.tpActive.Padding = new System.Windows.Forms.Padding(2);
            this.tpActive.Size = new System.Drawing.Size(295, 415);
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
            this.lvActReq.FullRowSelect = true;
            this.lvActReq.Location = new System.Drawing.Point(2, 2);
            this.lvActReq.Margin = new System.Windows.Forms.Padding(2);
            this.lvActReq.MultiSelect = false;
            this.lvActReq.Name = "lvActReq";
            this.lvActReq.Size = new System.Drawing.Size(291, 411);
            this.lvActReq.TabIndex = 0;
            this.lvActReq.UseCompatibleStateImageBehavior = false;
            this.lvActReq.View = System.Windows.Forms.View.Details;
            this.lvActReq.DoubleClick += new System.EventHandler(this.lvActReq_DoubleClick);
            // 
            // clTime
            // 
            this.clTime.DisplayIndex = 2;
            this.clTime.Text = "时间";
            this.clTime.Width = 69;
            // 
            // clBrief
            // 
            this.clBrief.Text = "交易信息";
            this.clBrief.Width = 96;
            // 
            // clTitle
            // 
            this.clTitle.Text = "抬头";
            this.clTitle.Width = 100;
            // 
            // tpDone
            // 
            this.tpDone.Controls.Add(this.lvDoneList);
            this.tpDone.Location = new System.Drawing.Point(4, 4);
            this.tpDone.Margin = new System.Windows.Forms.Padding(2);
            this.tpDone.Name = "tpDone";
            this.tpDone.Padding = new System.Windows.Forms.Padding(2);
            this.tpDone.Size = new System.Drawing.Size(295, 415);
            this.tpDone.TabIndex = 1;
            this.tpDone.Text = "已打印";
            this.tpDone.UseVisualStyleBackColor = true;
            // 
            // fpOperation
            // 
            this.fpOperation.Controls.Add(this.btRefresh);
            this.fpOperation.Controls.Add(this.btTest);
            this.fpOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpOperation.Location = new System.Drawing.Point(0, 0);
            this.fpOperation.Name = "fpOperation";
            this.fpOperation.Size = new System.Drawing.Size(303, 29);
            this.fpOperation.TabIndex = 1;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(3, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "刷新";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(84, 3);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 1;
            this.btTest.Text = "测试";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // lvDoneList
            // 
            this.lvDoneList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clDoneTime,
            this.clDoneBrief,
            this.clDoneTitle});
            this.lvDoneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDoneList.Location = new System.Drawing.Point(2, 2);
            this.lvDoneList.Name = "lvDoneList";
            this.lvDoneList.Size = new System.Drawing.Size(291, 411);
            this.lvDoneList.TabIndex = 0;
            this.lvDoneList.UseCompatibleStateImageBehavior = false;
            this.lvDoneList.View = System.Windows.Forms.View.Details;
            // 
            // clDoneTime
            // 
            this.clDoneTime.Text = "请求时间";
            this.clDoneTime.Width = 71;
            // 
            // clDoneBrief
            // 
            this.clDoneBrief.Text = "交易信息";
            this.clDoneBrief.Width = 127;
            // 
            // clDoneTitle
            // 
            this.clDoneTitle.Text = "抬头";
            this.clDoneTitle.Width = 94;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 475);
            this.Controls.Add(this.scMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fmMain";
            this.Text = "爱发票复制打印";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpActive.ResumeLayout(false);
            this.tpDone.ResumeLayout(false);
            this.fpOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpActive;
        private System.Windows.Forms.ListView lvActReq;
        private System.Windows.Forms.TabPage tpDone;
        private System.Windows.Forms.ColumnHeader clTime;
        private System.Windows.Forms.ColumnHeader clBrief;
        private System.Windows.Forms.ColumnHeader clTitle;
        private System.Windows.Forms.FlowLayoutPanel fpOperation;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.ListView lvDoneList;
        private System.Windows.Forms.ColumnHeader clDoneTime;
        private System.Windows.Forms.ColumnHeader clDoneBrief;
        private System.Windows.Forms.ColumnHeader clDoneTitle;
    }
}

