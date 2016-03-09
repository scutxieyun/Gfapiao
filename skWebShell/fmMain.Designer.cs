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
            this.components = new System.ComponentModel.Container();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.btShowPanel = new System.Windows.Forms.Button();
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.plCrArea = new System.Windows.Forms.Panel();
            this.plStoreInfo = new System.Windows.Forms.Panel();
            this.llStoreURL = new System.Windows.Forms.LinkLabel();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpActive = new System.Windows.Forms.TabPage();
            this.lvActReq = new System.Windows.Forms.ListView();
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpDone = new System.Windows.Forms.TabPage();
            this.lvDoneList = new System.Windows.Forms.ListView();
            this.clDoneTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDoneBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDoneTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fpOperation = new System.Windows.Forms.FlowLayoutPanel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.tmDelayInject = new System.Windows.Forms.Timer(this.components);
            this.pdQRCode = new System.Drawing.Printing.PrintDocument();
            this.pdMain = new System.Windows.Forms.PrintDialog();
            this.tmPollRpt = new System.Windows.Forms.Timer(this.components);
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.plCrArea.SuspendLayout();
            this.plStoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
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
            this.scMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btShowPanel);
            this.scMain.Panel1.Controls.Add(this.wbMain);
            this.scMain.Panel1MinSize = 40;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.plCrArea);
            this.scMain.Panel2.Controls.Add(this.fpOperation);
            this.scMain.Panel2.Resize += new System.EventHandler(this.scMain_Panel2_Resize);
            this.scMain.Size = new System.Drawing.Size(1043, 559);
            this.scMain.SplitterDistance = 796;
            this.scMain.SplitterWidth = 3;
            this.scMain.TabIndex = 0;
            // 
            // btShowPanel
            // 
            this.btShowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowPanel.AutoEllipsis = true;
            this.btShowPanel.BackColor = System.Drawing.Color.Silver;
            this.btShowPanel.Location = new System.Drawing.Point(712, 3);
            this.btShowPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btShowPanel.Name = "btShowPanel";
            this.btShowPanel.Size = new System.Drawing.Size(57, 23);
            this.btShowPanel.TabIndex = 1;
            this.btShowPanel.Text = "工具";
            this.btShowPanel.UseVisualStyleBackColor = false;
            this.btShowPanel.Visible = false;
            this.btShowPanel.Click += new System.EventHandler(this.btShowPanel_Click);
            // 
            // wbMain
            // 
            this.wbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMain.Location = new System.Drawing.Point(0, 0);
            this.wbMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wbMain.MinimumSize = new System.Drawing.Size(13, 13);
            this.wbMain.Name = "wbMain";
            this.wbMain.Size = new System.Drawing.Size(796, 559);
            this.wbMain.TabIndex = 0;
            this.wbMain.Url = new System.Uri("http://127.0.0.1/public/jstest.html", System.UriKind.Absolute);
            this.wbMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMain_DocumentCompleted);
            // 
            // plCrArea
            // 
            this.plCrArea.Controls.Add(this.plStoreInfo);
            this.plCrArea.Controls.Add(this.tcMain);
            this.plCrArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plCrArea.Location = new System.Drawing.Point(0, 35);
            this.plCrArea.Name = "plCrArea";
            this.plCrArea.Size = new System.Drawing.Size(244, 524);
            this.plCrArea.TabIndex = 2;
            // 
            // plStoreInfo
            // 
            this.plStoreInfo.Controls.Add(this.llStoreURL);
            this.plStoreInfo.Controls.Add(this.pbScan);
            this.plStoreInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plStoreInfo.Location = new System.Drawing.Point(0, 360);
            this.plStoreInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plStoreInfo.Name = "plStoreInfo";
            this.plStoreInfo.Size = new System.Drawing.Size(244, 164);
            this.plStoreInfo.TabIndex = 2;
            // 
            // llStoreURL
            // 
            this.llStoreURL.AutoSize = true;
            this.llStoreURL.Location = new System.Drawing.Point(12, 8);
            this.llStoreURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llStoreURL.Name = "llStoreURL";
            this.llStoreURL.Size = new System.Drawing.Size(53, 12);
            this.llStoreURL.TabIndex = 2;
            this.llStoreURL.TabStop = true;
            this.llStoreURL.Text = "我的信息";
            this.llStoreURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llStoreURL_LinkClicked);
            // 
            // pbScan
            // 
            this.pbScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbScan.Location = new System.Drawing.Point(0, 23);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(244, 141);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScan.TabIndex = 1;
            this.pbScan.TabStop = false;
            this.pbScan.Click += new System.EventHandler(this.pbScan_Click);
            this.pbScan.DoubleClick += new System.EventHandler(this.pbScan_DoubleClick);
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMain.Controls.Add(this.tpActive);
            this.tcMain.Controls.Add(this.tpDone);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(244, 349);
            this.tcMain.TabIndex = 0;
            // 
            // tpActive
            // 
            this.tpActive.Controls.Add(this.lvActReq);
            this.tpActive.Location = new System.Drawing.Point(4, 4);
            this.tpActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpActive.Name = "tpActive";
            this.tpActive.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpActive.Size = new System.Drawing.Size(236, 323);
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
            this.lvActReq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvActReq.MultiSelect = false;
            this.lvActReq.Name = "lvActReq";
            this.lvActReq.Size = new System.Drawing.Size(232, 319);
            this.lvActReq.TabIndex = 0;
            this.lvActReq.UseCompatibleStateImageBehavior = false;
            this.lvActReq.View = System.Windows.Forms.View.Details;
            this.lvActReq.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lvActReq_DrawItem);
            this.lvActReq.DoubleClick += new System.EventHandler(this.lvActReq_DoubleClick);
            this.lvActReq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvActReq_KeyPress);
            // 
            // clTime
            // 
            this.clTime.DisplayIndex = 2;
            this.clTime.Text = "时间";
            this.clTime.Width = 93;
            // 
            // clBrief
            // 
            this.clBrief.DisplayIndex = 0;
            this.clBrief.Text = "交易信息";
            this.clBrief.Width = 96;
            // 
            // clTitle
            // 
            this.clTitle.DisplayIndex = 1;
            this.clTitle.Text = "抬头";
            this.clTitle.Width = 148;
            // 
            // tpDone
            // 
            this.tpDone.Controls.Add(this.lvDoneList);
            this.tpDone.Location = new System.Drawing.Point(4, 4);
            this.tpDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDone.Name = "tpDone";
            this.tpDone.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tpDone.Size = new System.Drawing.Size(235, 323);
            this.tpDone.TabIndex = 1;
            this.tpDone.Text = "已打印";
            this.tpDone.UseVisualStyleBackColor = true;
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
            this.lvDoneList.Size = new System.Drawing.Size(231, 319);
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
            // fpOperation
            // 
            this.fpOperation.Controls.Add(this.btRefresh);
            this.fpOperation.Controls.Add(this.btTest);
            this.fpOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpOperation.Location = new System.Drawing.Point(0, 0);
            this.fpOperation.Name = "fpOperation";
            this.fpOperation.Size = new System.Drawing.Size(244, 29);
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
            this.btTest.Text = "隐藏";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // tmDelayInject
            // 
            this.tmDelayInject.Interval = 2000;
            this.tmDelayInject.Tick += new System.EventHandler(this.tmDelayInject_Tick);
            // 
            // pdQRCode
            // 
            this.pdQRCode.DocumentName = "二维码";
            this.pdQRCode.OriginAtMargins = true;
            this.pdQRCode.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdQRCode_PrintPage);
            // 
            // pdMain
            // 
            this.pdMain.AllowCurrentPage = true;
            this.pdMain.AllowSelection = true;
            this.pdMain.Document = this.pdQRCode;
            this.pdMain.PrintToFile = true;
            this.pdMain.ShowHelp = true;
            this.pdMain.UseEXDialog = true;
            // 
            // tmPollRpt
            // 
            this.tmPollRpt.Enabled = true;
            this.tmPollRpt.Interval = 30000;
            this.tmPollRpt.Tick += new System.EventHandler(this.tmPollRpt_Tick);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 559);
            this.Controls.Add(this.scMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fmMain";
            this.Text = "发票易";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.ResumeLayout(false);
            this.plCrArea.ResumeLayout(false);
            this.plStoreInfo.ResumeLayout(false);
            this.plStoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
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
        private System.Windows.Forms.Button btShowPanel;
        private System.Windows.Forms.Timer tmDelayInject;
        private System.Windows.Forms.Panel plCrArea;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Drawing.Printing.PrintDocument pdQRCode;
        private System.Windows.Forms.PrintDialog pdMain;
        private System.Windows.Forms.Timer tmPollRpt;
        private System.Windows.Forms.Panel plStoreInfo;
        private System.Windows.Forms.LinkLabel llStoreURL;
    }
}

