namespace GFapiaoClient
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "1",
            "2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "23",
            "34"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "34",
            "2",
            "3"}, -1);
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPrint = new System.Windows.Forms.TabPage();
            this.lvReqList = new System.Windows.Forms.ListView();
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpHistory = new System.Windows.Forms.TabPage();
            this.lvDoneList = new System.Windows.Forms.ListView();
            this.doneClTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doneClBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doneClTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmSXX = new System.Windows.Forms.Timer(this.components);
            this.plMain = new System.Windows.Forms.Panel();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.flpOperator = new System.Windows.Forms.FlowLayoutPanel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btReject = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCreateShortCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEnableStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCollectEnv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain.SuspendLayout();
            this.tpPrint.SuspendLayout();
            this.tpHistory.SuspendLayout();
            this.plMain.SuspendLayout();
            this.flpOperator.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpPrint);
            this.tcMain.Controls.Add(this.tpHistory);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(413, 189);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpPrint
            // 
            this.tpPrint.Controls.Add(this.lvReqList);
            this.tpPrint.Location = new System.Drawing.Point(4, 22);
            this.tpPrint.Name = "tpPrint";
            this.tpPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrint.Size = new System.Drawing.Size(405, 163);
            this.tpPrint.TabIndex = 0;
            this.tpPrint.Text = "打印列表";
            this.tpPrint.UseVisualStyleBackColor = true;
            // 
            // lvReqList
            // 
            this.lvReqList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clTime,
            this.clBrief,
            this.clTitle});
            this.lvReqList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvReqList.FullRowSelect = true;
            this.lvReqList.GridLines = true;
            this.lvReqList.HideSelection = false;
            this.lvReqList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvReqList.Location = new System.Drawing.Point(3, 3);
            this.lvReqList.MultiSelect = false;
            this.lvReqList.Name = "lvReqList";
            this.lvReqList.Size = new System.Drawing.Size(399, 157);
            this.lvReqList.TabIndex = 0;
            this.lvReqList.UseCompatibleStateImageBehavior = false;
            this.lvReqList.View = System.Windows.Forms.View.Details;
            this.lvReqList.SelectedIndexChanged += new System.EventHandler(this.lvReqList_SelectedIndexChanged);
            this.lvReqList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvReqList_MouseDoubleClick);
            // 
            // clTime
            // 
            this.clTime.Text = "时间";
            this.clTime.Width = 65;
            // 
            // clBrief
            // 
            this.clBrief.Text = "交易信息";
            this.clBrief.Width = 129;
            // 
            // clTitle
            // 
            this.clTitle.Text = "抬头";
            this.clTitle.Width = 189;
            // 
            // tpHistory
            // 
            this.tpHistory.Controls.Add(this.lvDoneList);
            this.tpHistory.Location = new System.Drawing.Point(4, 22);
            this.tpHistory.Name = "tpHistory";
            this.tpHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tpHistory.Size = new System.Drawing.Size(405, 163);
            this.tpHistory.TabIndex = 1;
            this.tpHistory.Text = "历史纪录";
            this.tpHistory.UseVisualStyleBackColor = true;
            // 
            // lvDoneList
            // 
            this.lvDoneList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.doneClTime,
            this.doneClBrief,
            this.doneClTitle});
            this.lvDoneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDoneList.FullRowSelect = true;
            this.lvDoneList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lvDoneList.Location = new System.Drawing.Point(3, 3);
            this.lvDoneList.MultiSelect = false;
            this.lvDoneList.Name = "lvDoneList";
            this.lvDoneList.Size = new System.Drawing.Size(399, 157);
            this.lvDoneList.TabIndex = 0;
            this.lvDoneList.UseCompatibleStateImageBehavior = false;
            this.lvDoneList.View = System.Windows.Forms.View.Details;
            // 
            // doneClTime
            // 
            this.doneClTime.Text = "打印时间";
            this.doneClTime.Width = 115;
            // 
            // doneClBrief
            // 
            this.doneClBrief.Text = "交易概要";
            this.doneClBrief.Width = 158;
            // 
            // doneClTitle
            // 
            this.doneClTitle.Text = "打印抬头";
            // 
            // tmSXX
            // 
            this.tmSXX.Enabled = true;
            this.tmSXX.Interval = 30000;
            this.tmSXX.Tick += new System.EventHandler(this.tmSXX_Tick);
            // 
            // plMain
            // 
            this.plMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plMain.Controls.Add(this.tcMain);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMain.Location = new System.Drawing.Point(0, 25);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(413, 189);
            this.plMain.TabIndex = 3;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(0, 224);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(413, 22);
            this.ssStatus.TabIndex = 4;
            this.ssStatus.Text = "statusStrip1";
            // 
            // flpOperator
            // 
            this.flpOperator.Controls.Add(this.btRefresh);
            this.flpOperator.Controls.Add(this.btPrint);
            this.flpOperator.Controls.Add(this.btReject);
            this.flpOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpOperator.Location = new System.Drawing.Point(0, 191);
            this.flpOperator.Name = "flpOperator";
            this.flpOperator.Size = new System.Drawing.Size(413, 33);
            this.flpOperator.TabIndex = 5;
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
            // btPrint
            // 
            this.btPrint.Enabled = false;
            this.btPrint.Location = new System.Drawing.Point(84, 3);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 1;
            this.btPrint.Text = "打印";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btReject
            // 
            this.btReject.Enabled = false;
            this.btReject.Location = new System.Drawing.Point(165, 3);
            this.btReject.Name = "btReject";
            this.btReject.Size = new System.Drawing.Size(75, 23);
            this.btReject.TabIndex = 2;
            this.btReject.Text = "拒绝";
            this.btReject.UseVisualStyleBackColor = true;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(413, 25);
            this.msMain.TabIndex = 6;
            this.msMain.Text = "功能";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRegister,
            this.tsmCreateShortCut,
            this.tsmEnableStartup,
            this.tsmCollectEnv,
            this.tsmDownload});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "功能";
            // 
            // tsmCreateShortCut
            // 
            this.tsmCreateShortCut.Name = "tsmCreateShortCut";
            this.tsmCreateShortCut.Size = new System.Drawing.Size(152, 22);
            this.tsmCreateShortCut.Text = "创建快捷方式";
            this.tsmCreateShortCut.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmEnableStartup
            // 
            this.tsmEnableStartup.Name = "tsmEnableStartup";
            this.tsmEnableStartup.Size = new System.Drawing.Size(152, 22);
            this.tsmEnableStartup.Text = "自动启动";
            this.tsmEnableStartup.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // tsmCollectEnv
            // 
            this.tsmCollectEnv.Name = "tsmCollectEnv";
            this.tsmCollectEnv.Size = new System.Drawing.Size(152, 22);
            this.tsmCollectEnv.Text = "上传环境信息";
            // 
            // tsmDownload
            // 
            this.tsmDownload.Name = "tsmDownload";
            this.tsmDownload.Size = new System.Drawing.Size(152, 22);
            this.tsmDownload.Text = "下载配置";
            this.tsmDownload.Click += new System.EventHandler(this.tsmDownload_Click);
            // 
            // tsmRegister
            // 
            this.tsmRegister.Name = "tsmRegister";
            this.tsmRegister.Size = new System.Drawing.Size(152, 22);
            this.tsmRegister.Text = "注册";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 246);
            this.Controls.Add(this.flpOperator);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "fmMain";
            this.Text = "发票辅助打印工具";
            this.Resize += new System.EventHandler(this.fmMain_Resize);
            this.tcMain.ResumeLayout(false);
            this.tpPrint.ResumeLayout(false);
            this.tpHistory.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            this.flpOperator.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpPrint;
        private System.Windows.Forms.ListView lvReqList;
        private System.Windows.Forms.ColumnHeader clTime;
        private System.Windows.Forms.ColumnHeader clBrief;
        private System.Windows.Forms.ColumnHeader clTitle;
        private System.Windows.Forms.TabPage tpHistory;
        private System.Windows.Forms.Timer tmSXX;
        private System.Windows.Forms.ListView lvDoneList;
        private System.Windows.Forms.ColumnHeader doneClTime;
        private System.Windows.Forms.ColumnHeader doneClBrief;
        private System.Windows.Forms.ColumnHeader doneClTitle;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.FlowLayoutPanel flpOperator;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btReject;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmCreateShortCut;
        private System.Windows.Forms.ToolStripMenuItem tsmEnableStartup;
        private System.Windows.Forms.ToolStripMenuItem tsmCollectEnv;
        private System.Windows.Forms.ToolStripMenuItem tsmDownload;
        private System.Windows.Forms.ToolStripMenuItem tsmRegister;
    }
}

