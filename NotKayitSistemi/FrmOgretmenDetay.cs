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

namespace NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=NotKayitVeriTabani;Integrated Security=True");

        public void listele()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_ders", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }
        public void gecenkalansayisi()
        {
            baglanti.Open();
            SqlCommand gecen = new SqlCommand("select count(durum) from tbl_ders where durum='GEÇTİ' GROUP BY DURUM", baglanti);
            SqlDataReader oku = gecen.ExecuteReader();
            while (oku.Read())
            {
                lblgecenogrencisayisi.Text = oku[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand kalan = new SqlCommand("select count(durum) from tbl_ders where durum='KALDI' GROUP BY DURUM", baglanti);
            SqlDataReader oku2 = kalan.ExecuteReader();
            while (oku2.Read())
            {
                lblkalanogrencisayisi.Text = oku2[0].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand toplamsayi = new SqlCommand("select count(*) from tbl_ders", baglanti);
            SqlDataReader oku3 = toplamsayi.ExecuteReader();
            while(oku3.Read())
            {
                lblogrencisayisi.Text =oku3[0].ToString();
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into tbl_ders (OGRENCINUMARA,OGRENCIAD,OGRENCISOYAD) VALUES (@P1,@P2,@P3)", baglanti);
            ekle.Parameters.AddWithValue("@P1", msknumara.Text);
            ekle.Parameters.AddWithValue("@P2", txtad.Text);
            ekle.Parameters.AddWithValue("@p3", txtsoyad.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ ÖĞRENCİ KAYDI BAŞARILI BİR ŞEKİLDE GERÇEKLEŞMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            gecenkalansayisi();
        }
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            gecenkalansayisi();
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            msknumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msksinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msksinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            msksinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            lblsınıfortalama.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            lbldurum.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            gecenkalansayisi();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update tbl_ders set OGRENCINUMARA=@p1,OGRENCIAD=@p2,OGRENCISOYAD=@p3 where OGRENCIID=@P4", baglanti);
            guncelle.Parameters.AddWithValue("@p1", msknumara.Text);
            guncelle.Parameters.AddWithValue("@p2", txtad.Text);
            guncelle.Parameters.AddWithValue("@p3", txtsoyad.Text);
            guncelle.Parameters.AddWithValue("@p4", txtid.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE GÜNCELLENMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            gecenkalansayisi();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from tbl_ders where OGRENCIID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", txtid.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            gecenkalansayisi();
        }

        private void btnnotgiris_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ortalama;
            s1 = Convert.ToInt32(msksinav1.Text);
            s2 = Convert.ToInt32(msksinav2.Text);
            s3 = Convert.ToInt32(msksinav3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblsınıfortalama.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                lbldurum.Text = "GEÇTİ";
            }
            else
            {
                lbldurum.Text = "KALDI";
            }

            baglanti.Open();
            SqlCommand notgir = new SqlCommand("Update Tbl_Ders set OGRENCISINAV1=@p1,OGRENCISINAV2=@p2,OGRENCISINAV3=@p3,ORTALAMA=@p4,DURUM=@p5 where OGRENCIID=@p6", baglanti);
            notgir.Parameters.AddWithValue("@p1", msksinav1.Text);
            notgir.Parameters.AddWithValue("@p2", msksinav2.Text);
            notgir.Parameters.AddWithValue("@p3", msksinav3.Text);
            notgir.Parameters.AddWithValue("@p4", decimal.Parse(lblsınıfortalama.Text));
            notgir.Parameters.AddWithValue("@p5", lbldurum.Text);
            notgir.Parameters.AddWithValue("@p6", txtid.Text);
            notgir.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("NOT GİRİŞ İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            gecenkalansayisi();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            msknumara.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
            msksinav1.Text = "";
            msksinav2.Text = "";
            msksinav3.Text = "";
            lblsınıfortalama.Text = "";
            lblgecenogrencisayisi.Text = "";
            lblkalanogrencisayisi.Text = "";
            lbldurum.Text = "";
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris giris = new FrmOgretmenGiris();
            giris.Show();
            this.Close();
        }
    }
}
