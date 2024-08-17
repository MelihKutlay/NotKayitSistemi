using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotKayitSistemi
{
    public partial class FrmOgretmenGiris : Form
    {
        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=NotKayitVeriTabani;Integrated Security=True");
        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giris = new SqlCommand("select * from TBL_OGRETMENLER where NUMARA=@p1 and SIFRE =@p2", baglanti);
            giris.Parameters.AddWithValue("@p1",mskogrnumara.Text);
            giris.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader oku = giris.ExecuteReader();
            if (oku.Read())
            {
                FrmOgretmenDetay ogretmendetay = new FrmOgretmenDetay();
                ogretmendetay.Show();
            }
            else
            {
                MessageBox.Show("HATALI NUMARA VEYA ŞİFRE GİRDİNİZ LÜTFEN TEKRAR DENEYİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OgretmenGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmGırısler girisler = new FrmGırısler();
            girisler.Show();
            this.Close();
        }
    }
}
