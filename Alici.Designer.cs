
namespace Odev
{
    partial class Alici
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
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamamla.Location = new System.Drawing.Point(32, 170);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(298, 46);
            this.btnTamamla.TabIndex = 13;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(209, 40);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 22);
            this.txtFiyat.TabIndex = 12;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(26, 43);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(156, 17);
            this.lblFiyat.TabIndex = 11;
            this.lblFiyat.Text = "Toplam bakiyenizi girin:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(29, 99);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(110, 17);
            this.lblUserId.TabIndex = 14;
            this.lblUserId.Text = "Kullanıcı id girin:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(209, 93);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(121, 22);
            this.txtUserId.TabIndex = 15;
            // 
            // Alici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(357, 235);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Name = "Alici";
            this.Text = "Alici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
    }
}