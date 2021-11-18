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
        String message;
        int CHOSENBAUD;
        String CHOSENPORT;
        SerialPort COMPORT = new SerialPort();
        String text = "";



        public Form1()
        {
            InitializeComponent();
            COMPORT_Textbox.Text = "COM4";
            BAUDRATE_Textbox.Text = "115200";
            //TestButton.Enabled = false;
            DisconnectButton.Enabled = false;

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
                CONNECT_Button.Enabled = false;
                DisconnectButton.Enabled = true;
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
                    DisconnectButton.Enabled = false;
                    CONNECT_Button.Enabled = true;
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
                message = "Off Button Clicked";
                COMPORT.Write(message);
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
                message = "Rev Button Clicked";
                COMPORT.Write(message);
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
                message = "FWD Button Clicked";
                COMPORT.Write(message);
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
                message = "Fourth Button Clicked";
                COMPORT.Write(message);
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
                message = "X Button clicked";
                COMPORT.Write(message);
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
                message = "EHW Button clicked";
                COMPORT.Write(message);
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
                message = "Y Button clicked";
                COMPORT.Write(message);
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
                message = "Y Button clicked";
                COMPORT.Write(message);
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
                message = "Go Button clicked";
                COMPORT.Write(message);
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
                message = "Stop Button clicked";
                COMPORT.Write(message);
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
                message = "Spindle Override Button clicked";
                COMPORT.Write(message);
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
                message = "Feed Override Button clicked";
                COMPORT.Write(message);
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
                message = "Measure 1 Button";
                COMPORT.Write(message);
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
                message = "Measure2 Button clicked";
                COMPORT.Write(message);
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
                message = "Measure 3 Button clicked";
                COMPORT.Write(message);
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
                message = "Fast Button clicked";
                COMPORT.Write(message);
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
                message = "Coolant Button clicked";
                COMPORT.Write(message);
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
                message = "Air Button clicked";
                COMPORT.Write(message);
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
                message = "Wash Button clicked";
                COMPORT.Write(message);
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
                message = "Door Lock Button clicked";
                COMPORT.Write(message);
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
                message = "FWD2 Button clicked";
                COMPORT.Write(message);
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
                message = "REV2 Button clicked";
                COMPORT.Write(message);
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
                message = "FWD3 Button clicked";
                COMPORT.Write(message);
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
                message = "REV3 Button clicked";
                COMPORT.Write(message);
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
                message = "X2 Button clicked";
                COMPORT.Write(message);
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
                message = "Y2 Button clicked";
                COMPORT.Write(message);
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
                message = "Z2 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void IncSetButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Inc Set Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void AbsSetButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Abs Set Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num7Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num7 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num8Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num8 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num9Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num 9 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num4Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "um 4 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num5Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num 5 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num6Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num 6 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num1Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num1 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num2Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num2 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num3Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num3 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Plus Minus Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void Num0Button_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Num0 Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Period Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Equals Button Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Restore Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Up Button Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Left Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Right Button clicked";
                COMPORT.Write(message);
                WriteToSysLog("Transmitted: " + message);
            }
            catch
            {
                text = "Message did not transmit";
                WriteToSysLog(text);
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            try
            {
                message = "Down Button clicked";
                COMPORT.Write(message);
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
