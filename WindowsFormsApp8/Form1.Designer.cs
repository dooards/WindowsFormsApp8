namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.btnOPEN = new System.Windows.Forms.Button();
            this.btnSENDDATA = new System.Windows.Forms.Button();
            this.tBoxDATAOUT = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnCLEARDATAIN = new System.Windows.Forms.Button();
            this.lstBoxDATAIN = new System.Windows.Forms.ListBox();
            this.lblSTATUSCOM = new System.Windows.Forms.Label();
            this.tBoxNum = new System.Windows.Forms.TextBox();
            this.tBoxCITYID = new System.Windows.Forms.TextBox();
            this.tBoxSENSID = new System.Windows.Forms.TextBox();
            this.tBoxLIST = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxPARITYBITS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cBoxSTOPBITS);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cBoxDATABITS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBoxBAUDRATE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT CONTROL";
            // 
            // cBoxPARITYBITS
            // 
            this.cBoxPARITYBITS.FormattingEnabled = true;
            this.cBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxPARITYBITS.Location = new System.Drawing.Point(90, 132);
            this.cBoxPARITYBITS.Name = "cBoxPARITYBITS";
            this.cBoxPARITYBITS.Size = new System.Drawing.Size(120, 20);
            this.cBoxPARITYBITS.TabIndex = 9;
            this.cBoxPARITYBITS.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "PARITY BITS";
            // 
            // cBoxSTOPBITS
            // 
            this.cBoxSTOPBITS.FormattingEnabled = true;
            this.cBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxSTOPBITS.Location = new System.Drawing.Point(90, 106);
            this.cBoxSTOPBITS.Name = "cBoxSTOPBITS";
            this.cBoxSTOPBITS.Size = new System.Drawing.Size(120, 20);
            this.cBoxSTOPBITS.TabIndex = 7;
            this.cBoxSTOPBITS.Text = "One";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "STOP BITS";
            // 
            // cBoxDATABITS
            // 
            this.cBoxDATABITS.FormattingEnabled = true;
            this.cBoxDATABITS.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cBoxDATABITS.Location = new System.Drawing.Point(90, 80);
            this.cBoxDATABITS.Name = "cBoxDATABITS";
            this.cBoxDATABITS.Size = new System.Drawing.Size(120, 20);
            this.cBoxDATABITS.TabIndex = 5;
            this.cBoxDATABITS.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "DATA BITS";
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(90, 54);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(120, 20);
            this.cBoxBAUDRATE.TabIndex = 3;
            this.cBoxBAUDRATE.Text = "115200";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(90, 28);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(120, 20);
            this.cBoxCOMPORT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnCLOSE);
            this.groupBox2.Controls.Add(this.btnOPEN);
            this.groupBox2.Location = new System.Drawing.Point(27, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(126, 25);
            this.progressBar1.TabIndex = 1;
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Location = new System.Drawing.Point(82, 12);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(60, 25);
            this.btnCLOSE.TabIndex = 0;
            this.btnCLOSE.Text = "CLOSE";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // btnOPEN
            // 
            this.btnOPEN.Location = new System.Drawing.Point(16, 12);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(60, 25);
            this.btnOPEN.TabIndex = 0;
            this.btnOPEN.Text = "OPEN";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // btnSENDDATA
            // 
            this.btnSENDDATA.Location = new System.Drawing.Point(483, 34);
            this.btnSENDDATA.Name = "btnSENDDATA";
            this.btnSENDDATA.Size = new System.Drawing.Size(70, 19);
            this.btnSENDDATA.TabIndex = 2;
            this.btnSENDDATA.Text = "SEND";
            this.btnSENDDATA.UseVisualStyleBackColor = true;
            this.btnSENDDATA.Click += new System.EventHandler(this.btnSENDDATA_Click);
            // 
            // tBoxDATAOUT
            // 
            this.tBoxDATAOUT.Location = new System.Drawing.Point(264, 34);
            this.tBoxDATAOUT.Name = "tBoxDATAOUT";
            this.tBoxDATAOUT.Size = new System.Drawing.Size(213, 19);
            this.tBoxDATAOUT.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnCLEARDATAIN
            // 
            this.btnCLEARDATAIN.Location = new System.Drawing.Point(483, 151);
            this.btnCLEARDATAIN.Name = "btnCLEARDATAIN";
            this.btnCLEARDATAIN.Size = new System.Drawing.Size(70, 20);
            this.btnCLEARDATAIN.TabIndex = 4;
            this.btnCLEARDATAIN.Text = "CLEAR";
            this.btnCLEARDATAIN.UseVisualStyleBackColor = true;
            this.btnCLEARDATAIN.Click += new System.EventHandler(this.btnCLEARDATAIN_Click);
            // 
            // lstBoxDATAIN
            // 
            this.lstBoxDATAIN.FormattingEnabled = true;
            this.lstBoxDATAIN.ItemHeight = 12;
            this.lstBoxDATAIN.Location = new System.Drawing.Point(264, 59);
            this.lstBoxDATAIN.Name = "lstBoxDATAIN";
            this.lstBoxDATAIN.Size = new System.Drawing.Size(213, 112);
            this.lstBoxDATAIN.TabIndex = 5;
            // 
            // lblSTATUSCOM
            // 
            this.lblSTATUSCOM.AutoSize = true;
            this.lblSTATUSCOM.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSTATUSCOM.Location = new System.Drawing.Point(187, 240);
            this.lblSTATUSCOM.Name = "lblSTATUSCOM";
            this.lblSTATUSCOM.Size = new System.Drawing.Size(30, 13);
            this.lblSTATUSCOM.TabIndex = 6;
            this.lblSTATUSCOM.Text = "OFF";
            // 
            // tBoxNum
            // 
            this.tBoxNum.Location = new System.Drawing.Point(264, 199);
            this.tBoxNum.Name = "tBoxNum";
            this.tBoxNum.Size = new System.Drawing.Size(80, 19);
            this.tBoxNum.TabIndex = 8;
            this.tBoxNum.TextChanged += new System.EventHandler(this.tBoxNum_TextChanged);
            // 
            // tBoxCITYID
            // 
            this.tBoxCITYID.Location = new System.Drawing.Point(350, 199);
            this.tBoxCITYID.Name = "tBoxCITYID";
            this.tBoxCITYID.Size = new System.Drawing.Size(69, 19);
            this.tBoxCITYID.TabIndex = 9;
            // 
            // tBoxSENSID
            // 
            this.tBoxSENSID.Location = new System.Drawing.Point(425, 199);
            this.tBoxSENSID.Name = "tBoxSENSID";
            this.tBoxSENSID.Size = new System.Drawing.Size(52, 19);
            this.tBoxSENSID.TabIndex = 10;
            // 
            // tBoxLIST
            // 
            this.tBoxLIST.Location = new System.Drawing.Point(264, 174);
            this.tBoxLIST.Name = "tBoxLIST";
            this.tBoxLIST.Size = new System.Drawing.Size(213, 19);
            this.tBoxLIST.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "WRITE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxLIST);
            this.Controls.Add(this.tBoxSENSID);
            this.Controls.Add(this.tBoxCITYID);
            this.Controls.Add(this.tBoxNum);
            this.Controls.Add(this.lblSTATUSCOM);
            this.Controls.Add(this.lstBoxDATAIN);
            this.Controls.Add(this.btnCLEARDATAIN);
            this.Controls.Add(this.tBoxDATAOUT);
            this.Controls.Add(this.btnSENDDATA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "COM PORT SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxPARITYBITS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxSTOPBITS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxDATABITS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCLOSE;
        private System.Windows.Forms.Button btnOPEN;
        private System.Windows.Forms.Button btnSENDDATA;
        private System.Windows.Forms.TextBox tBoxDATAOUT;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnCLEARDATAIN;
        private System.Windows.Forms.ListBox lstBoxDATAIN;
        private System.Windows.Forms.Label lblSTATUSCOM;
        private System.Windows.Forms.TextBox tBoxNum;
        private System.Windows.Forms.TextBox tBoxCITYID;
        private System.Windows.Forms.TextBox tBoxSENSID;
        private System.Windows.Forms.TextBox tBoxLIST;
        private System.Windows.Forms.Button button1;
    }
}

