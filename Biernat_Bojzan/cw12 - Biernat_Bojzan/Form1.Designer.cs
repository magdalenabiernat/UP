namespace cw12___Biernat_Bojzan
{
    partial class obsługaKameryUSB
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
            this.napisKamery = new System.Windows.Forms.Label();
            this.obrazekLewy = new System.Windows.Forms.PictureBox();
            this.włączGórne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obrazekLewy)).BeginInit();
            this.SuspendLayout();
            // 
            // napisKamery
            // 
            this.napisKamery.AutoSize = true;
            this.napisKamery.Location = new System.Drawing.Point(22, 429);
            this.napisKamery.Name = "napisKamery";
            this.napisKamery.Size = new System.Drawing.Size(45, 13);
            this.napisKamery.TabIndex = 0;
            this.napisKamery.Text = "Kamery:";
            // 
            // obrazekLewy
            // 
            this.obrazekLewy.Location = new System.Drawing.Point(0, 0);
            this.obrazekLewy.Name = "obrazekLewy";
            this.obrazekLewy.Size = new System.Drawing.Size(716, 398);
            this.obrazekLewy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obrazekLewy.TabIndex = 5;
            this.obrazekLewy.TabStop = false;
            // 
            // włączGórne
            // 
            this.włączGórne.Location = new System.Drawing.Point(12, 449);
            this.włączGórne.Name = "włączGórne";
            this.włączGórne.Size = new System.Drawing.Size(75, 23);
            this.włączGórne.TabIndex = 11;
            this.włączGórne.Text = "włącz";
            this.włączGórne.UseVisualStyleBackColor = true;
            this.włączGórne.Click += new System.EventHandler(this.włączGórne_Click);
            // 
            // obsługaKameryUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 537);
            this.Controls.Add(this.włączGórne);
            this.Controls.Add(this.obrazekLewy);
            this.Controls.Add(this.napisKamery);
            this.Name = "obsługaKameryUSB";
            this.Text = "Obsługa kamery USB";
            ((System.ComponentModel.ISupportInitialize)(this.obrazekLewy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label napisKamery;
        private System.Windows.Forms.PictureBox obrazekLewy;
        private System.Windows.Forms.Button włączGórne;
    }
}

