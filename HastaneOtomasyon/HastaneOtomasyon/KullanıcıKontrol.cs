using System;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class KullanıcıKontrol : Form
    {
        public KullanıcıKontrol()
        {
            InitializeComponent();
        }

        private short i = 101;

        //B3 ID olacak şekilde White Box testi uygulandı.
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            if (i == 100)
            {
                Form Anasayfa = new Anasayfa();
                Anasayfa.Show();
                this.Hide();
                timer1.Stop();
            }
            else
                i++;

        }

        private void KullanıcıKontrol_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKulAdi.Clear();
            txtSifre.Clear();
        }


        //B2 ID olacak şekilde White Box testi uygulandı.
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text == "Admin" && txtSifre.Text == "12345")
            {
                timer1.Start();
                progressBar1.Visible = true;
            }
            else
            {
                MessageBox.Show("Yanlış Değer Girdiniz . Lütfen Tekrar Deneyiniz !!!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSifre.Clear();
            }
        }
    }
}
