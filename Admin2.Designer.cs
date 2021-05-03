
namespace Odev
{
    partial class Admin2
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
            this.btnTamamla = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblOnay = new System.Windows.Forms.Label();
            this.cbxOnay = new System.Windows.Forms.ComboBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamamla.Location = new System.Drawing.Point(275, 163);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(286, 46);
            this.btnTamamla.TabIndex = 22;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(195, 50);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 22);
            this.txtFiyat.TabIndex = 21;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(12, 50);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(156, 17);
            this.lblFiyat.TabIndex = 20;
            this.lblFiyat.Text = "Toplam bakiyenizi girin:";
            // 
            // lblOnay
            // 
            this.lblOnay.AutoSize = true;
            this.lblOnay.Location = new System.Drawing.Point(432, 53);
            this.lblOnay.Name = "lblOnay";
            this.lblOnay.Size = new System.Drawing.Size(229, 17);
            this.lblOnay.TabIndex = 25;
            this.lblOnay.Text = "Alıcı işlemlerini onaylıyor musunuz?";
            // 
            // cbxOnay
            // 
            this.cbxOnay.FormattingEnabled = true;
            this.cbxOnay.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cbxOnay.Location = new System.Drawing.Point(687, 50);
            this.cbxOnay.Name = "cbxOnay";
            this.cbxOnay.Size = new System.Drawing.Size(121, 24);
            this.cbxOnay.TabIndex = 26;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 103);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(110, 17);
            this.lblUserId.TabIndex = 27;
            this.lblUserId.Text = "Kullanıcı id girin:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(195, 98);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(121, 22);
            this.txtUserId.TabIndex = 28;
            // 
            // Admin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(831, 221);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.cbxOnay);
            this.Controls.Add(this.lblOnay);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Name = "Admin2";
            this.Text = "Admin2";
            this.Load += new System.EventHandler(this.Admin2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblOnay;
        private System.Windows.Forms.ComboBox cbxOnay;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
    }
}