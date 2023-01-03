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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KargoTakip
{
    public partial class AdminMesaj : Form
    {
        MySqlConnection bag;
        MySqlDataReader drd;
        public AdminMesaj()
        {
            InitializeComponent();
            bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            bag.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = "insert into admin_mesaj (konu,mesaj) values('" + textBox1.Text + "','" + richTextBox1.Text + "')";
            cmd.ExecuteNonQuery();
            bag.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin dns = new admin();
            dns.Show();
            this.Close();
        }
    }
}
