
namespace TelloDCP2_0
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEmc = new System.Windows.Forms.Button();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCam = new System.Windows.Forms.Button();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbStatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 472);
            this.panel4.TabIndex = 29;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.IntegralHeight = false;
            this.lbStatus.ItemHeight = 15;
            this.lbStatus.Location = new System.Drawing.Point(-3, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(522, 472);
            this.lbStatus.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbComm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(519, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 472);
            this.panel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnEmc);
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
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 224);
            this.panel3.TabIndex = 23;
            // 
            // btnEmc
            // 
            this.btnEmc.Location = new System.Drawing.Point(154, 177);
            this.btnEmc.Name = "btnEmc";
            this.btnEmc.Size = new System.Drawing.Size(115, 34);
            this.btnEmc.TabIndex = 15;
            this.btnEmc.Text = "비상착륙";
            this.btnEmc.UseVisualStyleBackColor = true;
            // 
            // btnPtfly
            // 
            this.btnPtfly.Location = new System.Drawing.Point(11, 177);
            this.btnPtfly.Name = "btnPtfly";
            this.btnPtfly.Size = new System.Drawing.Size(115, 34);
            this.btnPtfly.TabIndex = 14;
            this.btnPtfly.Text = "패턴비행";
            this.btnPtfly.UseVisualStyleBackColor = true;
            // 
            // btnDownarrow
            // 
            this.btnDownarrow.Location = new System.Drawing.Point(185, 137);
            this.btnDownarrow.Name = "btnDownarrow";
            this.btnDownarrow.Size = new System.Drawing.Size(55, 34);
            this.btnDownarrow.TabIndex = 13;
            this.btnDownarrow.Text = "↓";
            this.btnDownarrow.UseVisualStyleBackColor = true;
            // 
            // btnLeftarrow
            // 
            this.btnLeftarrow.Location = new System.Drawing.Point(155, 97);
            this.btnLeftarrow.Name = "btnLeftarrow";
            this.btnLeftarrow.Size = new System.Drawing.Size(55, 34);
            this.btnLeftarrow.TabIndex = 12;
            this.btnLeftarrow.Text = "←";
            this.btnLeftarrow.UseVisualStyleBackColor = true;
            // 
            // btnRightarrow
            // 
            this.btnRightarrow.Location = new System.Drawing.Point(216, 97);
            this.btnRightarrow.Name = "btnRightarrow";
            this.btnRightarrow.Size = new System.Drawing.Size(55, 34);
            this.btnRightarrow.TabIndex = 11;
            this.btnRightarrow.Text = "→";
            this.btnRightarrow.UseVisualStyleBackColor = true;
            // 
            // btnUparrow
            // 
            this.btnUparrow.Location = new System.Drawing.Point(185, 57);
            this.btnUparrow.Name = "btnUparrow";
            this.btnUparrow.Size = new System.Drawing.Size(55, 34);
            this.btnUparrow.TabIndex = 10;
            this.btnUparrow.Text = "↑";
            this.btnUparrow.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(41, 137);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 34);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnYawmi
            // 
            this.btnYawmi.Location = new System.Drawing.Point(11, 97);
            this.btnYawmi.Name = "btnYawmi";
            this.btnYawmi.Size = new System.Drawing.Size(55, 34);
            this.btnYawmi.TabIndex = 8;
            this.btnYawmi.Text = "yaw -";
            this.btnYawmi.UseVisualStyleBackColor = true;
            // 
            // btnYawplus
            // 
            this.btnYawplus.Location = new System.Drawing.Point(72, 97);
            this.btnYawplus.Name = "btnYawplus";
            this.btnYawplus.Size = new System.Drawing.Size(55, 34);
            this.btnYawplus.TabIndex = 7;
            this.btnYawplus.Text = "yaw +";
            this.btnYawplus.UseVisualStyleBackColor = true;
            // 
            // brnUp
            // 
            this.brnUp.Location = new System.Drawing.Point(41, 57);
            this.brnUp.Name = "brnUp";
            this.brnUp.Size = new System.Drawing.Size(55, 34);
            this.brnUp.TabIndex = 6;
            this.brnUp.Text = "up";
            this.brnUp.UseVisualStyleBackColor = true;
            // 
            // btnLand
            // 
            this.btnLand.Location = new System.Drawing.Point(156, 16);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(115, 34);
            this.btnLand.TabIndex = 5;
            this.btnLand.Text = "착륙";
            this.btnLand.UseVisualStyleBackColor = true;
            this.btnLand.Click += new System.EventHandler(this.btnLand_Click);
            // 
            // btnTakeoff
            // 
            this.btnTakeoff.Location = new System.Drawing.Point(13, 16);
            this.btnTakeoff.Name = "btnTakeoff";
            this.btnTakeoff.Size = new System.Drawing.Size(115, 34);
            this.btnTakeoff.TabIndex = 4;
            this.btnTakeoff.Text = "이륙";
            this.btnTakeoff.UseVisualStyleBackColor = true;
            this.btnTakeoff.Click += new System.EventHandler(this.btnTakeoff_Click);
            // 
            // lbComm
            // 
            this.lbComm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComm.FormattingEnabled = true;
            this.lbComm.IntegralHeight = false;
            this.lbComm.ItemHeight = 15;
            this.lbComm.Location = new System.Drawing.Point(0, 222);
            this.lbComm.Name = "lbComm";
            this.lbComm.Size = new System.Drawing.Size(283, 250);
            this.lbComm.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCam);
            this.panel2.Controls.Add(this.cbCommand);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 30);
            this.panel2.TabIndex = 27;
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(406, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 25);
            this.textBox1.TabIndex = 1;
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
            // FrmDCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 502);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmDCP";
            this.Text = "TelloDCP 2.0";
            this.Load += new System.EventHandler(this.FrmDCP_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEmc;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCam;
    }
}

