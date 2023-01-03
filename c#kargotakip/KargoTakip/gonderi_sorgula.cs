using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace KargoTakip
{
    public partial class gonderi_sorgula : Form
    {
        gonderi_blg gndr = new gonderi_blg();
        MySqlConnection bag;
        MySqlDataReader drd;

        public gonderi_sorgula()
        {
            InitializeComponent();
           bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bag.Open();
            MySqlCommand cmd = new MySqlCommand();
            
            cmd.Connection = bag;
            cmd.CommandText = "select * from gonderi where gonderi_no='" + textBox1.Text + "' ";
            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                gndr.label3.Text = drd["nerede"].ToString();
                gndr.label4.Text = drd["kim"].ToString();
            }
            gndr.ShowDialog();
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
