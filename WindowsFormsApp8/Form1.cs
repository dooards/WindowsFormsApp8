using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string dataIN;
        string[] Rxline;
        bool CITYTEST = false;
        bool SENSTEST = false;
        bool CONNECT = false;
        
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tBoxDATAOUT.Visible = false;
            lstBoxDATAIN.Visible = false;
            btnSENDDATA.Visible = false;
            btnCLEARDATAIN.Visible = false;
            button1.Enabled = false;


            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);


            try
            {
                string[] files = Directory.GetFiles(".", "*.csv", SearchOption.AllDirectories);
                //lstBoxID.Items.AddRange(files);
                tBoxLIST.Text = files[0].Substring(2);
                lblSTATUSCOM.Text = "ツールを接続して下さい。";
                lblSTATUSCOM.Update();
            }
            catch(Exception)
            {
                lblSTATUSCOM.Text = "ID一覧ファイルがありません。";
                lblSTATUSCOM.Update();
            }
        }

        private void btnOPEN_Click(object sender, EventArgs e)
        {
            if (CONNECT == false)
            {
                try
                {
                    progressBar1.Value = 50;

                    serialPort1.PortName = cBoxCOMPORT.Text;
                    serialPort1.BaudRate = 115200; // Convert.ToInt32(cBoxBAUDRATE.Text);
                    serialPort1.DataBits = 8; // Convert.ToInt32(cBoxDATABITS.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), "One");
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), "None");
                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                    System.Threading.Thread.Sleep(1000);

                    serialPort1.Open();
                    progressBar1.Value = 100;

                    lblSTATUSCOM.Text = "                                                      ";
                    lblSTATUSCOM.Update();
                    lblSTATUSCOM.Text = "接続済み 磁石を近づけて起動して下さい。";
                    lblSTATUSCOM.Update();

                    btnOPEN.Text = "切断";
                    CONNECT = true;

                }

                catch (Exception)
                {
                    lblSTATUSCOM.Text = "ツールがありません。";
                    lblSTATUSCOM.Update();
                    progressBar1.Value = 0;
                }
            }
            else if(CONNECT ==true)
            {
                if (serialPort1.IsOpen)
                {
                    progressBar1.Value = 50;
                    System.Threading.Thread.Sleep(1000);
                    
                    serialPort1.Close();
                    progressBar1.Value = 0;
                    lblSTATUSCOM.Text = "切断済み";
                    lblSTATUSCOM.Update();

                }

                btnOPEN.Text = "接続";
                CONNECT = false;
            }

        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                progressBar1.Value = 50;
                System.Threading.Thread.Sleep(750);

                lblSTATUSCOM.Text = "                                                      ";
                lblSTATUSCOM.Update();
                lblSTATUSCOM.Text = "切断済み";
                lblSTATUSCOM.Update();
                serialPort1.Close();

            }

            progressBar1.Value = 0;
            System.Threading.Thread.Sleep(500);
            Application.Exit();

        }

        private void btnSENDDATA_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDATAOUT.Text+ Environment.NewLine ;
                serialPort1.WriteLine(dataOUT);
                tBoxDATAOUT.Clear();
                //serialPort1.Write(dataOUT);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();

            Rxline = dataIN.Split('\n');
           
            this.Invoke(new EventHandler(ShowData)); //Begin

        }

        private void ShowData(object sender, EventArgs e)
        {
            //tBoxDATAIN.Text = dataIN;
            foreach (string s in Rxline)
            {
                lstBoxDATAIN.Items.Add(s);
                lstBoxDATAIN.SelectedIndex = lstBoxDATAIN.Items.Count - 1;


                if (s == "LTE_power on")
                {
                    startUPERROR(); 
                }

                if (s.Contains("6666"))
                {
                    startUPERROR();
                }

                if (s.Contains("START TEST"))
                {
                    progressBar1.Value = 25;
                    lblSTATUSCOM.Text = "                                                      ";
                    lblSTATUSCOM.Update();
                    lblSTATUSCOM.Text = "起動中.";
                    lblSTATUSCOM.Update();
                }

                if (s.Contains("WAKEUP"))
                {
                    progressBar1.Value = 70;
                    lblSTATUSCOM.Text = "起動中..";
                    lblSTATUSCOM.Update();
                }

                if (s.Contains("NUM="))
                {
                    int len = s.Length;
                    tBoxNum.Text = s.Substring(len-11);
                    progressBar1.Value = 100;
                    lblSTATUSCOM.Text = "起動完了　書込みできます。";
                    lblSTATUSCOM.Update();
                }


                if (s.StartsWith("CITYCODE=" + tBoxCITYID.Text))
                {
                    //lstBoxDATAIN.Items.Add("CITY OK");
                    CITYTEST = true;
                }

                if (s.StartsWith("SENSORNO=" + tBoxSENSID.Text))
                {
                    //lstBoxDATAIN.Items.Add("SENS OK");
                    SENSTEST = true;

                    if (CITYTEST | SENSTEST)
                    {
                        //lblSTATUSCOM.Text = "FIN";
                        lstBoxDATAIN.Items.Add("DONE");
                        CITYTEST = false;
                        SENSTEST = false;

                    }


                }

                
            }

        }

        private void startUPERROR()
        {
            lblSTATUSCOM.Text = "MAGNET";
            serialPort1.Close();
            progressBar1.Value = 0;
            btnOPEN.Enabled = true;
            btnCLOSE.Enabled = false;
        }

        private void btnCLEARDATAIN_Click(object sender, EventArgs e)
        {
            lstBoxDATAIN.Items.Clear();
            tBoxNum.Clear();
            tBoxSENSID.Clear();
            tBoxCITYID.Clear();

        }

        private void tBoxNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
     

                StreamReader sr = new StreamReader(tBoxLIST.Text, Encoding.Default);

                string dat;
                while((dat = sr.ReadLine()) != null)
                {
                    string callnum;
                    string[] sbuf = dat.Split(',');
                    callnum = sbuf[0];

                    if(tBoxNum.Text == callnum)
                    {
                        tBoxCITYID.Text = sbuf[1];
                        tBoxSENSID.Text = sbuf[2];

                    }
                    Application.DoEvents();
                }
                sr.Close();

            }
            catch
            {
                return;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                lblSTATUSCOM.Text = "                                                      ";
                lblSTATUSCOM.Update();
                lblSTATUSCOM.Text = "書込み中";
                lblSTATUSCOM.Update();
                progressBar1.Value = 0;
                WRITECITY();
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 33;
                WRITESENS();
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 66;
                CHECKID();
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = 100;
                lblSTATUSCOM.Text = "書込み完了";
                lblSTATUSCOM.Update();
            }

            button1.Enabled = false;

        }

        private void CHECKID()
        {
            string INFO;
            INFO = "!!INFO" + Environment.NewLine;
            serialPort1.WriteLine(INFO);
        }

        private void WRITESENS()
        {
            string SENSORCODE;
            SENSORCODE = "!!SENSORNO=" + tBoxSENSID.Text + Environment.NewLine;
            serialPort1.WriteLine(SENSORCODE);

        }

        private void WRITECITY()
        {
            string CITYCODE;
            CITYCODE = "!!CITYCODE=" + tBoxCITYID.Text + Environment.NewLine;
            serialPort1.WriteLine(CITYCODE);

            
        }

        private void tBoxSENSID_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AK-140観測局番号書込みソフトウェア Version 1.00" + Environment.NewLine + "Copyright WORKSHOP HATSUKARI ULtd.");
        }
    }
}
