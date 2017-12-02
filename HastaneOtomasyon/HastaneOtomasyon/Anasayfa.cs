using System;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Çıkış yapmak ister misin ? */
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }


        private void btnHastalar_Click(object sender, EventArgs e)
        {
            Form hasta = new Hastalar();  /*Hastalar sayfasına gider*/
            hasta.Show();  /* Hastalar fomu Gösteriliyor */
            this.Hide();   /* Formu gizliyor */
        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
        {
            Form doktorlar = new Doktorlar();
            doktorlar.Show();
            this.Hide();
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            Form muayene = new Muayeneler();
            muayene.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            /* Çıkış yapmak ister misin ? */
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }
    }
}
