using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NotKayitSistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti  = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=NotKayitVeriTabani;Integrated Security=True");
        public string numara;
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
           
            lblnumara.Text = numara;

            baglanti.Open();
            SqlCommand bilgigetir = new SqlCommand("Select * From TBL_DERS  Where OGRENCINUMARA=@p1", baglanti);
            bilgigetir.Parameters.AddWithValue("@p1", numara);
            SqlDataReader oku = bilgigetir.ExecuteReader();
            while (oku.Read())
            {
                lbladsoyad.Text = oku[2].ToString() + " " + oku[3].ToString();
                lblsinav1.Text = oku[4].ToString();
                lblsinav2.Text = oku[5].ToString();
                lblsinav3.Text = oku[6].ToString();
                lblortalama.Text = oku[7].ToString();
                lbldurum.Text = oku[8].ToString();
            }
            baglanti.Close();

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris ogrgiris  = new FrmOgrenciGiris();
            ogrgiris.Show();
            this.Close();
        }
    }
}
