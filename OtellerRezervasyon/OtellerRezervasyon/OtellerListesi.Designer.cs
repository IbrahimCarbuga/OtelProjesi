namespace OtellerRezervasyon
{
    partial class OtellerListesi
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
            this.txtAraOtel = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.cmbOdaTuru = new System.Windows.Forms.ComboBox();
            this.dgwOteller = new System.Windows.Forms.DataGridView();
            this.linkGiris = new System.Windows.Forms.LinkLabel();
            this.linkKaydol = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOteller)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 71);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtAraOtel
            // 
            this.txtAraOtel.Location = new System.Drawing.Point(124, 90);
            this.txtAraOtel.Name = "txtAraOtel";
            this.txtAraOtel.Size = new System.Drawing.Size(187, 20);
            this.txtAraOtel.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(317, 90);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(12, 145);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(165, 20);
            this.dtpGiris.TabIndex = 3;
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(198, 145);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(148, 20);
            this.dtpCikis.TabIndex = 4;
            // 
            // cmbOdaTuru
            // 
            this.cmbOdaTuru.FormattingEnabled = true;
            this.cmbOdaTuru.Location = new System.Drawing.Point(372, 144);
            this.cmbOdaTuru.Name = "cmbOdaTuru";
            this.cmbOdaTuru.Size = new System.Drawing.Size(121, 21);
            this.cmbOdaTuru.TabIndex = 5;
            // 
            // dgwOteller
            // 
            this.dgwOteller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOteller.Location = new System.Drawing.Point(12, 177);
            this.dgwOteller.Name = "dgwOteller";
            this.dgwOteller.Size = new System.Drawing.Size(536, 239);
            this.dgwOteller.TabIndex = 6;
            // 
            // linkGiris
            // 
            this.linkGiris.AutoSize = true;
            this.linkGiris.Location = new System.Drawing.Point(450, 15);
            this.linkGiris.Name = "linkGiris";
            this.linkGiris.Size = new System.Drawing.Size(27, 13);
            this.linkGiris.TabIndex = 7;
            this.linkGiris.TabStop = true;
            this.linkGiris.Text = "Giriş";
            this.linkGiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGiris_LinkClicked);
            // 
            // linkKaydol
            // 
            this.linkKaydol.AutoSize = true;
            this.linkKaydol.Location = new System.Drawing.Point(501, 15);
            this.linkKaydol.Name = "linkKaydol";
            this.linkKaydol.Size = new System.Drawing.Size(39, 13);
            this.linkKaydol.TabIndex = 8;
            this.linkKaydol.TabStop = true;
            this.linkKaydol.Text = "Kaydol";
            this.linkKaydol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkKaydol_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giriş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Çıkış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Oda Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "/";
            // 
            // OtellerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 428);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkKaydol);
            this.Controls.Add(this.linkGiris);
            this.Controls.Add(this.dgwOteller);
            this.Controls.Add(this.cmbOdaTuru);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraOtel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OtellerListesi";
            this.Text = "OtellerListesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOteller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAraOtel;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.ComboBox cmbOdaTuru;
        private System.Windows.Forms.DataGridView dgwOteller;
        private System.Windows.Forms.LinkLabel linkGiris;
        private System.Windows.Forms.LinkLabel linkKaydol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}