using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class eski_kargo : Form
    {
        MySqlConnection bag;
        MySqlDataReader drd;
        public eski_kargo()
        {
            InitializeComponent();
            bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = "select * from kargo_gon where musteri_isim='" + textBox1.Text + "' ";
            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                label3.Text = drd["teslim_tip"].ToString();
                label4.Text = drd["odeme_tip"].ToString();
                label5.Text = drd["adres"].ToString();

            }
           
            bag.Close();

        }

        private void eski_kargo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tum_sayfalar tum = new tum_sayfalar();
            tum.Show();
            this.Close();
        }
    }
}
