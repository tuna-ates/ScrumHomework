using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Odev
{
    public partial class Admin2 : Form
    {
        public Admin2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");
    

        private void Admin2_Load(object sender, EventArgs e)
        {

            txtFiyat.Text = Alici.goingData3.ToString();
            txtUserId.Text = Alici.goingData4.ToString();

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (cbxOnay.Text == "Evet")
            {
                string sorgu = "INSERT INTO moneys(money_amount,user_id) VALUES(@money_amount,@user_id)";
                SqlCommand command = new SqlCommand(sorgu, connection);
                
                command.Parameters.AddWithValue("@money_amount",txtFiyat.Text);
                command.Parameters.AddWithValue("@user_id",txtUserId.Text);
                connection.Open();
                command.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show("Bakiye ekleme işleminiz tamamlanmıştır.");
                Borsa borsa = new Borsa();
                borsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bakiye ekleme işlemi tamamlanamadı.");
            }
        }
    }
}
