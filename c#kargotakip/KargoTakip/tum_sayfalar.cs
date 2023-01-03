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
    public partial class tum_sayfalar : Form
    {
        public tum_sayfalar()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eski_kargo krg = new eski_kargo();
            krg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gonderi_sorgula sor = new gonderi_sorgula();
            sor.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            blgguncelle blg = new blgguncelle();
            blg.Show();
            this.Hide();
        }

        private void tum_sayfalar_Load(object sender, EventArgs e)
        {
            button6.Visible = Settings1.Default.yetki;
            button5.Visible = Settings1.Default.yetki;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminMesaj admnmsj = new AdminMesaj();
            admnmsj.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin admn = new admin();
            admn.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
