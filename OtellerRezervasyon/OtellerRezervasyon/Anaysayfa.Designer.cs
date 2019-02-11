namespace OtellerRezervasyon
{
    partial class frmAnasayfa
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
            this.pctAnasayfa = new System.Windows.Forms.PictureBox();
            this.txtOtelSehirAnasayfa = new System.Windows.Forms.TextBox();
            this.btnAraAnasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctAnasayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // pctAnasayfa
            // 
            this.pctAnasayfa.Location = new System.Drawing.Point(160, 48);
            this.pctAnasayfa.Name = "pctAnasayfa";
            this.pctAnasayfa.Size = new System.Drawing.Size(327, 112);
            this.pctAnasayfa.TabIndex = 0;
            this.pctAnasayfa.TabStop = false;
            // 
            // txtOtelSehirAnasayfa
            // 
            this.txtOtelSehirAnasayfa.Location = new System.Drawing.Point(160, 180);
            this.txtOtelSehirAnasayfa.Name = "txtOtelSehirAnasayfa";
            this.txtOtelSehirAnasayfa.Size = new System.Drawing.Size(245, 20);
            this.txtOtelSehirAnasayfa.TabIndex = 1;
            this.txtOtelSehirAnasayfa.Text = "Orn:Sehir veya Otel ismi giriniz";
            // 
            // btnAraAnasayfa
            // 
            this.btnAraAnasayfa.Location = new System.Drawing.Point(429, 180);
            this.btnAraAnasayfa.Name = "btnAraAnasayfa";
            this.btnAraAnasayfa.Size = new System.Drawing.Size(75, 23);
            this.btnAraAnasayfa.TabIndex = 2;
            this.btnAraAnasayfa.Text = "Ara";
            this.btnAraAnasayfa.UseVisualStyleBackColor = true;
            this.btnAraAnasayfa.Click += new System.EventHandler(this.btnAraAnasayfa_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 312);
            this.Controls.Add(this.btnAraAnasayfa);
            this.Controls.Add(this.txtOtelSehirAnasayfa);
            this.Controls.Add(this.pctAnasayfa);
            this.Name = "frmAnasayfa";
            this.Text = "Anasayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pctAnasayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctAnasayfa;
        private System.Windows.Forms.TextBox txtOtelSehirAnasayfa;
        private System.Windows.Forms.Button btnAraAnasayfa;
    }
}

