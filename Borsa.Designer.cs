
namespace Odev
{
    partial class Borsa
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
            this.lblUrun = new System.Windows.Forms.Label();
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.lblSaticiId = new System.Windows.Forms.Label();
            this.cbxSaticiId = new System.Windows.Forms.ComboBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblKalanBakiye = new System.Windows.Forms.Label();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(19, 88);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(198, 17);
            this.lblUrun.TabIndex = 0;
            this.lblUrun.Text = "Almak istediğiniz ürünü seçin: ";
            // 
            // cbxUrun
            // 
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Location = new System.Drawing.Point(294, 85);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(121, 24);
            this.cbxUrun.TabIndex = 1;
            this.cbxUrun.SelectedIndexChanged += new System.EventHandler(this.cbxUrun_SelectedIndexChanged);
            // 
            // lblSaticiId
            // 
            this.lblSaticiId.AutoSize = true;
            this.lblSaticiId.Location = new System.Drawing.Point(19, 150);
            this.lblSaticiId.Name = "lblSaticiId";
            this.lblSaticiId.Size = new System.Drawing.Size(246, 17);
            this.lblSaticiId.TabIndex = 2;
            this.lblSaticiId.Text = "Ürünü almak istediğiniz satıcı id seçin:";
            // 
            // cbxSaticiId
            // 
            this.cbxSaticiId.FormattingEnabled = true;
            this.cbxSaticiId.Location = new System.Drawing.Point(294, 147);
            this.cbxSaticiId.Name = "cbxSaticiId";
            this.cbxSaticiId.Size = new System.Drawing.Size(121, 24);
            this.cbxSaticiId.TabIndex = 3;
            this.cbxSaticiId.SelectedIndexChanged += new System.EventHandler(this.cbxSaticiId_SelectedIndexChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(22, 31);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(148, 17);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "Kendi kullanıcı id girin:";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(294, 28);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(121, 22);
            this.txtUserId.TabIndex = 5;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(486, 31);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(123, 17);
            this.lblBakiye.TabIndex = 6;
            this.lblBakiye.Text = "Toplam Bakiyeniz:";
            // 
            // lblKalanBakiye
            // 
            this.lblKalanBakiye.AutoSize = true;
            this.lblKalanBakiye.Location = new System.Drawing.Point(486, 88);
            this.lblKalanBakiye.Name = "lblKalanBakiye";
            this.lblKalanBakiye.Size = new System.Drawing.Size(112, 17);
            this.lblKalanBakiye.TabIndex = 8;
            this.lblKalanBakiye.Text = "Kalan Bakiyeniz:";
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.Color.LightGreen;
            this.btnTamamla.Location = new System.Drawing.Point(489, 192);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(252, 44);
            this.btnTamamla.TabIndex = 10;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(641, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Almak istediğiniz ürün tutarı:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(294, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(641, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // Borsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(776, 269);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.lblKalanBakiye);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.cbxSaticiId);
            this.Controls.Add(this.lblSaticiId);
            this.Controls.Add(this.cbxUrun);
            this.Controls.Add(this.lblUrun);
            this.Name = "Borsa";
            this.Text = "Borsa";
            this.Load += new System.EventHandler(this.Borsa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.ComboBox cbxUrun;
        private System.Windows.Forms.Label lblSaticiId;
        private System.Windows.Forms.ComboBox cbxSaticiId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblKalanBakiye;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
    }
}