using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KargoTakip
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
       

        private void admin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMesaj adminmesaj = new AdminMesaj();
            adminmesaj.ShowDialog();
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
           

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminKargoListe adminKargoListe = new AdminKargoListe();
            adminKargoListe.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminMusteriListe adminMusteriListe = new AdminMusteriListe();
            adminMusteriListe.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_krg_gnc adminkargognc = new admin_krg_gnc();
            adminkargognc.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           


        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tum_sayfalar tum = new tum_sayfalar();
            tum.Show();
            this.Close();
        }
    }
}
