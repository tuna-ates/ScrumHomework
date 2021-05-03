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
    public partial class Satici : Form
    {
        public static string gidenBilgi1 = "";
        public static string gidenBilgi2 = "";
        public static string gidenBilgi3 = "";
        public static string gidenBilgi4 = "";
        public static string gidenBilgi5 = "";

        public Satici()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");
        

        private void Satici_Load(object sender, EventArgs e)
        {
            /*
            connection.Open();
            SqlCommand command4 = new SqlCommand("select * from items",connection);
            SqlDataReader reader = command4.ExecuteReader();
            while (reader.Read())
            {
                cbxItemId.Items.Add(reader["item_id"]);

            }
            connection.Close();

            
            connection.Open();

            command4 = new SqlCommand("select * from user_items where item_id like'" + cbxItemId.Text + "'", connection);
            reader = command4.ExecuteReader();
            while (reader.Read())
            {
                cbxUserId.Text = reader["user_id"].ToString();

            }

            connection.Close();

            
      
            
            */
        }
        private void btnTamamla_Click(object sender, EventArgs e)
        {

            gidenBilgi1 = cbxUrun.Text;
            gidenBilgi2 = txtMiktar.Text;
            gidenBilgi3 = txtFiyat.Text;
            gidenBilgi4 = txtUserId.Text;
            gidenBilgi5 = txtItemId.Text;



            Admin admin = new Admin();
            admin.ShowDialog();


        }

        
    }
}
