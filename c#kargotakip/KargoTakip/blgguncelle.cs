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
using System.Xml.Linq;


namespace KargoTakip
{
    public partial class blgguncelle : Form
    {
        MySqlConnection bag = new MySqlConnection();
        MySqlDataReader drd;

        public void veri(string veri)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veri, bag);
            DataSet grid = new DataSet();
            da.Fill(grid);

            dataGridView1.DataSource = grid.Tables[0];
        }
        public blgguncelle()
        {
            InitializeComponent();
            bag = new MySqlConnection("Server=localhost;Database=musteriler;Uid=root;Pwd='';");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void blgguncelle_Load(object sender, EventArgs e)
        {
            veri("Select * FROM bilgiler");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //bosalan
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bag.Open();
            MySqlCommand komut = new MySqlCommand("UPDATE bilgiler set AdSoyadi='" +textBox2.Text+"',Telefon='"+ textBox3.Text+"',sehir='"+textBox4.Text+"' where MusteriNo='"+ textBox1.Text+"'",bag);
            komut.ExecuteNonQuery();
            veri("Select * FROM bilgiler");
            bag.Close();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tum_sayfalar tum = new tum_sayfalar();
            tum.Show();
            this.Close();
        }
    }
}
