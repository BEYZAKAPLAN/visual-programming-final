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
    public partial class AdminKargoListe : Form
    {
        MySqlConnection bag;
        MySqlDataReader drd;
        baglantilar baglanti = new baglantilar();
        public AdminKargoListe()
        {
            InitializeComponent();
            bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        }

        private void KargoListesi_Load(object sender, EventArgs e)
        {
            baglanti.kargoaraclari();
            //bag.Open();
            //MySqlCommand cmd = new MySqlCommand();

            //cmd.Connection = bag;
            //cmd.CommandText = "select * from kargo_arac where id=1";
            //drd = cmd.ExecuteReader();
            //while (drd.Read())
            //{
            label5.Text = baglanti.a;
            label6.Text = baglanti.b;
            label7.Text = baglanti.c;
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
