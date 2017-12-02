using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }
        private void text_temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
        }

        //Akanlar boş değilse True dönmesi gerekir
        private Boolean bosluk_kontrol() 
        {
            Boolean bosluk = (txtAdi.Text != "") && (txtSoyadi.Text != "") && (txtTelefon.Text != "");
            return bosluk;
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (bosluk_kontrol()) 
            {

                try
                {
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = App_Data.Tools.Baglanti;
                    komut.CommandType = CommandType.Text;
                    komut.CommandText = "DoktorEkle @doktoradi,@doktorsoyadi,@telefon,@durumu";
                    komut.Parameters.AddWithValue("@doktoradi", txtAdi.Text.ToUpper().ToString());
                    komut.Parameters.AddWithValue("@doktorsoyadi", txtSoyadi.Text.ToUpper().ToString());
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.ToString());
                    komut.Parameters.AddWithValue("@durumu", true);
                    komut.Connection.Open();
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();
                    MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi !!! ");
                    text_temizle();
                }
                catch
                {
                    MessageBox.Show("Alanları Kontrol Ediniz !!!");
                }
            }
            else
                MessageBox.Show("Boş Alanları Doldurunuz!");
        }

        private void btnDoktorlariGetir_Click(object sender, EventArgs e)
        {
            Form doktorlarListele = new Doktorlar();
            doktorlarListele.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            text_temizle();
        }

    }
}
