using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip
{
    internal class baglantilar
    {
       public MySqlConnection bag = new MySqlConnection("Server=localhost;Database=beyzabp;Uid=root;Pwd='';");
        MySqlDataReader drd;
        public void formlar()
        {
            eski_kargo eskkrg = new eski_kargo();
            gonderi_sorgula sor = new gonderi_sorgula();
            gonderi_blg blg = new gonderi_blg();
            kargo_gonder gonder = new kargo_gonder();
        }
        public string a, b, c;
        public void kargoaraclari()
        {
            bag.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = bag;
            cmd.CommandText = "select * from kargo_arac where id=1";
            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                 a= drd["arac_sayi"].ToString();
                 b= drd["sofor_isim"].ToString();
                 c= drd["guzergah"].ToString();
            }
            bag.Close();
        }


    }
}
