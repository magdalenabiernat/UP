namespace cw12___Biernat_Bojzan
{
    partial class FormScanner
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
            this.pictueBoxPicture = new System.Windows.Forms.PictureBox();
            this.włączGórne = new System.Windows.Forms.Button();
            this.radioButtonColor = new System.Windows.Forms.RadioButton();
            this.radioButtonBlackWhite = new System.Windows.Forms.RadioButton();
            this.labelJasnosc = new System.Windows.Forms.Label();
            this.labelKontrast = new System.Windows.Forms.Label();
            this.labelDPI = new System.Windows.Forms.Label();
            this.textBoxJasnosc = new System.Windows.Forms.TextBox();
            this.textBoxKontrast = new System.Windows.Forms.TextBox();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictueBoxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictueBoxPicture
            // 
            this.pictueBoxPicture.Location = new System.Drawing.Point(292, 0);
            this.pictueBoxPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pictueBoxPicture.Name = "pictueBoxPicture";
            this.pictueBoxPicture.Size = new System.Drawing.Size(663, 660);
            this.pictueBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictueBoxPicture.TabIndex = 5;
            this.pictueBoxPicture.TabStop = false;
            // 
            // włączGórne
            // 
            this.włączGórne.Location = new System.Drawing.Point(13, 420);
            this.włączGórne.Margin = new System.Windows.Forms.Padding(4);
            this.włączGórne.Name = "włączGórne";
            this.włączGórne.Size = new System.Drawing.Size(100, 28);
            this.włączGórne.TabIndex = 11;
            this.włączGórne.Text = "Skanuj";
            this.włączGórne.UseVisualStyleBackColor = true;
            this.włączGórne.Click += new System.EventHandler(this.włączGórne_Click);
            // 
            // radioButtonColor
            // 
            this.radioButtonColor.AutoSize = true;
            this.radioButtonColor.Location = new System.Drawing.Point(13, 455);
            this.radioButtonColor.Name = "radioButtonColor";
            this.radioButtonColor.Size = new System.Drawing.Size(62, 21);
            this.radioButtonColor.TabIndex = 12;
            this.radioButtonColor.TabStop = true;
            this.radioButtonColor.Text = "Kolor";
            this.radioButtonColor.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlackWhite
            // 
            this.radioButtonBlackWhite.AutoSize = true;
            this.radioButtonBlackWhite.Location = new System.Drawing.Point(13, 482);
            this.radioButtonBlackWhite.Name = "radioButtonBlackWhite";
            this.radioButtonBlackWhite.Size = new System.Drawing.Size(109, 21);
            this.radioButtonBlackWhite.TabIndex = 13;
            this.radioButtonBlackWhite.TabStop = true;
            this.radioButtonBlackWhite.Text = "Czarno-białe";
            this.radioButtonBlackWhite.UseVisualStyleBackColor = true;
            // 
            // labelJasnosc
            // 
            this.labelJasnosc.AutoSize = true;
            this.labelJasnosc.Location = new System.Drawing.Point(155, 544);
            this.labelJasnosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJasnosc.Name = "labelJasnosc";
            this.labelJasnosc.Size = new System.Drawing.Size(64, 17);
            this.labelJasnosc.TabIndex = 19;
            this.labelJasnosc.Text = "Jasność:";
            // 
            // labelKontrast
            // 
            this.labelKontrast.AutoSize = true;
            this.labelKontrast.Location = new System.Drawing.Point(151, 480);
            this.labelKontrast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKontrast.Name = "labelKontrast";
            this.labelKontrast.Size = new System.Drawing.Size(65, 17);
            this.labelKontrast.TabIndex = 18;
            this.labelKontrast.Text = "Kontrast:";
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.Location = new System.Drawing.Point(150, 416);
            this.labelDPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(34, 17);
            this.labelDPI.TabIndex = 17;
            this.labelDPI.Text = "DPI:";
            // 
            // textBoxJasnosc
            // 
            this.textBoxJasnosc.Location = new System.Drawing.Point(152, 563);
            this.textBoxJasnosc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJasnosc.Name = "textBoxJasnosc";
            this.textBoxJasnosc.Size = new System.Drawing.Size(132, 22);
            this.textBoxJasnosc.TabIndex = 16;
            // 
            // textBoxKontrast
            // 
            this.textBoxKontrast.Location = new System.Drawing.Point(152, 499);
            this.textBoxKontrast.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKontrast.Name = "textBoxKontrast";
            this.textBoxKontrast.Size = new System.Drawing.Size(132, 22);
            this.textBoxKontrast.TabIndex = 15;
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(152, 435);
            this.textBoxDPI.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(132, 22);
            this.textBoxDPI.TabIndex = 14;
            // 
            // FormScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 661);
            this.Controls.Add(this.labelJasnosc);
            this.Controls.Add(this.labelKontrast);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.textBoxJasnosc);
            this.Controls.Add(this.textBoxKontrast);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.radioButtonBlackWhite);
            this.Controls.Add(this.radioButtonColor);
            this.Controls.Add(this.włączGórne);
            this.Controls.Add(this.pictueBoxPicture);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormScanner";
            this.Text = "Obsługa skanera";
            ((System.ComponentModel.ISupportInitialize)(this.pictueBoxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictueBoxPicture;
        private System.Windows.Forms.Button włączGórne;
        private System.Windows.Forms.RadioButton radioButtonColor;
        private System.Windows.Forms.RadioButton radioButtonBlackWhite;
        private System.Windows.Forms.Label labelJasnosc;
        private System.Windows.Forms.Label labelKontrast;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.TextBox textBoxJasnosc;
        private System.Windows.Forms.TextBox textBoxKontrast;
        private System.Windows.Forms.TextBox textBoxDPI;
    }
}

