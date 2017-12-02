using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HastaneOtomasyon
{
    public partial class HastaEkle : Form
    {
        public HastaEkle()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void text_temizle()/* TextBoxların içini temizler */
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtDogumTarihi.Text = "yyyy-aa-gg";
            txtTelefon.Text = "0XXXXXXXXXX";
            txtDoktorId.Clear();
            txtTeshis.Clear();
            txtTcKimlik.Clear();
        }

        //B4 ID olacak şekilde White Box testi uygulandı.
        private Boolean Kontrol()
        {
            Boolean bosluk = (txtAdi.Text != "") && (txtSoyadi.Text != "") && (txtTelefon.Text != "") && (txtDogumTarihi.Text != "") && (txtTcKimlik.Text != "")&&(txtDoktorId.Text !="")&&(txtTeshis.Text != "");
            Boolean deger = (txtTcKimlik.Text.Length == 11) && (txtTelefon.Text.Length == 11) && (txtTelefon.Text != "0XXXXXXXXXX") && (txtDogumTarihi.Text != "yyyy-aa-gg") && (txtDogumTarihi.Text.Length == 10);
            return (bosluk && deger);
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form hastalar = new Hastalar();
            hastalar.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            text_temizle();
        }

        //B4 ID olacak şekilde White Box testi uygulandı.

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Kontrol())
            {
                try
                {
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = App_Data.Tools.Baglanti;
                    komut.CommandType = CommandType.Text;
                    komut.CommandText = "HastaEkle @tckimlikno,@adi,@soyadi,@dogumtarihi,@telefon,@durumu,@doktorId,@teshis";
                    komut.Parameters.AddWithValue("@tckimlikno", txtTcKimlik.Text.ToString());
                    komut.Parameters.AddWithValue("@adi", txtAdi.Text.ToUpper().ToString());
                    komut.Parameters.AddWithValue("@soyadi", txtSoyadi.Text.ToUpper().ToString());
                    komut.Parameters.AddWithValue("@dogumtarihi", txtDogumTarihi.Text.ToString());
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.ToString());
                    komut.Parameters.AddWithValue("@durumu", 1);
                    komut.Parameters.AddWithValue("@doktorId", Convert.ToInt32(txtDoktorId.Text));
                    komut.Parameters.AddWithValue("@teshis", txtTeshis.Text.ToUpper().ToString());
                    komut.Connection.Open();
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();

                    komut.Connection.Open();
                    komut.CommandText = "MuayeneEkle @tckimlikno,@doktorId,@teshis,@durumu";
                    komut.ExecuteNonQuery();
                    komut.Connection.Close();

                    MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi !!! ");
                    text_temizle();
                }
                catch
                {
                    MessageBox.Show("Kayıt Yapılamamaktadır.");
                }   
            }
            else
                MessageBox.Show("Alanları Kontrol Ediniz !!!");
        }

    }
}
