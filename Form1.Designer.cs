
namespace SolenoidControl_01
{
    partial class Form1
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
            this.BAUDRATE_Textbox = new System.Windows.Forms.TextBox();
            this.COMPORT_Label = new System.Windows.Forms.Label();
            this.BAUDRATE_Label = new System.Windows.Forms.Label();
            this.CONNECT_Button = new System.Windows.Forms.Button();
            this.COMPORT_Textbox = new System.Windows.Forms.TextBox();
            this.SysLog = new System.Windows.Forms.RichTextBox();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.RevButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.FwdButton = new System.Windows.Forms.Button();
            this.XButton = new System.Windows.Forms.Button();
            this.ZButton = new System.Windows.Forms.Button();
            this.EHWButton = new System.Windows.Forms.Button();
            this.FourthButton = new System.Windows.Forms.Button();
            this.YButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.GoButton = new System.Windows.Forms.Button();
            this.FastButton = new System.Windows.Forms.Button();
            this.Measure3Button = new System.Windows.Forms.Button();
            this.FeedOverrideButton = new System.Windows.Forms.Button();
            this.SpindleOverrideButton = new System.Windows.Forms.Button();
            this.Measure1Button = new System.Windows.Forms.Button();
            this.DoorLockButton = new System.Windows.Forms.Button();
            this.WashButton = new System.Windows.Forms.Button();
            this.AirButton = new System.Windows.Forms.Button();
            this.CoolantButton = new System.Windows.Forms.Button();
            this.Fwd2Button = new System.Windows.Forms.Button();
            this.Rev2Button = new System.Windows.Forms.Button();
            this.Fwd3Button = new System.Windows.Forms.Button();
            this.Rev3Button = new System.Windows.Forms.Button();
            this.Measure2Button = new System.Windows.Forms.Button();
            this.PeriodButton = new System.Windows.Forms.Button();
            this.IncSetButton = new System.Windows.Forms.Button();
            this.AbsSetButton = new System.Windows.Forms.Button();
            this.Num8Button = new System.Windows.Forms.Button();
            this.Num7Button = new System.Windows.Forms.Button();
            this.Z2Button = new System.Windows.Forms.Button();
            this.Y2Button = new System.Windows.Forms.Button();
            this.X2Button = new System.Windows.Forms.Button();
            this.Num1Button = new System.Windows.Forms.Button();
            this.Num2Button = new System.Windows.Forms.Button();
            this.Num6Button = new System.Windows.Forms.Button();
            this.Num4Button = new System.Windows.Forms.Button();
            this.Num5Button = new System.Windows.Forms.Button();
            this.Num9Button = new System.Windows.Forms.Button();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.Num3Button = new System.Windows.Forms.Button();
            this.Num0Button = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.CycleLabel = new System.Windows.Forms.Label();
            this.ChipRemovalLabel = new System.Windows.Forms.Label();
            this.AtcIndexLabel = new System.Windows.Forms.Label();
            this.RightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAUDRATE_Textbox
            // 
            this.BAUDRATE_Textbox.Location = new System.Drawing.Point(13, 42);
            this.BAUDRATE_Textbox.Name = "BAUDRATE_Textbox";
            this.BAUDRATE_Textbox.Size = new System.Drawing.Size(100, 22);
            this.BAUDRATE_Textbox.TabIndex = 1;
            // 
            // COMPORT_Label
            // 
            this.COMPORT_Label.AutoSize = true;
            this.COMPORT_Label.Location = new System.Drawing.Point(120, 17);
            this.COMPORT_Label.Name = "COMPORT_Label";
            this.COMPORT_Label.Size = new System.Drawing.Size(78, 17);
            this.COMPORT_Label.TabIndex = 2;
            this.COMPORT_Label.Text = "COMPORT";
            // 
            // BAUDRATE_Label
            // 
            this.BAUDRATE_Label.AutoSize = true;
            this.BAUDRATE_Label.Location = new System.Drawing.Point(120, 46);
            this.BAUDRATE_Label.Name = "BAUDRATE_Label";
            this.BAUDRATE_Label.Size = new System.Drawing.Size(83, 17);
            this.BAUDRATE_Label.TabIndex = 3;
            this.BAUDRATE_Label.Text = "BAUDRATE";
            // 
            // CONNECT_Button
            // 
            this.CONNECT_Button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CONNECT_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONNECT_Button.Location = new System.Drawing.Point(205, 13);
            this.CONNECT_Button.Name = "CONNECT_Button";
            this.CONNECT_Button.Size = new System.Drawing.Size(175, 51);
            this.CONNECT_Button.TabIndex = 5;
            this.CONNECT_Button.Text = "CONNECT";
            this.CONNECT_Button.UseVisualStyleBackColor = false;
            this.CONNECT_Button.Click += new System.EventHandler(this.CONNECT_Button_Click);
            // 
            // COMPORT_Textbox
            // 
            this.COMPORT_Textbox.Location = new System.Drawing.Point(13, 13);
            this.COMPORT_Textbox.Name = "COMPORT_Textbox";
            this.COMPORT_Textbox.Size = new System.Drawing.Size(100, 22);
            this.COMPORT_Textbox.TabIndex = 6;
            // 
            // SysLog
            // 
            this.SysLog.Location = new System.Drawing.Point(595, 13);
            this.SysLog.Name = "SysLog";
            this.SysLog.Size = new System.Drawing.Size(422, 109);
            this.SysLog.TabIndex = 7;
            this.SysLog.Text = "System log";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(386, 14);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(182, 49);
            this.DisconnectButton.TabIndex = 8;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // RevButton
            // 
            this.RevButton.Location = new System.Drawing.Point(16, 85);
            this.RevButton.Name = "RevButton";
            this.RevButton.Size = new System.Drawing.Size(101, 37);
            this.RevButton.TabIndex = 9;
            this.RevButton.Text = "REV";
            this.RevButton.UseVisualStyleBackColor = true;
            this.RevButton.Click += new System.EventHandler(this.RevButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(123, 85);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(101, 37);
            this.OffButton.TabIndex = 10;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // FwdButton
            // 
            this.FwdButton.Location = new System.Drawing.Point(230, 85);
            this.FwdButton.Name = "FwdButton";
            this.FwdButton.Size = new System.Drawing.Size(101, 37);
            this.FwdButton.TabIndex = 11;
            this.FwdButton.Text = "FWD";
            this.FwdButton.UseVisualStyleBackColor = true;
            this.FwdButton.Click += new System.EventHandler(this.FwdButton_Click);
            // 
            // XButton
            // 
            this.XButton.Location = new System.Drawing.Point(16, 177);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(101, 37);
            this.XButton.TabIndex = 12;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = true;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // ZButton
            // 
            this.ZButton.Location = new System.Drawing.Point(123, 220);
            this.ZButton.Name = "ZButton";
            this.ZButton.Size = new System.Drawing.Size(101, 37);
            this.ZButton.TabIndex = 13;
            this.ZButton.Text = "Z";
            this.ZButton.UseVisualStyleBackColor = true;
            this.ZButton.Click += new System.EventHandler(this.ZButton_Click);
            // 
            // EHWButton
            // 
            this.EHWButton.Location = new System.Drawing.Point(123, 177);
            this.EHWButton.Name = "EHWButton";
            this.EHWButton.Size = new System.Drawing.Size(101, 37);
            this.EHWButton.TabIndex = 14;
            this.EHWButton.Text = "EHW";
            this.EHWButton.UseVisualStyleBackColor = true;
            this.EHWButton.Click += new System.EventHandler(this.EHWButton_Click);
            // 
            // FourthButton
            // 
            this.FourthButton.Location = new System.Drawing.Point(123, 134);
            this.FourthButton.Name = "FourthButton";
            this.FourthButton.Size = new System.Drawing.Size(101, 37);
            this.FourthButton.TabIndex = 15;
            this.FourthButton.Text = "4th";
            this.FourthButton.UseVisualStyleBackColor = true;
            this.FourthButton.Click += new System.EventHandler(this.FourthButton_Click);
            // 
            // YButton
            // 
            this.YButton.Location = new System.Drawing.Point(230, 177);
            this.YButton.Name = "YButton";
            this.YButton.Size = new System.Drawing.Size(101, 37);
            this.YButton.TabIndex = 16;
            this.YButton.Text = "Y";
            this.YButton.UseVisualStyleBackColor = true;
            this.YButton.Click += new System.EventHandler(this.YButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(177, 284);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(101, 37);
            this.StopButton.TabIndex = 17;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(70, 284);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(101, 37);
            this.GoButton.TabIndex = 18;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // FastButton
            // 
            this.FastButton.Location = new System.Drawing.Point(467, 249);
            this.FastButton.Name = "FastButton";
            this.FastButton.Size = new System.Drawing.Size(101, 37);
            this.FastButton.TabIndex = 19;
            this.FastButton.Text = "FAST";
            this.FastButton.UseVisualStyleBackColor = true;
            this.FastButton.Click += new System.EventHandler(this.FastButton_Click);
            // 
            // Measure3Button
            // 
            this.Measure3Button.Location = new System.Drawing.Point(467, 193);
            this.Measure3Button.Name = "Measure3Button";
            this.Measure3Button.Size = new System.Drawing.Size(101, 50);
            this.Measure3Button.TabIndex = 20;
            this.Measure3Button.Text = ".010 IN    .200 MM";
            this.Measure3Button.UseVisualStyleBackColor = true;
            this.Measure3Button.Click += new System.EventHandler(this.Measure3Button_Click);
            // 
            // FeedOverrideButton
            // 
            this.FeedOverrideButton.Location = new System.Drawing.Point(349, 191);
            this.FeedOverrideButton.Name = "FeedOverrideButton";
            this.FeedOverrideButton.Size = new System.Drawing.Size(101, 46);
            this.FeedOverrideButton.TabIndex = 21;
            this.FeedOverrideButton.Text = "Feed Override";
            this.FeedOverrideButton.UseVisualStyleBackColor = true;
            this.FeedOverrideButton.Click += new System.EventHandler(this.FeedOverrideButton_Click);
            // 
            // SpindleOverrideButton
            // 
            this.SpindleOverrideButton.Location = new System.Drawing.Point(349, 100);
            this.SpindleOverrideButton.Name = "SpindleOverrideButton";
            this.SpindleOverrideButton.Size = new System.Drawing.Size(101, 50);
            this.SpindleOverrideButton.TabIndex = 22;
            this.SpindleOverrideButton.Text = "Spindle Override";
            this.SpindleOverrideButton.UseVisualStyleBackColor = true;
            this.SpindleOverrideButton.Click += new System.EventHandler(this.SpindleOverrideButton_Click);
            // 
            // Measure1Button
            // 
            this.Measure1Button.Location = new System.Drawing.Point(467, 85);
            this.Measure1Button.Name = "Measure1Button";
            this.Measure1Button.Size = new System.Drawing.Size(101, 46);
            this.Measure1Button.TabIndex = 24;
            this.Measure1Button.Text = ".0001IN   .002 MM";
            this.Measure1Button.UseVisualStyleBackColor = true;
            this.Measure1Button.Click += new System.EventHandler(this.Measure1Button_Click);
            // 
            // DoorLockButton
            // 
            this.DoorLockButton.Location = new System.Drawing.Point(916, 134);
            this.DoorLockButton.Name = "DoorLockButton";
            this.DoorLockButton.Size = new System.Drawing.Size(101, 37);
            this.DoorLockButton.TabIndex = 25;
            this.DoorLockButton.Text = "DOOR LOCK";
            this.DoorLockButton.UseVisualStyleBackColor = true;
            this.DoorLockButton.Click += new System.EventHandler(this.DoorLockButton_Click);
            // 
            // WashButton
            // 
            this.WashButton.Location = new System.Drawing.Point(809, 134);
            this.WashButton.Name = "WashButton";
            this.WashButton.Size = new System.Drawing.Size(101, 37);
            this.WashButton.TabIndex = 26;
            this.WashButton.Text = "WASH";
            this.WashButton.UseVisualStyleBackColor = true;
            this.WashButton.Click += new System.EventHandler(this.WashButton_Click);
            // 
            // AirButton
            // 
            this.AirButton.Location = new System.Drawing.Point(702, 134);
            this.AirButton.Name = "AirButton";
            this.AirButton.Size = new System.Drawing.Size(101, 37);
            this.AirButton.TabIndex = 27;
            this.AirButton.Text = "AIR";
            this.AirButton.UseVisualStyleBackColor = true;
            this.AirButton.Click += new System.EventHandler(this.AirButton_Click);
            // 
            // CoolantButton
            // 
            this.CoolantButton.Location = new System.Drawing.Point(595, 134);
            this.CoolantButton.Name = "CoolantButton";
            this.CoolantButton.Size = new System.Drawing.Size(101, 37);
            this.CoolantButton.TabIndex = 28;
            this.CoolantButton.Text = "COOLANT";
            this.CoolantButton.UseVisualStyleBackColor = true;
            this.CoolantButton.Click += new System.EventHandler(this.CoolantButton_Click);
            // 
            // Fwd2Button
            // 
            this.Fwd2Button.Location = new System.Drawing.Point(595, 177);
            this.Fwd2Button.Name = "Fwd2Button";
            this.Fwd2Button.Size = new System.Drawing.Size(101, 37);
            this.Fwd2Button.TabIndex = 29;
            this.Fwd2Button.Text = "FWD";
            this.Fwd2Button.UseVisualStyleBackColor = true;
            this.Fwd2Button.Click += new System.EventHandler(this.Fwd2Button_Click);
            // 
            // Rev2Button
            // 
            this.Rev2Button.Location = new System.Drawing.Point(702, 177);
            this.Rev2Button.Name = "Rev2Button";
            this.Rev2Button.Size = new System.Drawing.Size(101, 37);
            this.Rev2Button.TabIndex = 30;
            this.Rev2Button.Text = "REV";
            this.Rev2Button.UseVisualStyleBackColor = true;
            this.Rev2Button.Click += new System.EventHandler(this.Rev2Button_Click);
            // 
            // Fwd3Button
            // 
            this.Fwd3Button.Location = new System.Drawing.Point(809, 177);
            this.Fwd3Button.Name = "Fwd3Button";
            this.Fwd3Button.Size = new System.Drawing.Size(101, 37);
            this.Fwd3Button.TabIndex = 31;
            this.Fwd3Button.Text = "FWD";
            this.Fwd3Button.UseVisualStyleBackColor = true;
            this.Fwd3Button.Click += new System.EventHandler(this.Fwd3Button_Click);
            // 
            // Rev3Button
            // 
            this.Rev3Button.Location = new System.Drawing.Point(916, 177);
            this.Rev3Button.Name = "Rev3Button";
            this.Rev3Button.Size = new System.Drawing.Size(101, 37);
            this.Rev3Button.TabIndex = 32;
            this.Rev3Button.Text = "REV";
            this.Rev3Button.UseVisualStyleBackColor = true;
            this.Rev3Button.Click += new System.EventHandler(this.Rev3Button_Click);
            // 
            // Measure2Button
            // 
            this.Measure2Button.Location = new System.Drawing.Point(467, 137);
            this.Measure2Button.Name = "Measure2Button";
            this.Measure2Button.Size = new System.Drawing.Size(101, 50);
            this.Measure2Button.TabIndex = 33;
            this.Measure2Button.Text = ".001 IN  .020MM";
            this.Measure2Button.UseVisualStyleBackColor = true;
            this.Measure2Button.Click += new System.EventHandler(this.Measure2Button_Click);
            // 
            // PeriodButton
            // 
            this.PeriodButton.Location = new System.Drawing.Point(1360, 187);
            this.PeriodButton.Name = "PeriodButton";
            this.PeriodButton.Size = new System.Drawing.Size(101, 37);
            this.PeriodButton.TabIndex = 34;
            this.PeriodButton.Text = ".";
            this.PeriodButton.UseVisualStyleBackColor = true;
            this.PeriodButton.Click += new System.EventHandler(this.PeriodButton_Click);
            // 
            // IncSetButton
            // 
            this.IncSetButton.Location = new System.Drawing.Point(1146, 14);
            this.IncSetButton.Name = "IncSetButton";
            this.IncSetButton.Size = new System.Drawing.Size(101, 37);
            this.IncSetButton.TabIndex = 35;
            this.IncSetButton.Text = "INC SET";
            this.IncSetButton.UseVisualStyleBackColor = true;
            this.IncSetButton.Click += new System.EventHandler(this.IncSetButton_Click);
            // 
            // AbsSetButton
            // 
            this.AbsSetButton.Location = new System.Drawing.Point(1360, 14);
            this.AbsSetButton.Name = "AbsSetButton";
            this.AbsSetButton.Size = new System.Drawing.Size(101, 37);
            this.AbsSetButton.TabIndex = 36;
            this.AbsSetButton.Text = "ABS SET";
            this.AbsSetButton.UseVisualStyleBackColor = true;
            this.AbsSetButton.Click += new System.EventHandler(this.AbsSetButton_Click);
            // 
            // Num8Button
            // 
            this.Num8Button.Location = new System.Drawing.Point(1253, 57);
            this.Num8Button.Name = "Num8Button";
            this.Num8Button.Size = new System.Drawing.Size(101, 37);
            this.Num8Button.TabIndex = 37;
            this.Num8Button.Text = "8";
            this.Num8Button.UseVisualStyleBackColor = true;
            this.Num8Button.Click += new System.EventHandler(this.Num8Button_Click);
            // 
            // Num7Button
            // 
            this.Num7Button.Location = new System.Drawing.Point(1146, 57);
            this.Num7Button.Name = "Num7Button";
            this.Num7Button.Size = new System.Drawing.Size(101, 37);
            this.Num7Button.TabIndex = 38;
            this.Num7Button.Text = "7";
            this.Num7Button.UseVisualStyleBackColor = true;
            this.Num7Button.Click += new System.EventHandler(this.Num7Button_Click);
            // 
            // Z2Button
            // 
            this.Z2Button.Location = new System.Drawing.Point(1035, 143);
            this.Z2Button.Name = "Z2Button";
            this.Z2Button.Size = new System.Drawing.Size(101, 37);
            this.Z2Button.TabIndex = 39;
            this.Z2Button.Text = "Z";
            this.Z2Button.UseVisualStyleBackColor = true;
            this.Z2Button.Click += new System.EventHandler(this.Z2Button_Click);
            // 
            // Y2Button
            // 
            this.Y2Button.Location = new System.Drawing.Point(1035, 100);
            this.Y2Button.Name = "Y2Button";
            this.Y2Button.Size = new System.Drawing.Size(101, 37);
            this.Y2Button.TabIndex = 40;
            this.Y2Button.Text = "Y";
            this.Y2Button.UseVisualStyleBackColor = true;
            this.Y2Button.Click += new System.EventHandler(this.Y2Button_Click);
            // 
            // X2Button
            // 
            this.X2Button.Location = new System.Drawing.Point(1035, 57);
            this.X2Button.Name = "X2Button";
            this.X2Button.Size = new System.Drawing.Size(101, 37);
            this.X2Button.TabIndex = 41;
            this.X2Button.Text = "X";
            this.X2Button.UseVisualStyleBackColor = true;
            this.X2Button.Click += new System.EventHandler(this.X2Button_Click);
            // 
            // Num1Button
            // 
            this.Num1Button.Location = new System.Drawing.Point(1146, 143);
            this.Num1Button.Name = "Num1Button";
            this.Num1Button.Size = new System.Drawing.Size(101, 37);
            this.Num1Button.TabIndex = 42;
            this.Num1Button.Text = "1";
            this.Num1Button.UseVisualStyleBackColor = true;
            this.Num1Button.Click += new System.EventHandler(this.Num1Button_Click);
            // 
            // Num2Button
            // 
            this.Num2Button.Location = new System.Drawing.Point(1253, 144);
            this.Num2Button.Name = "Num2Button";
            this.Num2Button.Size = new System.Drawing.Size(101, 37);
            this.Num2Button.TabIndex = 43;
            this.Num2Button.Text = "2";
            this.Num2Button.UseVisualStyleBackColor = true;
            this.Num2Button.Click += new System.EventHandler(this.Num2Button_Click);
            // 
            // Num6Button
            // 
            this.Num6Button.Location = new System.Drawing.Point(1360, 100);
            this.Num6Button.Name = "Num6Button";
            this.Num6Button.Size = new System.Drawing.Size(101, 37);
            this.Num6Button.TabIndex = 44;
            this.Num6Button.Text = "6";
            this.Num6Button.UseVisualStyleBackColor = true;
            this.Num6Button.Click += new System.EventHandler(this.Num6Button_Click);
            // 
            // Num4Button
            // 
            this.Num4Button.Location = new System.Drawing.Point(1146, 100);
            this.Num4Button.Name = "Num4Button";
            this.Num4Button.Size = new System.Drawing.Size(101, 37);
            this.Num4Button.TabIndex = 45;
            this.Num4Button.Text = "4";
            this.Num4Button.UseVisualStyleBackColor = true;
            this.Num4Button.Click += new System.EventHandler(this.Num4Button_Click);
            // 
            // Num5Button
            // 
            this.Num5Button.Location = new System.Drawing.Point(1253, 100);
            this.Num5Button.Name = "Num5Button";
            this.Num5Button.Size = new System.Drawing.Size(101, 37);
            this.Num5Button.TabIndex = 46;
            this.Num5Button.Text = "5";
            this.Num5Button.UseVisualStyleBackColor = true;
            this.Num5Button.Click += new System.EventHandler(this.Num5Button_Click);
            // 
            // Num9Button
            // 
            this.Num9Button.Location = new System.Drawing.Point(1360, 57);
            this.Num9Button.Name = "Num9Button";
            this.Num9Button.Size = new System.Drawing.Size(101, 37);
            this.Num9Button.TabIndex = 47;
            this.Num9Button.Text = "9";
            this.Num9Button.UseVisualStyleBackColor = true;
            this.Num9Button.Click += new System.EventHandler(this.Num9Button_Click);
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(1253, 230);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(208, 37);
            this.RestoreButton.TabIndex = 48;
            this.RestoreButton.Text = "RESTORE";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Location = new System.Drawing.Point(1146, 229);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(101, 37);
            this.EqualsButton.TabIndex = 49;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // Num3Button
            // 
            this.Num3Button.Location = new System.Drawing.Point(1360, 144);
            this.Num3Button.Name = "Num3Button";
            this.Num3Button.Size = new System.Drawing.Size(101, 37);
            this.Num3Button.TabIndex = 50;
            this.Num3Button.Text = "3";
            this.Num3Button.UseVisualStyleBackColor = true;
            this.Num3Button.Click += new System.EventHandler(this.Num3Button_Click);
            // 
            // Num0Button
            // 
            this.Num0Button.Location = new System.Drawing.Point(1253, 187);
            this.Num0Button.Name = "Num0Button";
            this.Num0Button.Size = new System.Drawing.Size(101, 37);
            this.Num0Button.TabIndex = 51;
            this.Num0Button.Text = "0";
            this.Num0Button.UseVisualStyleBackColor = true;
            this.Num0Button.Click += new System.EventHandler(this.Num0Button_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Location = new System.Drawing.Point(1146, 186);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(101, 37);
            this.PlusMinusButton.TabIndex = 52;
            this.PlusMinusButton.Text = "+/-";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.PlusMinusButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(1253, 359);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(101, 37);
            this.DownButton.TabIndex = 53;
            this.DownButton.Text = "v";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(1253, 273);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(101, 37);
            this.UpButton.TabIndex = 55;
            this.UpButton.Text = "^";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(1146, 312);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(101, 37);
            this.LeftButton.TabIndex = 56;
            this.LeftButton.Text = "<";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // CycleLabel
            // 
            this.CycleLabel.AutoSize = true;
            this.CycleLabel.Location = new System.Drawing.Point(65, 264);
            this.CycleLabel.Name = "CycleLabel";
            this.CycleLabel.Size = new System.Drawing.Size(52, 17);
            this.CycleLabel.TabIndex = 57;
            this.CycleLabel.Text = "CYCLE";
            // 
            // ChipRemovalLabel
            // 
            this.ChipRemovalLabel.AutoSize = true;
            this.ChipRemovalLabel.Location = new System.Drawing.Point(693, 220);
            this.ChipRemovalLabel.Name = "ChipRemovalLabel";
            this.ChipRemovalLabel.Size = new System.Drawing.Size(110, 17);
            this.ChipRemovalLabel.TabIndex = 58;
            this.ChipRemovalLabel.Text = "CHIP REMOVAL";
            // 
            // AtcIndexLabel
            // 
            this.AtcIndexLabel.AutoSize = true;
            this.AtcIndexLabel.Location = new System.Drawing.Point(937, 217);
            this.AtcIndexLabel.Name = "AtcIndexLabel";
            this.AtcIndexLabel.Size = new System.Drawing.Size(80, 17);
            this.AtcIndexLabel.TabIndex = 59;
            this.AtcIndexLabel.Text = "ATC INDEX";
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(1360, 312);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(101, 37);
            this.RightButton.TabIndex = 60;
            this.RightButton.Text = ">";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 408);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.AtcIndexLabel);
            this.Controls.Add(this.ChipRemovalLabel);
            this.Controls.Add(this.CycleLabel);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.PlusMinusButton);
            this.Controls.Add(this.Num0Button);
            this.Controls.Add(this.Num3Button);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.Num9Button);
            this.Controls.Add(this.Num5Button);
            this.Controls.Add(this.Num4Button);
            this.Controls.Add(this.Num6Button);
            this.Controls.Add(this.Num2Button);
            this.Controls.Add(this.Num1Button);
            this.Controls.Add(this.X2Button);
            this.Controls.Add(this.Y2Button);
            this.Controls.Add(this.Z2Button);
            this.Controls.Add(this.Num7Button);
            this.Controls.Add(this.Num8Button);
            this.Controls.Add(this.AbsSetButton);
            this.Controls.Add(this.IncSetButton);
            this.Controls.Add(this.PeriodButton);
            this.Controls.Add(this.Measure2Button);
            this.Controls.Add(this.Rev3Button);
            this.Controls.Add(this.Fwd3Button);
            this.Controls.Add(this.Rev2Button);
            this.Controls.Add(this.Fwd2Button);
            this.Controls.Add(this.CoolantButton);
            this.Controls.Add(this.AirButton);
            this.Controls.Add(this.WashButton);
            this.Controls.Add(this.DoorLockButton);
            this.Controls.Add(this.Measure1Button);
            this.Controls.Add(this.SpindleOverrideButton);
            this.Controls.Add(this.FeedOverrideButton);
            this.Controls.Add(this.Measure3Button);
            this.Controls.Add(this.FastButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.YButton);
            this.Controls.Add(this.FourthButton);
            this.Controls.Add(this.EHWButton);
            this.Controls.Add(this.ZButton);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.FwdButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.RevButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.SysLog);
            this.Controls.Add(this.COMPORT_Textbox);
            this.Controls.Add(this.CONNECT_Button);
            this.Controls.Add(this.BAUDRATE_Label);
            this.Controls.Add(this.COMPORT_Label);
            this.Controls.Add(this.BAUDRATE_Textbox);
            this.Name = "Form1";
            this.Text = "Virtual Machine Control Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BAUDRATE_Textbox;
        private System.Windows.Forms.Label COMPORT_Label;
        private System.Windows.Forms.Label BAUDRATE_Label;
        private System.Windows.Forms.Button CONNECT_Button;
        private System.Windows.Forms.TextBox COMPORT_Textbox;
        private System.Windows.Forms.RichTextBox SysLog;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button RevButton;
        private System.Windows.Forms.Button OffButton;
        private System.Windows.Forms.Button FwdButton;
        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button ZButton;
        private System.Windows.Forms.Button EHWButton;
        private System.Windows.Forms.Button FourthButton;
        private System.Windows.Forms.Button YButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button FastButton;
        private System.Windows.Forms.Button Measure3Button;
        private System.Windows.Forms.Button FeedOverrideButton;
        private System.Windows.Forms.Button SpindleOverrideButton;
        private System.Windows.Forms.Button Measure1Button;
        private System.Windows.Forms.Button DoorLockButton;
        private System.Windows.Forms.Button WashButton;
        private System.Windows.Forms.Button AirButton;
        private System.Windows.Forms.Button CoolantButton;
        private System.Windows.Forms.Button Fwd2Button;
        private System.Windows.Forms.Button Rev2Button;
        private System.Windows.Forms.Button Fwd3Button;
        private System.Windows.Forms.Button Rev3Button;
        private System.Windows.Forms.Button Measure2Button;
        private System.Windows.Forms.Button PeriodButton;
        private System.Windows.Forms.Button IncSetButton;
        private System.Windows.Forms.Button AbsSetButton;
        private System.Windows.Forms.Button Num8Button;
        private System.Windows.Forms.Button Num7Button;
        private System.Windows.Forms.Button Z2Button;
        private System.Windows.Forms.Button Y2Button;
        private System.Windows.Forms.Button X2Button;
        private System.Windows.Forms.Button Num1Button;
        private System.Windows.Forms.Button Num2Button;
        private System.Windows.Forms.Button Num6Button;
        private System.Windows.Forms.Button Num4Button;
        private System.Windows.Forms.Button Num5Button;
        private System.Windows.Forms.Button Num9Button;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button Num3Button;
        private System.Windows.Forms.Button Num0Button;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Label CycleLabel;
        private System.Windows.Forms.Label ChipRemovalLabel;
        private System.Windows.Forms.Label AtcIndexLabel;
        private System.Windows.Forms.Button RightButton;
    }
}

