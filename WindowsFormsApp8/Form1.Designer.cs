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
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOPEN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblSTATUSCOM = new System.Windows.Forms.Label();
            this.btnCLOSE = new System.Windows.Forms.Button();
            this.btnSENDDATA = new System.Windows.Forms.Button();
            this.tBoxDATAOUT = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnCLEARDATAIN = new System.Windows.Forms.Button();
            this.lstBoxDATAIN = new System.Windows.Forms.ListBox();
            this.tBoxNum = new System.Windows.Forms.TextBox();
            this.tBoxCITYID = new System.Windows.Forms.TextBox();
            this.tBoxSENSID = new System.Windows.Forms.TextBox();
            this.tBoxLIST = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOPEN);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(7, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "コントロール";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(115, 35);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(97, 27);
            this.cBoxCOMPORT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ツール番号";
            // 
            // btnOPEN
            // 
            this.btnOPEN.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOPEN.Location = new System.Drawing.Point(242, 20);
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(100, 58);
            this.btnOPEN.TabIndex = 0;
            this.btnOPEN.Text = "接続";
            this.btnOPEN.UseVisualStyleBackColor = true;
            this.btnOPEN.Click += new System.EventHandler(this.btnOPEN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.lblSTATUSCOM);
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(7, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // lblSTATUSCOM
            // 
            this.lblSTATUSCOM.AutoSize = true;
            this.lblSTATUSCOM.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSTATUSCOM.Location = new System.Drawing.Point(11, 22);
            this.lblSTATUSCOM.Name = "lblSTATUSCOM";
            this.lblSTATUSCOM.Size = new System.Drawing.Size(40, 16);
            this.lblSTATUSCOM.TabIndex = 6;
            this.lblSTATUSCOM.Text = "OFF";
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCLOSE.Location = new System.Drawing.Point(249, 367);
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(100, 58);
            this.btnCLOSE.TabIndex = 0;
            this.btnCLOSE.Text = "終了";
            this.btnCLOSE.UseVisualStyleBackColor = true;
            this.btnCLOSE.Click += new System.EventHandler(this.btnCLOSE_Click);
            // 
            // btnSENDDATA
            // 
            this.btnSENDDATA.Location = new System.Drawing.Point(509, 327);
            this.btnSENDDATA.Name = "btnSENDDATA";
            this.btnSENDDATA.Size = new System.Drawing.Size(70, 22);
            this.btnSENDDATA.TabIndex = 2;
            this.btnSENDDATA.Text = "SEND";
            this.btnSENDDATA.UseVisualStyleBackColor = true;
            this.btnSENDDATA.Click += new System.EventHandler(this.btnSENDDATA_Click);
            // 
            // tBoxDATAOUT
            // 
            this.tBoxDATAOUT.Location = new System.Drawing.Point(442, 152);
            this.tBoxDATAOUT.Name = "tBoxDATAOUT";
            this.tBoxDATAOUT.Size = new System.Drawing.Size(213, 22);
            this.tBoxDATAOUT.TabIndex = 3;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnCLEARDATAIN
            // 
            this.btnCLEARDATAIN.Location = new System.Drawing.Point(585, 325);
            this.btnCLEARDATAIN.Name = "btnCLEARDATAIN";
            this.btnCLEARDATAIN.Size = new System.Drawing.Size(70, 23);
            this.btnCLEARDATAIN.TabIndex = 4;
            this.btnCLEARDATAIN.Text = "CLEAR";
            this.btnCLEARDATAIN.UseVisualStyleBackColor = true;
            this.btnCLEARDATAIN.Click += new System.EventHandler(this.btnCLEARDATAIN_Click);
            // 
            // lstBoxDATAIN
            // 
            this.lstBoxDATAIN.FormattingEnabled = true;
            this.lstBoxDATAIN.ItemHeight = 14;
            this.lstBoxDATAIN.Location = new System.Drawing.Point(442, 181);
            this.lstBoxDATAIN.Name = "lstBoxDATAIN";
            this.lstBoxDATAIN.Size = new System.Drawing.Size(213, 130);
            this.lstBoxDATAIN.TabIndex = 5;
            // 
            // tBoxNum
            // 
            this.tBoxNum.Location = new System.Drawing.Point(159, 56);
            this.tBoxNum.Name = "tBoxNum";
            this.tBoxNum.Size = new System.Drawing.Size(183, 23);
            this.tBoxNum.TabIndex = 8;
            this.tBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxNum.TextChanged += new System.EventHandler(this.tBoxNum_TextChanged);
            // 
            // tBoxCITYID
            // 
            this.tBoxCITYID.Location = new System.Drawing.Point(159, 89);
            this.tBoxCITYID.Name = "tBoxCITYID";
            this.tBoxCITYID.Size = new System.Drawing.Size(69, 23);
            this.tBoxCITYID.TabIndex = 9;
            // 
            // tBoxSENSID
            // 
            this.tBoxSENSID.Location = new System.Drawing.Point(159, 124);
            this.tBoxSENSID.Name = "tBoxSENSID";
            this.tBoxSENSID.Size = new System.Drawing.Size(69, 23);
            this.tBoxSENSID.TabIndex = 10;
            this.tBoxSENSID.TextChanged += new System.EventHandler(this.tBoxSENSID_TextChanged);
            // 
            // tBoxLIST
            // 
            this.tBoxLIST.Location = new System.Drawing.Point(159, 22);
            this.tBoxLIST.Name = "tBoxLIST";
            this.tBoxLIST.Size = new System.Drawing.Size(183, 23);
            this.tBoxLIST.TabIndex = 11;
            this.tBoxLIST.Text = "123";
            this.tBoxLIST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "書込";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.tBoxSENSID);
            this.groupBox3.Controls.Add(this.tBoxLIST);
            this.groupBox3.Controls.Add(this.tBoxCITYID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tBoxNum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(7, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 163);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "設定ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "水位計番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "市町村コード";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "送信局ID(電話番号)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID一覧ファイル";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "INFO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 434);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCLOSE);
            this.Controls.Add(this.lstBoxDATAIN);
            this.Controls.Add(this.btnCLEARDATAIN);
            this.Controls.Add(this.tBoxDATAOUT);
            this.Controls.Add(this.btnSENDDATA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "AK-140 観測局番号書込みソフトウェア";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

