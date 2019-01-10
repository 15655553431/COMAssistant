namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbxRecvData = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.btnCleanData1 = new System.Windows.Forms.PictureBox();
            this.btnSend1 = new System.Windows.Forms.PictureBox();
            this.tbxSendData = new System.Windows.Forms.TextBox();
            this.lblgo = new System.Windows.Forms.Label();
            this.bgbox = new System.Windows.Forms.PictureBox();
            this.btnCom = new System.Windows.Forms.PictureBox();
            this.btnOpenCom1 = new System.Windows.Forms.PictureBox();
            this.cbxCOMPort = new System.Windows.Forms.ComboBox();
            this.cbxBaudRate = new System.Windows.Forms.ComboBox();
            this.cbxStopBits = new System.Windows.Forms.ComboBox();
            this.cbxParity = new System.Windows.Forms.ComboBox();
            this.cbxDataBits = new System.Windows.Forms.ComboBox();
            this.rbnChar = new System.Windows.Forms.RadioButton();
            this.rbnHex = new System.Windows.Forms.RadioButton();
            this.gbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCleanData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenCom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxRecvData
            // 
            this.tbxRecvData.BackColor = System.Drawing.SystemColors.Info;
            this.tbxRecvData.CausesValidation = false;
            this.tbxRecvData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxRecvData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxRecvData.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxRecvData.Location = new System.Drawing.Point(76, 47);
            this.tbxRecvData.Multiline = true;
            this.tbxRecvData.Name = "tbxRecvData";
            this.tbxRecvData.ReadOnly = true;
            this.tbxRecvData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRecvData.Size = new System.Drawing.Size(250, 126);
            this.tbxRecvData.TabIndex = 0;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("迷你简卡通", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl7.ForeColor = System.Drawing.Color.Red;
            this.lbl7.Location = new System.Drawing.Point(256, 378);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(136, 24);
            this.lbl7.TabIndex = 5;
            this.lbl7.Text = "扫描串口去！";
            // 
            // pBox
            // 
            this.pBox.Image = global::zhy.Properties.Resources.y;
            this.pBox.Location = new System.Drawing.Point(247, 513);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(30, 30);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 4;
            this.pBox.TabStop = false;
            // 
            // btnCleanData1
            // 
            this.btnCleanData1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCleanData1.Image = global::zhy.Properties.Resources.qc1;
            this.btnCleanData1.Location = new System.Drawing.Point(83, 245);
            this.btnCleanData1.Name = "btnCleanData1";
            this.btnCleanData1.Size = new System.Drawing.Size(85, 32);
            this.btnCleanData1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCleanData1.TabIndex = 3;
            this.btnCleanData1.TabStop = false;
            this.btnCleanData1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCleanData1_MouseDown);
            this.btnCleanData1.MouseEnter += new System.EventHandler(this.btnCleanData1_MouseEnter);
            this.btnCleanData1.MouseLeave += new System.EventHandler(this.btnCleanData1_MouseLeave);
            this.btnCleanData1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCleanData1_MouseUp);
            // 
            // btnSend1
            // 
            this.btnSend1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend1.Image = global::zhy.Properties.Resources.fs1;
            this.btnSend1.Location = new System.Drawing.Point(33, 398);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(85, 32);
            this.btnSend1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSend1.TabIndex = 1;
            this.btnSend1.TabStop = false;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            this.btnSend1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseDown);
            this.btnSend1.MouseEnter += new System.EventHandler(this.btnSend1_MouseEnter);
            this.btnSend1.MouseLeave += new System.EventHandler(this.btnSend1_MouseLeave);
            this.btnSend1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseUp);
            // 
            // tbxSendData
            // 
            this.tbxSendData.BackColor = System.Drawing.SystemColors.Info;
            this.tbxSendData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSendData.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSendData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxSendData.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxSendData.Location = new System.Drawing.Point(31, 315);
            this.tbxSendData.Multiline = true;
            this.tbxSendData.Name = "tbxSendData";
            this.tbxSendData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxSendData.Size = new System.Drawing.Size(206, 43);
            this.tbxSendData.TabIndex = 2;
            // 
            // lblgo
            // 
            this.lblgo.AutoSize = true;
            this.lblgo.Font = new System.Drawing.Font("迷你简卡通", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblgo.Location = new System.Drawing.Point(124, 425);
            this.lblgo.Name = "lblgo";
            this.lblgo.Size = new System.Drawing.Size(229, 17);
            this.lblgo.TabIndex = 5;
            this.lblgo.Text = "程序已准备就绪，欢迎使用！";
            // 
            // bgbox
            // 
            this.bgbox.Image = global::zhy.Properties.Resources.bg;
            this.bgbox.Location = new System.Drawing.Point(-1, -2);
            this.bgbox.Name = "bgbox";
            this.bgbox.Size = new System.Drawing.Size(407, 668);
            this.bgbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgbox.TabIndex = 6;
            this.bgbox.TabStop = false;
            // 
            // btnCom
            // 
            this.btnCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCom.Image = global::zhy.Properties.Resources.sm1;
            this.btnCom.Location = new System.Drawing.Point(179, 577);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(92, 42);
            this.btnCom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCom.TabIndex = 3;
            this.btnCom.TabStop = false;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click_1);
            this.btnCom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCom_MouseDown);
            this.btnCom.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btnCom.MouseLeave += new System.EventHandler(this.btnCom_MouseLeave);
            this.btnCom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCom_MouseUp);
            // 
            // btnOpenCom1
            // 
            this.btnOpenCom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCom1.Image = global::zhy.Properties.Resources._1;
            this.btnOpenCom1.Location = new System.Drawing.Point(247, 621);
            this.btnOpenCom1.Name = "btnOpenCom1";
            this.btnOpenCom1.Size = new System.Drawing.Size(40, 40);
            this.btnOpenCom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenCom1.TabIndex = 13;
            this.btnOpenCom1.TabStop = false;
            this.btnOpenCom1.Click += new System.EventHandler(this.btnOpenCom1_Click);
            this.btnOpenCom1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnOpenCom1_MouseDown);
            this.btnOpenCom1.MouseEnter += new System.EventHandler(this.btnOpenCom1_MouseEnter);
            this.btnOpenCom1.MouseLeave += new System.EventHandler(this.btnOpenCom1_MouseLeave);
            // 
            // cbxCOMPort
            // 
            this.cbxCOMPort.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxCOMPort.Font = new System.Drawing.Font("迷你简卡通", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCOMPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxCOMPort.FormattingEnabled = true;
            this.cbxCOMPort.Location = new System.Drawing.Point(169, 490);
            this.cbxCOMPort.Name = "cbxCOMPort";
            this.cbxCOMPort.Size = new System.Drawing.Size(68, 22);
            this.cbxCOMPort.TabIndex = 5;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxBaudRate.Font = new System.Drawing.Font("迷你简卡通", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxBaudRate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxBaudRate.FormattingEnabled = true;
            this.cbxBaudRate.Location = new System.Drawing.Point(169, 510);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(68, 22);
            this.cbxBaudRate.TabIndex = 6;
            // 
            // cbxStopBits
            // 
            this.cbxStopBits.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxStopBits.Font = new System.Drawing.Font("迷你简卡通", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxStopBits.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxStopBits.FormattingEnabled = true;
            this.cbxStopBits.Location = new System.Drawing.Point(169, 529);
            this.cbxStopBits.Name = "cbxStopBits";
            this.cbxStopBits.Size = new System.Drawing.Size(68, 22);
            this.cbxStopBits.TabIndex = 7;
            // 
            // cbxParity
            // 
            this.cbxParity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxParity.Font = new System.Drawing.Font("迷你简卡通", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxParity.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxParity.FormattingEnabled = true;
            this.cbxParity.Location = new System.Drawing.Point(230, 465);
            this.cbxParity.Name = "cbxParity";
            this.cbxParity.Size = new System.Drawing.Size(74, 24);
            this.cbxParity.TabIndex = 8;
            // 
            // cbxDataBits
            // 
            this.cbxDataBits.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbxDataBits.Font = new System.Drawing.Font("迷你简卡通", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxDataBits.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cbxDataBits.FormattingEnabled = true;
            this.cbxDataBits.Location = new System.Drawing.Point(169, 549);
            this.cbxDataBits.Name = "cbxDataBits";
            this.cbxDataBits.Size = new System.Drawing.Size(68, 22);
            this.cbxDataBits.TabIndex = 9;
            // 
            // rbnChar
            // 
            this.rbnChar.AutoSize = true;
            this.rbnChar.Checked = true;
            this.rbnChar.Location = new System.Drawing.Point(290, 505);
            this.rbnChar.Name = "rbnChar";
            this.rbnChar.Size = new System.Drawing.Size(14, 13);
            this.rbnChar.TabIndex = 10;
            this.rbnChar.TabStop = true;
            this.rbnChar.UseVisualStyleBackColor = true;
            // 
            // rbnHex
            // 
            this.rbnHex.AutoSize = true;
            this.rbnHex.Location = new System.Drawing.Point(290, 537);
            this.rbnHex.Name = "rbnHex";
            this.rbnHex.Size = new System.Drawing.Size(14, 13);
            this.rbnHex.TabIndex = 11;
            this.rbnHex.UseVisualStyleBackColor = true;
            // 
            // gbox
            // 
            this.gbox.Image = global::zhy.Properties.Resources.b1;
            this.gbox.Location = new System.Drawing.Point(244, 222);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(174, 133);
            this.gbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gbox.TabIndex = 14;
            this.gbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::zhy.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(404, 662);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.btnCleanData1);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.tbxRecvData);
            this.Controls.Add(this.rbnHex);
            this.Controls.Add(this.btnOpenCom1);
            this.Controls.Add(this.tbxSendData);
            this.Controls.Add(this.rbnChar);
            this.Controls.Add(this.btnSend1);
            this.Controls.Add(this.lblgo);
            this.Controls.Add(this.cbxDataBits);
            this.Controls.Add(this.btnCom);
            this.Controls.Add(this.cbxStopBits);
            this.Controls.Add(this.cbxParity);
            this.Controls.Add(this.cbxBaudRate);
            this.Controls.Add(this.cbxCOMPort);
            this.Controls.Add(this.bgbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = " 串口助手";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCleanData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenCom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxRecvData;
        private System.Windows.Forms.TextBox tbxSendData;
        private System.Windows.Forms.Label lblgo;
        private System.Windows.Forms.PictureBox btnCleanData1;
        private System.Windows.Forms.PictureBox btnSend1;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.PictureBox bgbox;
        public System.Windows.Forms.PictureBox btnCom;
        private System.Windows.Forms.PictureBox btnOpenCom1;
        private System.Windows.Forms.ComboBox cbxCOMPort;
        private System.Windows.Forms.ComboBox cbxBaudRate;
        private System.Windows.Forms.ComboBox cbxStopBits;
        private System.Windows.Forms.ComboBox cbxParity;
        private System.Windows.Forms.ComboBox cbxDataBits;
        private System.Windows.Forms.RadioButton rbnChar;
        private System.Windows.Forms.RadioButton rbnHex;
        private System.Windows.Forms.PictureBox gbox;
    }
}

