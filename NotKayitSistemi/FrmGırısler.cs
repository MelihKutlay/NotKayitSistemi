using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotKayitSistemi
{
    public partial class FrmGırısler : Form
    {
        public FrmGırısler()
        {
            InitializeComponent();
        }

        private void btnogretmengiris_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris ogretmen = new FrmOgretmenGiris();
            ogretmen.Show();
            this.Hide();

        }

        private void btnogrencigiris_Click(object sender, EventArgs e)
        {
           FrmOgrenciGiris ogrenci = new FrmOgrenciGiris();
            ogrenci.Show();
            this.Hide();    
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
