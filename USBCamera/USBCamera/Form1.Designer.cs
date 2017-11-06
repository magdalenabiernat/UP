namespace USBCamera
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxSelectCamera = new System.Windows.Forms.ComboBox();
            this.buttonTurnOn = new System.Windows.Forms.Button();
            this.buttonTurnOff = new System.Windows.Forms.Button();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenBrowser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1707, 886);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxSelectCamera
            // 
            this.comboBoxSelectCamera.FormattingEnabled = true;
            this.comboBoxSelectCamera.Location = new System.Drawing.Point(12, 927);
            this.comboBoxSelectCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectCamera.Name = "comboBoxSelectCamera";
            this.comboBoxSelectCamera.Size = new System.Drawing.Size(440, 24);
            this.comboBoxSelectCamera.TabIndex = 1;
            // 
            // buttonTurnOn
            // 
            this.buttonTurnOn.Location = new System.Drawing.Point(461, 924);
            this.buttonTurnOn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTurnOn.Name = "buttonTurnOn";
            this.buttonTurnOn.Size = new System.Drawing.Size(100, 31);
            this.buttonTurnOn.TabIndex = 2;
            this.buttonTurnOn.Text = "Włącz";
            this.buttonTurnOn.UseVisualStyleBackColor = true;
            this.buttonTurnOn.Click += new System.EventHandler(this.buttonTurnOn_Click);
            // 
            // buttonTurnOff
            // 
            this.buttonTurnOff.Location = new System.Drawing.Point(569, 924);
            this.buttonTurnOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTurnOff.Name = "buttonTurnOff";
            this.buttonTurnOff.Size = new System.Drawing.Size(100, 31);
            this.buttonTurnOff.TabIndex = 3;
            this.buttonTurnOff.Text = "Wyłącz kamerę";
            this.buttonTurnOff.UseVisualStyleBackColor = true;
            this.buttonTurnOff.Click += new System.EventHandler(this.buttonTurnOff_Click);
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.Location = new System.Drawing.Point(1048, 926);
            this.buttonTakePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(136, 28);
            this.buttonTakePicture.TabIndex = 4;
            this.buttonTakePicture.Text = "Wykonaj zdjęcie";
            this.buttonTakePicture.UseVisualStyleBackColor = true;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(781, 928);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(244, 22);
            this.textBoxFileName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(777, 905);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa zdjęcia:";
            // 
            // buttonOpenBrowser
            // 
            this.buttonOpenBrowser.Location = new System.Drawing.Point(1337, 928);
            this.buttonOpenBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOpenBrowser.Name = "buttonOpenBrowser";
            this.buttonOpenBrowser.Size = new System.Drawing.Size(135, 28);
            this.buttonOpenBrowser.TabIndex = 7;
            this.buttonOpenBrowser.Text = "Przeglądarka";
            this.buttonOpenBrowser.UseVisualStyleBackColor = true;
            this.buttonOpenBrowser.Click += new System.EventHandler(this.buttonOpenBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 905);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kamera:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 1013);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonTakePicture);
            this.Controls.Add(this.buttonTurnOff);
            this.Controls.Add(this.buttonTurnOn);
            this.Controls.Add(this.comboBoxSelectCamera);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kamera USB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxSelectCamera;
        private System.Windows.Forms.Button buttonTurnOn;
        private System.Windows.Forms.Button buttonTurnOff;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenBrowser;
        private System.Windows.Forms.Label label2;
    }
}

