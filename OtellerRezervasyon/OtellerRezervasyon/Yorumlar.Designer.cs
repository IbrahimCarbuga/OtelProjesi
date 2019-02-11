namespace OtellerRezervasyon
{
    partial class Yorumlar
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
            this.flowYorum = new System.Windows.Forms.FlowLayoutPanel();
            this.txtYorumBasligi = new System.Windows.Forms.TextBox();
            this.txtYorum = new System.Windows.Forms.TextBox();
            this.btnYorumKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowYorum
            // 
            this.flowYorum.Location = new System.Drawing.Point(13, 13);
            this.flowYorum.Name = "flowYorum";
            this.flowYorum.Size = new System.Drawing.Size(355, 189);
            this.flowYorum.TabIndex = 0;
            // 
            // txtYorumBasligi
            // 
            this.txtYorumBasligi.Location = new System.Drawing.Point(86, 221);
            this.txtYorumBasligi.Name = "txtYorumBasligi";
            this.txtYorumBasligi.Size = new System.Drawing.Size(150, 20);
            this.txtYorumBasligi.TabIndex = 1;
            // 
            // txtYorum
            // 
            this.txtYorum.Location = new System.Drawing.Point(86, 252);
            this.txtYorum.Multiline = true;
            this.txtYorum.Name = "txtYorum";
            this.txtYorum.Size = new System.Drawing.Size(201, 117);
            this.txtYorum.TabIndex = 2;
            // 
            // btnYorumKaydet
            // 
            this.btnYorumKaydet.Location = new System.Drawing.Point(293, 281);
            this.btnYorumKaydet.Name = "btnYorumKaydet";
            this.btnYorumKaydet.Size = new System.Drawing.Size(75, 42);
            this.btnYorumKaydet.TabIndex = 3;
            this.btnYorumKaydet.Text = "Kaydet";
            this.btnYorumKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yorum Başlığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yorum";
            // 
            // Yorumlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYorumKaydet);
            this.Controls.Add(this.txtYorum);
            this.Controls.Add(this.txtYorumBasligi);
            this.Controls.Add(this.flowYorum);
            this.Name = "Yorumlar";
            this.Text = "Yorumlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowYorum;
        private System.Windows.Forms.TextBox txtYorumBasligi;
        private System.Windows.Forms.TextBox txtYorum;
        private System.Windows.Forms.Button btnYorumKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}