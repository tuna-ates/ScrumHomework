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
    public partial class Borsa : Form
    {
        public static string goData = "";
        public static string goData2 = "";
        public Borsa()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");

        private void txtBakiye_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Borsa_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command2 = new SqlCommand("select DISTINCT item_name from items",connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cbxUrun.Items.Add(reader2["item_name"]);

            }
            connection.Close();

          
            
            connection.Open();

            //SqlCommand command = new SqlCommand("select * from user_items", connection);
            SqlCommand command = new SqlCommand("select DISTINCT U.user_id from user_items U,moneys M where U.user_id = M.user_id", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxSaticiId.Items.Add(reader["user_id"]);

            }
            connection.Close();
            
            textBox1.Text = Alici.goingData3.ToString();


        }
        private void btnTamamla_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from user_items where user_id like '"+cbxSaticiId.Text+"'",connection);
            if (cbxSaticiId.Text == "")
            {
                MessageBox.Show("Hata");
            }

            //toplamBakiye - (saticinin belirlediği fiyat * kg) = kalan bakiye
            //SqlCommand cmd8 = new SqlCommand("Select money_amount from moneys where user_id= '" + int.Parse(textBox1.Text) + "'", connection);
            //SqlDataReader srd = cmd8.ExecuteReader();
            //while (srd.Read())
            //{
            //    textBox2.Text = srd.GetValue(0).ToString();

            //}
             


            int a = Convert.ToInt32(textBox3.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int c;
           

            c = b - a;
            textBox2.Text = c.ToString();
            goData = textBox2.Text;

            goData2 = a.ToString();

            /*
            string sorgu5 = "INSERT INTO moneys (user_id,money_amount) VALUES (@user_id,@money_amount)";
            SqlCommand cmd5 = new SqlCommand(sorgu5, connection);
            cmd5.Parameters.AddWithValue("@money_amount",textBox2.Text);
            cmd5.Parameters.AddWithValue("@user_id",txtUserId.Text);
            cmd5.ExecuteNonQuery();

            string sorgu6 = "INSERT INTO moneys (user_id,money_amount) VALUES (@user_id,@money_amount)";
            SqlCommand cmd6 = new SqlCommand(sorgu6, connection);
            cmd6.Parameters.AddWithValue("@money_amount", textBox3.Text);
            cmd6.Parameters.AddWithValue("@user_id",cbxSaticiId.Text);
            cmd6.ExecuteNonQuery();
            */

            string sorgu5 = "UPDATE moneys SET user_id=@user_id,money_amount=@money_amount where user_id=@user_id";
            SqlCommand cmd5 = new SqlCommand(sorgu5, connection);
            cmd5.Parameters.AddWithValue("@money_amount", textBox2.Text);
            cmd5.Parameters.AddWithValue("@user_id", txtUserId.Text);
            cmd5.ExecuteNonQuery();
            


            Sonuc sonuc = new Sonuc();
            sonuc.ShowDialog();

            connection.Close();

        }


        private void cbxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*
            connection.Open();
            cbxSaticiId.Items.Clear();
            cbxSaticiId.Text = "";
          

            SqlCommand command3 = new SqlCommand("Select * from user_items where user_id=@p1",connection);
            command3.Parameters.AddWithValue("@p1",cbxUrun.SelectedIndex + 1);
            SqlDataReader dr = command3.ExecuteReader();
            while (dr.Read())
            {
                cbxSaticiId.Items.Add(dr[2]);
            }
            connection.Close();
            */


            /*
            connection.Open();

            if (cbxUrun.SelectedIndex != -1)
            {

                SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select * from user_items where item_id=" + cbxUrun.SelectedValue, connection);
                cbxSaticiId.ValueMember = "item_id";
                cbxSaticiId.DisplayMember = "user_id";

            }
            connection.Close();
            */


            /*
            SqlCommand cmd = new SqlCommand("Select * from user_items where user_id='" + cbxSaticiId.Text + "'", connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                 string urun = (string)dr["item_id"].ToString();
                 textBox1.Text = urun;

            }

            connection.Close();
            */


            SqlCommand cmd2 = new SqlCommand("Select * from moneys where user_id='" + cbxSaticiId.Text + "'", connection);
            connection.Open();
            cmd2.ExecuteNonQuery();
            SqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string price = (string)dr2["money_amount"].ToString();
                textBox3.Text = price;

            }
            connection.Close();










        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void cbxSaticiId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
















        }
    }
}
