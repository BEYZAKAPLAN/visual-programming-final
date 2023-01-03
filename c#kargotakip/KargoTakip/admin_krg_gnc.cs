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
    public partial class admin_krg_gnc : Form
    {
        public MySqlConnection bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        MySqlDataReader drd;
        public admin_krg_gnc()
        {
            InitializeComponent();
        }



        private void button7_Click(object sender, EventArgs e)
        {try
            {
                bag.Open();
                MySqlCommand komut = new MySqlCommand("UPDATE gonderi set kdurum='" + comboBox2.Text + "' where gonderi_no='" + comboBox1.Text + "'", bag);
                komut.ExecuteNonQuery();
                MessageBox.Show("güncellendi"); 
                bag.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("madı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           admin dns = new admin();
            dns.Show();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
