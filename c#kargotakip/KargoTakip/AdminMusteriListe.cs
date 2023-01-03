using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KargoTakip
{
    public partial class AdminMusteriListe : Form
    {

        MySqlConnection bag;
        MySqlDataReader drd;
        
        public AdminMusteriListe()
        {
            InitializeComponent();
            bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        }

        private void AdminMusteriListe_Load(object sender, EventArgs e)
        {
            bag.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = "select * from kullancilar where kadi='"+Settings1.Default.kadi+"'";
           drd = cmd.ExecuteReader();
            
            while (drd.Read())
            {
                label1.Text = drd["Adsoyad"].ToString();
                label2.Text = drd["tc"].ToString();
                label3.Text = drd["dgm"].ToString();

            }
            drd.Close();
            //MySqlCommand cmd1 = new MySqlCommand();
            //cmd1.Connection = bag;
            //cmd1.CommandText = "select * from musteri where id=11 ";
            //rrd = cmd1.ExecuteReader();
            //while (rrd.Read())
            //{
            //    label5.Text = rrd["AdSoyad"].ToString();
            //    label6.Text = rrd["tc"].ToString();
            //    label7.Text = rrd["dgm"].ToString();

            //}

            //bag.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin dns = new admin();
            dns.Show();
            this.Close();
        }
    }
}
