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
    public partial class Alici : Form
    {
      
        public static string goingData3 = "";
        public static string goingData4 = "";
        public Alici()

        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");
        private void btnTamamla_Click(object sender, EventArgs e)
        {

            goingData3 = txtFiyat.Text;
            goingData4 = txtUserId.Text;


            Admin2 admin2 = new Admin2();
            admin2.ShowDialog();

        }
    }
}
