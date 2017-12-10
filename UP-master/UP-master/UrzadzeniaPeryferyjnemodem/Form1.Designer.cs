namespace UrzadzeniaPeryferyjnemodem
{
    partial class FormUP_Modem
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
            this.textBoxInformation = new System.Windows.Forms.TextBox();
            this.PeripheralLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.comboBoxMessage = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonDissconnect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxConnect = new System.Windows.Forms.TextBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInformation
            // 
            this.textBoxInformation.Location = new System.Drawing.Point(24, 47);
            this.textBoxInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxInformation.Multiline = true;
            this.textBoxInformation.Name = "textBoxInformation";
            this.textBoxInformation.Size = new System.Drawing.Size(271, 397);
            this.textBoxInformation.TabIndex = 1;
            this.textBoxInformation.TextChanged += new System.EventHandler(this.textBoxInformation_TextChanged);
            // 
            // PeripheralLabel
            // 
            this.PeripheralLabel.AutoSize = true;
            this.PeripheralLabel.Location = new System.Drawing.Point(21, 27);
            this.PeripheralLabel.Name = "PeripheralLabel";
            this.PeripheralLabel.Size = new System.Drawing.Size(73, 17);
            this.PeripheralLabel.TabIndex = 2;
            this.PeripheralLabel.Text = "Peripheral";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(672, 21);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(65, 17);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Message";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(662, 100);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(384, 351);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(93, 62);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(384, 285);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(91, 62);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // comboBoxMessage
            // 
            this.comboBoxMessage.FormattingEnabled = true;
            this.comboBoxMessage.Items.AddRange(new object[] {
            "ATA ",
            "ATB",
            "ATB1",
            "ATB2",
            "ATD",
            "ATE0",
            "ATE1",
            "ATH0",
            "ATH1",
            "ATI0",
            "ATL0",
            "ATL1",
            "ATL2",
            "ATL3",
            "ATM0",
            "ATM1",
            "AT2",
            "ATN0",
            "ATN1",
            "ATO0",
            "ATO1",
            "ATQ0",
            "ATQ1",
            "ATV0",
            "ATV1",
            "ATX0",
            "ATX1",
            "ATX2",
            "ATX3",
            "ATX4",
            "ATZ0"});
            this.comboBoxMessage.Location = new System.Drawing.Point(355, 50);
            this.comboBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMessage.Name = "comboBoxMessage";
            this.comboBoxMessage.Size = new System.Drawing.Size(391, 24);
            this.comboBoxMessage.TabIndex = 8;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(384, 217);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(91, 62);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(586, 189);
            this.comboBoxSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSpeed.TabIndex = 10;
            this.comboBoxSpeed.Text = "9600";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(691, 166);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(49, 17);
            this.labelSpeed.TabIndex = 11;
            this.labelSpeed.Text = "Speed";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(355, 187);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(160, 24);
            this.comboBoxPorts.TabIndex = 12;
            // 
            // buttonDissconnect
            // 
            this.buttonDissconnect.Location = new System.Drawing.Point(628, 387);
            this.buttonDissconnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDissconnect.Name = "buttonDissconnect";
            this.buttonDissconnect.Size = new System.Drawing.Size(100, 28);
            this.buttonDissconnect.TabIndex = 13;
            this.buttonDissconnect.Text = "Dissconnect";
            this.buttonDissconnect.UseVisualStyleBackColor = true;
            this.buttonDissconnect.Click += new System.EventHandler(this.buttonDissconnect_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(628, 351);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 14;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxConnect
            // 
            this.textBoxConnect.Location = new System.Drawing.Point(614, 285);
            this.textBoxConnect.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxConnect.Name = "textBoxConnect";
            this.textBoxConnect.Size = new System.Drawing.Size(132, 22);
            this.textBoxConnect.TabIndex = 15;
            this.textBoxConnect.TextChanged += new System.EventHandler(this.textBoxConnect_TextChanged);
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Location = new System.Drawing.Point(628, 315);
            this.buttonPickUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(100, 28);
            this.buttonPickUp.TabIndex = 16;
            this.buttonPickUp.Text = "Pick up";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUp_Click);
            // 
            // FormUP_Modem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 455);
            this.Controls.Add(this.buttonPickUp);
            this.Controls.Add(this.textBoxConnect);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDissconnect);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxMessage);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PeripheralLabel);
            this.Controls.Add(this.textBoxInformation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUP_Modem";
            this.Text = "UP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInformation;
        private System.Windows.Forms.Label PeripheralLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox comboBoxMessage;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonDissconnect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxConnect;
        private System.Windows.Forms.Button buttonPickUp;
    }
}

