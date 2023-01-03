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
            bag = new MySqlConnection("Server=localhost;Database=musteriler;Uid=root;Pwd='';");
            
        MySqlDataReader drd;
        }

        public void veri(string veri)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(veri, bag);
            DataSet grid = new DataSet();
            da.Fill(grid);

            dataGridView1.DataSource = grid.Tables[0];
        }

        private void AdminMusteriListe_Load(object sender, EventArgs e)
        {
           
            veri("Select * FROM bilgiler");
            
            





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
