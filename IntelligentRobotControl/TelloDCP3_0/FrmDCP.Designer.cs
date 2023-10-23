
namespace TelloDCP3_0
{
    partial class FrmDCP
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.btnCam = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAlt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBatt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPtfly = new System.Windows.Forms.Button();
            this.btnDownarrow = new System.Windows.Forms.Button();
            this.btnLeftarrow = new System.Windows.Forms.Button();
            this.btnRightarrow = new System.Windows.Forms.Button();
            this.btnUparrow = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnYawmi = new System.Windows.Forms.Button();
            this.btnYawplus = new System.Windows.Forms.Button();
            this.brnUp = new System.Windows.Forms.Button();
            this.btnLand = new System.Windows.Forms.Button();
            this.btnTakeoff = new System.Windows.Forms.Button();
            this.lbComm = new System.Windows.Forms.ListBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.lbCode = new System.Windows.Forms.ListBox();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stepRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(304, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(101, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbCommand
            // 
            this.cbCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Items.AddRange(new object[] {
            "command",
            "takeoff",
            "land"});
            this.cbCommand.Location = new System.Drawing.Point(3, 4);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(300, 23);
            this.cbCommand.TabIndex = 3;
            this.cbCommand.Text = "command";
            // 
            // btnCam
            // 
            this.btnCam.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCam.Location = new System.Drawing.Point(707, 0);
            this.btnCam.Name = "btnCam";
            this.btnCam.Size = new System.Drawing.Size(95, 30);
            this.btnCam.TabIndex = 5;
            this.btnCam.Text = "TelloCam";
            this.btnCam.UseVisualStyleBackColor = true;
            this.btnCam.Click += new System.EventHandler(this.btnCam_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbHead);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbAlt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbBatt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCam);
            this.panel2.Controls.Add(this.cbCommand);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 30);
            this.panel2.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(395, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "deg";
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbHead.Location = new System.Drawing.Point(426, 0);
            this.lbHead.Name = "lbHead";
            this.lbHead.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbHead.Size = new System.Drawing.Size(23, 25);
            this.lbHead.TabIndex = 39;
            this.lbHead.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(449, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "cm Heading: ";
            // 
            // lbAlt
            // 
            this.lbAlt.AutoSize = true;
            this.lbAlt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAlt.Location = new System.Drawing.Point(543, 0);
            this.lbAlt.Name = "lbAlt";
            this.lbAlt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbAlt.Size = new System.Drawing.Size(23, 25);
            this.lbAlt.TabIndex = 37;
            this.lbAlt.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(566, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 36;
            this.label3.Text = "% Altitude:";
            // 
            // lbBatt
            // 
            this.lbBatt.AutoSize = true;
            this.lbBatt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbBatt.Location = new System.Drawing.Point(641, 0);
            this.lbBatt.Name = "lbBatt";
            this.lbBatt.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbBatt.Size = new System.Drawing.Size(23, 25);
            this.lbBatt.TabIndex = 35;
            this.lbBatt.Text = "??";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(664, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 34;
            this.label1.Text = "Batt: ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbLog);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.cbStatus);
            this.panel4.Controls.Add(this.lbStatus);
            this.panel4.Controls.Add(this.lbCode);
            this.panel4.Controls.Add(this.tbEdit);
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(802, 423);
            this.panel4.TabIndex = 29;
            // 
            // cbLog
            // 
            this.cbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLog.AutoSize = true;
            this.cbLog.Location = new System.Drawing.Point(743, 5);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(54, 19);
            this.cbLog.TabIndex = 30;
            this.cbLog.Text = "Log";
            this.cbLog.UseVisualStyleBackColor = true;
            this.cbLog.CheckedChanged += new System.EventHandler(this.cbLog_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbComm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(518, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 393);
            this.panel1.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnPtfly);
            this.panel3.Controls.Add(this.btnDownarrow);
            this.panel3.Controls.Add(this.btnLeftarrow);
            this.panel3.Controls.Add(this.btnRightarrow);
            this.panel3.Controls.Add(this.btnUparrow);
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Controls.Add(this.btnYawmi);
            this.panel3.Controls.Add(this.btnYawplus);
            this.panel3.Controls.Add(this.brnUp);
            this.panel3.Controls.Add(this.btnLand);
            this.panel3.Controls.Add(this.btnTakeoff);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 219);
            this.panel3.TabIndex = 23;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStop.Location = new System.Drawing.Point(156, 176);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 34);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "비상착륙";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPtfly
            // 
            this.btnPtfly.Location = new System.Drawing.Point(11, 177);
            this.btnPtfly.Name = "btnPtfly";
            this.btnPtfly.Size = new System.Drawing.Size(115, 34);
            this.btnPtfly.TabIndex = 14;
            this.btnPtfly.Text = "패턴비행";
            this.btnPtfly.UseVisualStyleBackColor = true;
            this.btnPtfly.Click += new System.EventHandler(this.btnPtfly_Click);
            // 
            // btnDownarrow
            // 
            this.btnDownarrow.Location = new System.Drawing.Point(185, 137);
            this.btnDownarrow.Name = "btnDownarrow";
            this.btnDownarrow.Size = new System.Drawing.Size(55, 34);
            this.btnDownarrow.TabIndex = 13;
            this.btnDownarrow.Text = "↓";
            this.btnDownarrow.UseVisualStyleBackColor = true;
            this.btnDownarrow.Click += new System.EventHandler(this.btnDownarrow_Click);
            // 
            // btnLeftarrow
            // 
            this.btnLeftarrow.Location = new System.Drawing.Point(155, 97);
            this.btnLeftarrow.Name = "btnLeftarrow";
            this.btnLeftarrow.Size = new System.Drawing.Size(55, 34);
            this.btnLeftarrow.TabIndex = 12;
            this.btnLeftarrow.Text = "←";
            this.btnLeftarrow.UseVisualStyleBackColor = true;
            this.btnLeftarrow.Click += new System.EventHandler(this.btnLeftarrow_Click);
            // 
            // btnRightarrow
            // 
            this.btnRightarrow.Location = new System.Drawing.Point(216, 97);
            this.btnRightarrow.Name = "btnRightarrow";
            this.btnRightarrow.Size = new System.Drawing.Size(55, 34);
            this.btnRightarrow.TabIndex = 11;
            this.btnRightarrow.Text = "→";
            this.btnRightarrow.UseVisualStyleBackColor = true;
            this.btnRightarrow.Click += new System.EventHandler(this.btnRightarrow_Click);
            // 
            // btnUparrow
            // 
            this.btnUparrow.Location = new System.Drawing.Point(185, 57);
            this.btnUparrow.Name = "btnUparrow";
            this.btnUparrow.Size = new System.Drawing.Size(55, 34);
            this.btnUparrow.TabIndex = 10;
            this.btnUparrow.Text = "↑";
            this.btnUparrow.UseVisualStyleBackColor = true;
            this.btnUparrow.Click += new System.EventHandler(this.btnUparrow_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(41, 137);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 34);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnYawmi
            // 
            this.btnYawmi.Location = new System.Drawing.Point(11, 97);
            this.btnYawmi.Name = "btnYawmi";
            this.btnYawmi.Size = new System.Drawing.Size(55, 34);
            this.btnYawmi.TabIndex = 8;
            this.btnYawmi.Text = "yaw -";
            this.btnYawmi.UseVisualStyleBackColor = true;
            this.btnYawmi.Click += new System.EventHandler(this.btnYawmi_Click);
            // 
            // btnYawplus
            // 
            this.btnYawplus.Location = new System.Drawing.Point(72, 97);
            this.btnYawplus.Name = "btnYawplus";
            this.btnYawplus.Size = new System.Drawing.Size(55, 34);
            this.btnYawplus.TabIndex = 7;
            this.btnYawplus.Text = "yaw +";
            this.btnYawplus.UseVisualStyleBackColor = true;
            this.btnYawplus.Click += new System.EventHandler(this.btnYawplus_Click);
            // 
            // brnUp
            // 
            this.brnUp.Location = new System.Drawing.Point(41, 57);
            this.brnUp.Name = "brnUp";
            this.brnUp.Size = new System.Drawing.Size(55, 34);
            this.brnUp.TabIndex = 6;
            this.brnUp.Text = "up";
            this.brnUp.UseVisualStyleBackColor = true;
            this.brnUp.Click += new System.EventHandler(this.brnUp_Click);
            // 
            // btnLand
            // 
            this.btnLand.Location = new System.Drawing.Point(156, 16);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(115, 34);
            this.btnLand.TabIndex = 5;
            this.btnLand.Text = "착륙";
            this.btnLand.UseVisualStyleBackColor = true;
            // 
            // btnTakeoff
            // 
            this.btnTakeoff.Location = new System.Drawing.Point(13, 16);
            this.btnTakeoff.Name = "btnTakeoff";
            this.btnTakeoff.Size = new System.Drawing.Size(115, 34);
            this.btnTakeoff.TabIndex = 4;
            this.btnTakeoff.Text = "이륙";
            this.btnTakeoff.UseVisualStyleBackColor = true;
            // 
            // lbComm
            // 
            this.lbComm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComm.FormattingEnabled = true;
            this.lbComm.IntegralHeight = false;
            this.lbComm.ItemHeight = 15;
            this.lbComm.Location = new System.Drawing.Point(1, 222);
            this.lbComm.Name = "lbComm";
            this.lbComm.Size = new System.Drawing.Size(283, 171);
            this.lbComm.TabIndex = 22;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(665, 5);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(71, 19);
            this.cbStatus.TabIndex = 29;
            this.cbStatus.Text = "pState";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.IntegralHeight = false;
            this.lbStatus.ItemHeight = 15;
            this.lbStatus.Location = new System.Drawing.Point(225, 30);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(577, 393);
            this.lbStatus.TabIndex = 31;
            // 
            // lbCode
            // 
            this.lbCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCode.FormattingEnabled = true;
            this.lbCode.IntegralHeight = false;
            this.lbCode.ItemHeight = 15;
            this.lbCode.Location = new System.Drawing.Point(105, 30);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(120, 393);
            this.lbCode.TabIndex = 33;
            // 
            // tbEdit
            // 
            this.tbEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbEdit.Location = new System.Drawing.Point(0, 30);
            this.tbEdit.Multiline = true;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(105, 393);
            this.tbEdit.TabIndex = 32;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 30);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.flightPlanToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // flightPlanToolStripMenuItem
            // 
            this.flightPlanToolStripMenuItem.Name = "flightPlanToolStripMenuItem";
            this.flightPlanToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.flightPlanToolStripMenuItem.Text = "Flight Plan";
            this.flightPlanToolStripMenuItem.Click += new System.EventHandler(this.flightPlanToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.stepRunToolStripMenuItem,
            this.autoRunToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // stepRunToolStripMenuItem
            // 
            this.stepRunToolStripMenuItem.Name = "stepRunToolStripMenuItem";
            this.stepRunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.stepRunToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.stepRunToolStripMenuItem.Text = "Step Run";
            this.stepRunToolStripMenuItem.Click += new System.EventHandler(this.stepRunToolStripMenuItem_Click);
            // 
            // autoRunToolStripMenuItem
            // 
            this.autoRunToolStripMenuItem.Name = "autoRunToolStripMenuItem";
            this.autoRunToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.autoRunToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.autoRunToolStripMenuItem.Text = "Auto Run";
            this.autoRunToolStripMenuItem.Click += new System.EventHandler(this.autoRunToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.aboutToolStripMenuItem.Text = "About Dcp";
            // 
            // FrmDCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "FrmDCP";
            this.Text = "TelloDCP 3.0";
            this.Load += new System.EventHandler(this.FrmDCP_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDCP_FormClosing);


        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.Button btnCam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPtfly;
        private System.Windows.Forms.Button btnDownarrow;
        private System.Windows.Forms.Button btnLeftarrow;
        private System.Windows.Forms.Button btnRightarrow;
        private System.Windows.Forms.Button btnUparrow;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnYawmi;
        private System.Windows.Forms.Button btnYawplus;
        private System.Windows.Forms.Button brnUp;
        private System.Windows.Forms.Button btnLand;
        private System.Windows.Forms.Button btnTakeoff;
        private System.Windows.Forms.ListBox lbComm;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.ListBox lbCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stepRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBatt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLog;
        private System.Windows.Forms.CheckBox cbStatus;
    }
}

