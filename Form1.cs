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
            try
            {
                COMPORT.Write("OffButton Clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void RevButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("RevButton clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void FwdButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("FwdButton clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void FourthButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Fourth Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void XButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("X Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void EHWButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("EHW Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void YButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Y Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void ZButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Z Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Go Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Stop Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void SpindleOverrideButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Spindle Override Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void FeedOverrideButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Feed Override Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Measure1Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Measure1 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Measure2Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Measure2 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Measure3Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Measure 3 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void FastButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Fast Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void CoolantButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Coolant Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void AirButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Air Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void WashButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Wash Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void DoorLockButton_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Door Lock Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Fwd2Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("FWD 2 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Rev2Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("REV 2 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Fwd3Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("FWD3 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Rev3Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("REV3 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void X2Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("X2 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Y2Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Y2 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Z2Button_Click(object sender, EventArgs e)
        {
            try
            {
                COMPORT.Write("Z2 Button clicked");
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }
    }
}
