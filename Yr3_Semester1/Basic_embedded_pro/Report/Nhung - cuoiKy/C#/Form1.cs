using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Threading;

namespace BT_CuoiKy
{
    public partial class iSerial : Form
    {
        
        public iSerial()
        {
            InitializeComponent();
            // set default settings
            
        }


        
        private void btSend_Click(object sender, EventArgs e)
        {
            Regex rReset = new Regex(@"^(reset) [0-9]");
            int iTime = 0;
            string textIn = "";

            if (txtIn.Enabled)
            {
                textIn = txtIn.Text;
                if (rReset.Match(textIn).Success)
                {
                  textIn = "resetOK";
                  iTime = int.Parse(txtIn.Text.Substring(6, 1));
                } 
                switch (textIn)
                {
                    case "help":
                        txtOut.Text += "\r\ngettime - print time \r\n" +
                                        "song - play a song \r\n" +
                                        "0812090 - print #1 student name \r\n" +
                                        "0812076 - print #1 student name \r\n" +
                                        "reset <time> - reset board after <time>\r\n";
                        break;

                    case "gettime":
                        serialPort.Write(txtIn.Text.Length.ToString());
                        serialPort.Write(txtIn.Text);
                        serialPort.Write(DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString());

                        break;

                    case "song":
                        serialPort.Write(txtIn.Text.Length.ToString());
                        serialPort.Write(txtIn.Text);
                        break;

                    case "0812090":
                        serialPort.Write(txtIn.Text.Length.ToString());
                        serialPort.Write(txtIn.Text);
                        break;

                    case "0812076":
                        serialPort.Write(txtIn.Text.Length.ToString());
                        serialPort.Write(txtIn.Text);
                        break;

                    case "resetOK":
                        serialPort.Write(txtIn.Text.Length.ToString());
                        serialPort.Write(txtIn.Text);
                        break;

                    default:
                        txtOut.Text = "Wrong command";
                        break;
                }
            }
        }

        // clear text out
        private void btClear_Click(object sender, EventArgs e)
        {
            txtOut.Text = "";
        }

        private void btOpenPort_Click(object sender, EventArgs e)
        {
                Button bTmp = (Button)sender;
                if (bTmp.Text == "Close port")
                {
                    serialPort.Close();
                    btOpenPort.Text = "Open port";
                    txtIn.Enabled = false;
                    txtOut.Text = "Port closes successfully!";
                }
                else
                {
                    // set settings for serial Port
                    serialPort.BaudRate = int.Parse(cbxBaudRate.Text);
                    serialPort.PortName = cbxComPort.Text;
                    serialPort.DataBits = int.Parse(cbxDataBits.Text);
                    switch (cbxParity.Text)
                    {
                        case "None":
                            serialPort.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort.Parity = Parity.Even;
                            break;
                        case "Mark":
                            serialPort.Parity = Parity.Mark;
                            break;
                        case "Space":
                            serialPort.Parity = Parity.Space;
                            break;
                    }
                    switch (cbxStopBits.Text)
                    {
                        case "None":
                            serialPort.StopBits = StopBits.None;
                            break;
                        case "One":
                            serialPort.StopBits = StopBits.One;
                            break;
                        case "Two":
                            serialPort.StopBits = StopBits.Two;
                            break;
                        case "OnePointFive":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                    }
                    try
                    {
                        serialPort.Open();
                        // disable txtIn
                        txtIn.Enabled = true;
                        // dataReceived handler
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataRecieved);

                        //txtOut.Text += "Port opens successfully! \n";
                        txtOut.Text = "Port opens successfully!";

                        btOpenPort.Text = "Close port";
                    }
                    catch
                    {
                        //txtOut.Text += "Port can not be opened!!!!";
                        txtOut.Text = "Port can not be opened!!!!";
                    }
                }
        }

        // Receive datas from board
        delegate void UpdateTextFieldDelegate(String newText);
        void serialPort_DataRecieved(object sender, SerialDataReceivedEventArgs e) {
            string data = serialPort.ReadExisting();
            txtOut.AppendText(data);
        }

        // About box
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iSerial_Load(object sender, EventArgs e)
        {
            // set default settings
            cbxBaudRate.Text = "9600";
            cbxComPort.Text = "COM4";
            cbxDataBits.Text = "8";
            cbxParity.Text = "None";
            cbxStopBits.Text = "One";
        }                                                                         

        private void txtIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btSend.PerformClick();
            }
        }

    }
}
