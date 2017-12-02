using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class HastaGuncelleme : Form
    {
        public HastaGuncelleme()
        {
            InitializeComponent();
        }
        private Boolean kontrol()
        {
            Boolean bosluk = (txtAdi.Text != "") && (txtSoyadi.Text != "") && (txtTelefon.Text != "") && (txtDogumTarihi.Text != "");
            Boolean deger =  (txtTelefon.Text.Length == 11) && (txtTelefon.Text != "0XXX-XXX-XX-XX") && (txtDogumTarihi.Text != "yyyy-aa-gg") && (txtDogumTarihi.Text.Length == 10);
            return (bosluk && deger);
        }

        private void text_temizle()/* TextBoxların içini temizler */
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtDogumTarihi.Text = "yyyy-aa-gg";
            txtTcKimlikNo.Clear();
        }



        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form Hastalar = new Hastalar();
            Hastalar.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            text_temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kontrol())
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandType = CommandType.Text;
                komut.Connection = App_Data.Tools.Baglanti;
                komut.CommandText = "Update Hastalar Set Hasta_adi=@adi,Hasta_soyadi=@soyadi,Hasta_dtarihi=@dogumtarihi,Telefon=@telefon Where TcKimlikNo = '" + txtTcKimlikNo.Text + "' and Durumu ='1'";
                komut.Parameters.AddWithValue("@adi", txtAdi.Text.ToUpper().ToString());
                komut.Parameters.AddWithValue("@soyadi", txtSoyadi.Text.ToUpper().ToString());
                komut.Parameters.AddWithValue("@dogumtarihi", txtDogumTarihi.Text.ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.ToString());
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                MessageBox.Show("Kayıt Başarıyla Güncellenmiştir !!! ");
                text_temizle();
            }
            else
                MessageBox.Show("Alanları Kontrol Ediniz !!!");
        }
    }
}

