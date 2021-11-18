
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
            this.CONNECT_Button.Size = new System.Drawing.Size(138, 51);
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
            this.SysLog.Location = new System.Drawing.Point(537, 13);
            this.SysLog.Name = "SysLog";
            this.SysLog.Size = new System.Drawing.Size(363, 51);
            this.SysLog.TabIndex = 7;
            this.SysLog.Text = "System log";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(349, 14);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(182, 49);
            this.DisconnectButton.TabIndex = 8;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // RevButton
            // 
            this.RevButton.Location = new System.Drawing.Point(12, 448);
            this.RevButton.Name = "RevButton";
            this.RevButton.Size = new System.Drawing.Size(101, 37);
            this.RevButton.TabIndex = 9;
            this.RevButton.Text = "REV";
            this.RevButton.UseVisualStyleBackColor = true;
            // 
            // OffButton
            // 
            this.OffButton.Location = new System.Drawing.Point(123, 448);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(101, 37);
            this.OffButton.TabIndex = 10;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // FwdButton
            // 
            this.FwdButton.Location = new System.Drawing.Point(230, 448);
            this.FwdButton.Name = "FwdButton";
            this.FwdButton.Size = new System.Drawing.Size(101, 37);
            this.FwdButton.TabIndex = 11;
            this.FwdButton.Text = "FWD";
            this.FwdButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 757);
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
            this.Text = "Form1";
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
    }
}

