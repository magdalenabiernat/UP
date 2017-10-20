namespace UrzadzeniaPeryferyjnemodem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PeripheralLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 397);
            this.textBox1.TabIndex = 1;
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
            this.MessageLabel.Location = new System.Drawing.Point(669, 50);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(65, 17);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "Message";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(659, 129);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Semd";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(641, 371);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(93, 61);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Dissconect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(535, 371);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(90, 61);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connct";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(352, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(391, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 456);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PeripheralLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PeripheralLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

