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


namespace SolenoidControl_01
{
    public partial class Form1 : Form
    {
        String message = "This is currently working";
        int CHOSENBAUD;
        String CHOSENPORT;
        SerialPort COMPORT = new SerialPort();
        String text = "";
        bool showMachineButtons = false;



        public Form1()
        {
            InitializeComponent();
            COMPORT_Textbox.Text = "COM4";
            BAUDRATE_Textbox.Text = "115200";
            //TestButton.Enabled = false;
        }

        private void WriteToSysLog(String str)
        {
            SysLog.Text += Environment.NewLine + str;
            SysLog.Select(SysLog.Text.Length, 0);
            SysLog.ScrollToCaret();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void CONNECT_Button_Click(object sender, EventArgs e)
        {
            CHOSENBAUD = Convert.ToInt32(BAUDRATE_Textbox.Text);
            CHOSENPORT = COMPORT_Textbox.Text;
            try
            {
                COMPORT = new SerialPort(CHOSENPORT, CHOSENBAUD);
                COMPORT.Open();
                text = "Successful connection";
                WriteToSysLog(text);
            }
            catch
            {
                text = "Failed connection";
                WriteToSysLog(text);
            }
            
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMPORT.IsOpen)
                {
                    COMPORT.Close();
                    text = "Successful disconnect";
                    WriteToSysLog(text);

                }
                else
                {
                    text = "Not connected to a port";
                    WriteToSysLog(text);
                }
            }
            catch
            {
                text = "Failed disconnect";
                WriteToSysLog(text);
            }
        }

        private void OffButton_Click(object sender, EventArgs e)
        {

        }
    }
}
