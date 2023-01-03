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
    public partial class kargo_gonder : Form
    {
        MySqlConnection bag;
        MySqlDataReader drd;
        public kargo_gonder()
        {
            InitializeComponent();
            bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = bag;
            cmd.CommandText = "insert into kargo_gon(teslim_tip,odeme_tip,adres) values('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox1.Text+"')";
            drd = cmd.ExecuteReader();
          
            bag.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tum_sayfalar tum = new tum_sayfalar();
            tum.Show();
            this.Close();
        }
    }
}
