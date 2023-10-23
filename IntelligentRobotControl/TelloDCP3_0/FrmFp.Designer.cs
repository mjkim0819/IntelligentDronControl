
namespace TelloDCP3_0
{
    partial class FrmFp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbGrid = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbAlt = new System.Windows.Forms.TrackBar();
            this.btnCoding = new System.Windows.Forms.Button();
            this.pbRoom = new System.Windows.Forms.PictureBox();
            this.pbDrone = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSimulate);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.tbAlt);
            this.panel1.Controls.Add(this.btnCoding);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(271, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 453);
            this.panel1.TabIndex = 9;
            // 
            // tbGrid
            // 
            this.tbGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGrid.Location = new System.Drawing.Point(36, 54);
            this.tbGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbGrid.Maximum = 100;
            this.tbGrid.Minimum = 1;
            this.tbGrid.Name = "tbGrid";
            this.tbGrid.Size = new System.Drawing.Size(119, 56);
            this.tbGrid.TabIndex = 3;
            this.tbGrid.Value = 50;
            this.tbGrid.Scroll += new System.EventHandler(this.tbGrid_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "180cm \r\nA\r\nL\r\nT \r\n0cm";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(53, 151);
            this.btnSimulate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(86, 29);
            this.btnSimulate.TabIndex = 1;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(53, 115);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 29);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbAlt
            // 
            this.tbAlt.Location = new System.Drawing.Point(41, 276);
            this.tbAlt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAlt.Maximum = 180;
            this.tbAlt.Name = "tbAlt";
            this.tbAlt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbAlt.Size = new System.Drawing.Size(56, 130);
            this.tbAlt.TabIndex = 4;
            this.tbAlt.Tag = "";
            // 
            // btnCoding
            // 
            this.btnCoding.Location = new System.Drawing.Point(53, 187);
            this.btnCoding.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCoding.Name = "btnCoding";
            this.btnCoding.Size = new System.Drawing.Size(86, 29);
            this.btnCoding.TabIndex = 2;
            this.btnCoding.Text = "Coding";
            this.btnCoding.UseVisualStyleBackColor = true;
            this.btnCoding.Click += new System.EventHandler(this.btnCoding_Click);
            // 
            // pbRoom
            // 
            this.pbRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRoom.BackgroundImage")));
            this.pbRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbRoom.Location = new System.Drawing.Point(0, 0);
            this.pbRoom.Name = "pbRoom";
            this.pbRoom.Size = new System.Drawing.Size(270, 453);
            this.pbRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRoom.TabIndex = 10;
            this.pbRoom.TabStop = false;
            this.pbRoom.SizeChanged += new System.EventHandler(this.pbRoom_SizeChanged);
            this.pbRoom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbRoom_MouseClick);
            // 
            // pbDrone
            // 
            this.pbDrone.BackColor = System.Drawing.Color.Transparent;
            this.pbDrone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDrone.Image = ((System.Drawing.Image)(resources.GetObject("pbDrone.Image")));
            this.pbDrone.Location = new System.Drawing.Point(40, 66);
            this.pbDrone.Margin = new System.Windows.Forms.Padding(2);
            this.pbDrone.Name = "pbDrone";
            this.pbDrone.Size = new System.Drawing.Size(48, 44);
            this.pbDrone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDrone.TabIndex = 8;
            this.pbDrone.TabStop = false;
            // 
            // FrmFp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 453);
            this.Controls.Add(this.pbDrone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbRoom);
            this.Name = "FrmFp";
            this.Text = "Flight Plan";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmFp_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar tbGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TrackBar tbAlt;
        private System.Windows.Forms.Button btnCoding;
        private System.Windows.Forms.PictureBox pbRoom;
        private System.Windows.Forms.PictureBox pbDrone;
    }
}