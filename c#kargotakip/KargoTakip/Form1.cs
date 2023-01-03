
using KargoTakip.Properties;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KargoTakip
{
    public partial class Form1 : Form
    {
        string kuladi;
        string kulsifre;


        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader adapter;
        DataTable dt;


        public Form1()
        {
            InitializeComponent();
            
        }



        private static void button3_ClickExtracted()
        {
          
        }
        private void button5_Click(object sender, EventArgs e)
        {
          


        }
        public void kaydet()
        {


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();


            string yetki = "0";
            string kontrolmail = textBox5.Text;
            string kontrolsifre = textBox4.Text;
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
            conn.Open();
            MySqlCommand okuma = new MySqlCommand();
            okuma.Connection = conn;
            okuma.CommandText = "SELECT * FROM kullanicilar WHERE kadi= '" + textBox5.Text + "'";
            MySqlDataReader adapter = okuma.ExecuteReader();
            while (adapter.Read())
            {
                kuladi = adapter["kadi"].ToString();
                kulsifre = adapter["sifre"].ToString();
                yetki = adapter["yetki"].ToString();


            }
            conn.Close();
            if (kuladi == kontrolmail && kulsifre == kontrolsifre)
            {
                if (yetki == "1")
                {
                    Settings1.Default.yetki = true;
                    Settings1.Default.kadi = kuladi;
                    Settings1.Default.Save();

                }
                else
                {
                    Settings1.Default.yetki = false;
                    Settings1.Default.kadi = kuladi;
                    Settings1.Default.Save();

                }
                this.Hide();
                tum_sayfalar syf = new tum_sayfalar();
                syf.label2.Text = kuladi;
                //syf.label3.Text= yetki.ToString();
                syf.Show();


            }
            else
            {
                label5.Visible = true;
                label5.Text = "lütfen üye olunuz!";
            }

 
            Settings1.Default.kadi = textBox5.Text;
            Settings1.Default.sifre = textBox4.Text;
            Settings1.Default.Save();



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Settings1.Default.kadi = textBox5.Text;
            Settings1.Default.sifre = textBox4.Text;
            Settings1.Default.Save();
            textBox4.Text = Settings1.Default.kadi;
            textBox5.Text = Settings1.Default.sifre;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 hava = new Form2();
            hava.Show();
            this.Hide();
        }
    }
}
