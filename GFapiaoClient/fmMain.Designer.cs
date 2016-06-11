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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpPrint = new System.Windows.Forms.TabPage();
            this.lvReqList = new System.Windows.Forms.ListView();
            this.clBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpHistory = new System.Windows.Forms.TabPage();
            this.lvDoneList = new System.Windows.Forms.ListView();
            this.doneClBrief = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doneClTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.doneClTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tmSXX = new System.Windows.Forms.Timer(this.components);
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.pbScan = new System.Windows.Forms.PictureBox();
            this.fplOperator = new System.Windows.Forms.Panel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.plMain = new System.Windows.Forms.Panel();
            this.seStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcMain.SuspendLayout();
            this.tpPrint.SuspendLayout();
            this.tpHistory.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).BeginInit();
            this.fplOperator.SuspendLayout();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcMain.Controls.Add(this.tpPrint);
            this.tcMain.Controls.Add(this.tpHistory);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4);
            this.tcMain.Multiline = true;
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(464, 290);
            this.tcMain.TabIndex = 0;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpPrint
            // 
            this.tpPrint.Controls.Add(this.lvReqList);
            this.tpPrint.Location = new System.Drawing.Point(4, 4);
            this.tpPrint.Margin = new System.Windows.Forms.Padding(4);
            this.tpPrint.Name = "tpPrint";
            this.tpPrint.Padding = new System.Windows.Forms.Padding(4);
            this.tpPrint.Size = new System.Drawing.Size(456, 258);
            this.tpPrint.TabIndex = 0;
            this.tpPrint.Text = "打印列表";
            this.tpPrint.UseVisualStyleBackColor = true;
            // 
            // lvReqList
            // 
            this.lvReqList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clBrief,
            this.clTitle,
            this.clTime});
            this.lvReqList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvReqList.FullRowSelect = true;
            this.lvReqList.GridLines = true;
            this.lvReqList.HideSelection = false;
            this.lvReqList.Location = new System.Drawing.Point(4, 4);
            this.lvReqList.Margin = new System.Windows.Forms.Padding(4);
            this.lvReqList.MultiSelect = false;
            this.lvReqList.Name = "lvReqList";
            this.lvReqList.Size = new System.Drawing.Size(448, 250);
            this.lvReqList.TabIndex = 0;
            this.lvReqList.UseCompatibleStateImageBehavior = false;
            this.lvReqList.View = System.Windows.Forms.View.Details;
            this.lvReqList.SelectedIndexChanged += new System.EventHandler(this.lvReqList_SelectedIndexChanged);
            this.lvReqList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvReqList_KeyPress);
            this.lvReqList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvReqList_KeyUp);
            this.lvReqList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvReqList_MouseDoubleClick);
            // 
            // clBrief
            // 
            this.clBrief.Text = "交易信息";
            this.clBrief.Width = 124;
            // 
            // clTitle
            // 
            this.clTitle.Text = "抬头";
            this.clTitle.Width = 189;
            // 
            // clTime
            // 
            this.clTime.Text = "时间";
            this.clTime.Width = 94;
            // 
            // tpHistory
            // 
            this.tpHistory.Controls.Add(this.lvDoneList);
            this.tpHistory.Location = new System.Drawing.Point(4, 4);
            this.tpHistory.Margin = new System.Windows.Forms.Padding(4);
            this.tpHistory.Name = "tpHistory";
            this.tpHistory.Padding = new System.Windows.Forms.Padding(4);
            this.tpHistory.Size = new System.Drawing.Size(456, 258);
            this.tpHistory.TabIndex = 1;
            this.tpHistory.Text = "历史纪录";
            this.tpHistory.UseVisualStyleBackColor = true;
            // 
            // lvDoneList
            // 
            this.lvDoneList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.doneClBrief,
            this.doneClTitle,
            this.doneClTime});
            this.lvDoneList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDoneList.FullRowSelect = true;
            this.lvDoneList.Location = new System.Drawing.Point(4, 4);
            this.lvDoneList.Margin = new System.Windows.Forms.Padding(4);
            this.lvDoneList.MultiSelect = false;
            this.lvDoneList.Name = "lvDoneList";
            this.lvDoneList.Size = new System.Drawing.Size(448, 250);
            this.lvDoneList.TabIndex = 0;
            this.lvDoneList.UseCompatibleStateImageBehavior = false;
            this.lvDoneList.View = System.Windows.Forms.View.Details;
            this.lvDoneList.DoubleClick += new System.EventHandler(this.lvDoneList_DoubleClick);
            this.lvDoneList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvDoneList_KeyUp);
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
            // doneClTime
            // 
            this.doneClTime.Text = "打印时间";
            this.doneClTime.Width = 115;
            // 
            // tmSXX
            // 
            this.tmSXX.Interval = 30000;
            this.tmSXX.Tick += new System.EventHandler(this.tmSXX_Tick);
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 660);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssStatus.Size = new System.Drawing.Size(464, 29);
            this.ssStatus.TabIndex = 4;
            this.ssStatus.Text = "statusStrip1";
            // 
            // pbScan
            // 
            this.pbScan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbScan.Location = new System.Drawing.Point(0, 339);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(464, 321);
            this.pbScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScan.TabIndex = 7;
            this.pbScan.TabStop = false;
            // 
            // fplOperator
            // 
            this.fplOperator.Controls.Add(this.btRefresh);
            this.fplOperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.fplOperator.Location = new System.Drawing.Point(0, 0);
            this.fplOperator.Name = "fplOperator";
            this.fplOperator.Size = new System.Drawing.Size(464, 50);
            this.fplOperator.TabIndex = 8;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(17, 10);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(82, 33);
            this.btRefresh.TabIndex = 0;
            this.btRefresh.Text = "刷新";
            this.btRefresh.UseVisualStyleBackColor = true;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.tcMain);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMain.Location = new System.Drawing.Point(0, 50);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(464, 290);
            this.plMain.TabIndex = 9;
            // 
            // seStatus
            // 
            this.seStatus.Name = "seStatus";
            this.seStatus.Size = new System.Drawing.Size(64, 24);
            this.seStatus.Text = "Ready";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 689);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.fplOperator);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.ssStatus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMain";
            this.Text = "发票辅助打印工具";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.Resize += new System.EventHandler(this.fmMain_Resize);
            this.tcMain.ResumeLayout(false);
            this.tpPrint.ResumeLayout(false);
            this.tpHistory.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScan)).EndInit();
            this.fplOperator.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpPrint;
        private System.Windows.Forms.ListView lvReqList;
        private System.Windows.Forms.ColumnHeader clTime;
        private System.Windows.Forms.ColumnHeader clTitle;
        private System.Windows.Forms.TabPage tpHistory;
        private System.Windows.Forms.Timer tmSXX;
        private System.Windows.Forms.ListView lvDoneList;
        private System.Windows.Forms.ColumnHeader doneClTime;
        private System.Windows.Forms.ColumnHeader doneClBrief;
        private System.Windows.Forms.ColumnHeader doneClTitle;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.PictureBox pbScan;
        private System.Windows.Forms.Panel fplOperator;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.ColumnHeader clBrief;
        private System.Windows.Forms.ToolStripStatusLabel seStatus;
    }
}

