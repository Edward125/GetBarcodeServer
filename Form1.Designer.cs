namespace GetBarcodeServer
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
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.chkUseIP4 = new System.Windows.Forms.CheckBox();
            this.chkUseIP3 = new System.Windows.Forms.CheckBox();
            this.chkUseIP2 = new System.Windows.Forms.CheckBox();
            this.chkUseIP1 = new System.Windows.Forms.CheckBox();
            this.chkUseWeb = new System.Windows.Forms.CheckBox();
            this.txtPort4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIP4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPort3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIP3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPort2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWebService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT SN:";
            // 
            // txtSN
            // 
            this.txtSN.Enabled = false;
            this.txtSN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.Location = new System.Drawing.Point(123, 25);
            this.txtSN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(356, 32);
            this.txtSN.TabIndex = 1;
            this.txtSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSN_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.chkUseIP4);
            this.groupBox1.Controls.Add(this.chkUseIP3);
            this.groupBox1.Controls.Add(this.chkUseIP2);
            this.groupBox1.Controls.Add(this.chkUseIP1);
            this.groupBox1.Controls.Add(this.chkUseWeb);
            this.groupBox1.Controls.Add(this.txtPort4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIP4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPort3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIP3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPort2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIP2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPort1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIP1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWebService);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstbox);
            this.groupBox1.Controls.Add(this.txtSN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(488, 562);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(253, 508);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(204, 48);
            this.btnStop.TabIndex = 27;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(31, 508);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(181, 48);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chkUseIP4
            // 
            this.chkUseIP4.AutoSize = true;
            this.chkUseIP4.Location = new System.Drawing.Point(392, 474);
            this.chkUseIP4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUseIP4.Name = "chkUseIP4";
            this.chkUseIP4.Size = new System.Drawing.Size(83, 26);
            this.chkUseIP4.TabIndex = 25;
            this.chkUseIP4.Text = "Client4";
            this.chkUseIP4.UseVisualStyleBackColor = true;
            this.chkUseIP4.CheckedChanged += new System.EventHandler(this.chkUseIP4_CheckedChanged);
            // 
            // chkUseIP3
            // 
            this.chkUseIP3.AutoSize = true;
            this.chkUseIP3.Location = new System.Drawing.Point(303, 474);
            this.chkUseIP3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUseIP3.Name = "chkUseIP3";
            this.chkUseIP3.Size = new System.Drawing.Size(83, 26);
            this.chkUseIP3.TabIndex = 24;
            this.chkUseIP3.Text = "Client3";
            this.chkUseIP3.UseVisualStyleBackColor = true;
            this.chkUseIP3.CheckedChanged += new System.EventHandler(this.chkUseIP3_CheckedChanged);
            // 
            // chkUseIP2
            // 
            this.chkUseIP2.AutoSize = true;
            this.chkUseIP2.Location = new System.Drawing.Point(213, 474);
            this.chkUseIP2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUseIP2.Name = "chkUseIP2";
            this.chkUseIP2.Size = new System.Drawing.Size(83, 26);
            this.chkUseIP2.TabIndex = 23;
            this.chkUseIP2.Text = "Client2";
            this.chkUseIP2.UseVisualStyleBackColor = true;
            this.chkUseIP2.CheckedChanged += new System.EventHandler(this.chkUseIP2_CheckedChanged);
            // 
            // chkUseIP1
            // 
            this.chkUseIP1.AutoSize = true;
            this.chkUseIP1.Location = new System.Drawing.Point(124, 474);
            this.chkUseIP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUseIP1.Name = "chkUseIP1";
            this.chkUseIP1.Size = new System.Drawing.Size(83, 26);
            this.chkUseIP1.TabIndex = 22;
            this.chkUseIP1.Text = "Client1";
            this.chkUseIP1.UseVisualStyleBackColor = true;
            this.chkUseIP1.CheckedChanged += new System.EventHandler(this.chkUseIP1_CheckedChanged);
            // 
            // chkUseWeb
            // 
            this.chkUseWeb.AutoSize = true;
            this.chkUseWeb.Location = new System.Drawing.Point(25, 474);
            this.chkUseWeb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUseWeb.Name = "chkUseWeb";
            this.chkUseWeb.Size = new System.Drawing.Size(93, 26);
            this.chkUseWeb.TabIndex = 21;
            this.chkUseWeb.Text = "UseWeb";
            this.chkUseWeb.UseVisualStyleBackColor = true;
            this.chkUseWeb.CheckedChanged += new System.EventHandler(this.chkUseWeb_CheckedChanged);
            // 
            // txtPort4
            // 
            this.txtPort4.Location = new System.Drawing.Point(347, 438);
            this.txtPort4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort4.Name = "txtPort4";
            this.txtPort4.Size = new System.Drawing.Size(109, 29);
            this.txtPort4.TabIndex = 20;
            this.txtPort4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort4.TextChanged += new System.EventHandler(this.txtPort4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Port:";
            // 
            // txtIP4
            // 
            this.txtIP4.Location = new System.Drawing.Point(85, 438);
            this.txtIP4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP4.Name = "txtIP4";
            this.txtIP4.Size = new System.Drawing.Size(183, 29);
            this.txtIP4.TabIndex = 18;
            this.txtIP4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP4.TextChanged += new System.EventHandler(this.txtIP4_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 441);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "Client4:";
            // 
            // txtPort3
            // 
            this.txtPort3.Location = new System.Drawing.Point(347, 404);
            this.txtPort3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort3.Name = "txtPort3";
            this.txtPort3.Size = new System.Drawing.Size(109, 29);
            this.txtPort3.TabIndex = 16;
            this.txtPort3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort3.TextChanged += new System.EventHandler(this.txtPort3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 408);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Port:";
            // 
            // txtIP3
            // 
            this.txtIP3.Location = new System.Drawing.Point(85, 404);
            this.txtIP3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP3.Name = "txtIP3";
            this.txtIP3.Size = new System.Drawing.Size(183, 29);
            this.txtIP3.TabIndex = 14;
            this.txtIP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP3.TextChanged += new System.EventHandler(this.txtIP3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 408);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "Client3:";
            // 
            // txtPort2
            // 
            this.txtPort2.Location = new System.Drawing.Point(347, 369);
            this.txtPort2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort2.Name = "txtPort2";
            this.txtPort2.Size = new System.Drawing.Size(109, 29);
            this.txtPort2.TabIndex = 12;
            this.txtPort2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort2.TextChanged += new System.EventHandler(this.txtPort2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Port:";
            // 
            // txtIP2
            // 
            this.txtIP2.Location = new System.Drawing.Point(85, 369);
            this.txtIP2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.Size = new System.Drawing.Size(183, 29);
            this.txtIP2.TabIndex = 10;
            this.txtIP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP2.TextChanged += new System.EventHandler(this.txtIP2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Client2:";
            // 
            // txtPort1
            // 
            this.txtPort1.Location = new System.Drawing.Point(347, 334);
            this.txtPort1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort1.Name = "txtPort1";
            this.txtPort1.Size = new System.Drawing.Size(109, 29);
            this.txtPort1.TabIndex = 8;
            this.txtPort1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPort1.TextChanged += new System.EventHandler(this.txtPort1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port:";
            // 
            // txtIP1
            // 
            this.txtIP1.Location = new System.Drawing.Point(85, 334);
            this.txtIP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIP1.Name = "txtIP1";
            this.txtIP1.Size = new System.Drawing.Size(183, 29);
            this.txtIP1.TabIndex = 6;
            this.txtIP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP1.TextChanged += new System.EventHandler(this.txtIP1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client1:";
            // 
            // txtWebService
            // 
            this.txtWebService.Location = new System.Drawing.Point(123, 298);
            this.txtWebService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWebService.Name = "txtWebService";
            this.txtWebService.Size = new System.Drawing.Size(356, 29);
            this.txtWebService.TabIndex = 4;
            this.txtWebService.TextChanged += new System.EventHandler(this.txtWebService_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "WebService:";
            // 
            // lstbox
            // 
            this.lstbox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 21;
            this.lstbox.Location = new System.Drawing.Point(8, 66);
            this.lstbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(471, 214);
            this.lstbox.TabIndex = 2;
            this.lstbox.SelectedIndexChanged += new System.EventHandler(this.lstbox_SelectedIndexChanged);
            this.lstbox.DoubleClick += new System.EventHandler(this.lstbox_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 572);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIP4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPort3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIP3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPort2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPort1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIP1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWebService;
        private System.Windows.Forms.CheckBox chkUseIP4;
        private System.Windows.Forms.CheckBox chkUseIP3;
        private System.Windows.Forms.CheckBox chkUseIP2;
        private System.Windows.Forms.CheckBox chkUseIP1;
        private System.Windows.Forms.CheckBox chkUseWeb;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
    }
}

