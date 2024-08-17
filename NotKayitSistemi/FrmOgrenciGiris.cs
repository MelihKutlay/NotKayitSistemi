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
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=NotKayitVeriTabani;Integrated Security=True");
        private void btngirisyap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand numaragir = new SqlCommand("select * from tbl_ders where OGRENCINUMARA=@p1", baglanti);
            numaragir.Parameters.AddWithValue("@p1", msknumara.Text);
            SqlDataReader oku = numaragir.ExecuteReader();
            if (oku.Read())
            {
                FrmOgrenciDetay giris = new FrmOgrenciDetay();
                giris.numara = msknumara.Text;
                giris.Show();
            }
            else
            {
                MessageBox.Show("BU NUMARAYA AİT ÖĞRENCİ KAYDI BULUNAMADI", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmGırısler gırısler = new FrmGırısler();
            gırısler.Show();
            this.Close();
        }
    }
}
