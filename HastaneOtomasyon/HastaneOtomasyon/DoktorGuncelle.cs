using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class DoktorGuncelle : Form
    {
        public DoktorGuncelle()
        {
            InitializeComponent();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void text_temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Text = "0XXXXXXXXXX";
        }


        private Boolean kontrol()
        {
            Boolean bosluk = (txtAdi.Text != "") && (txtSoyadi.Text != "") && (txtTelefon.Text != "")&&(txtID.Text!="");
            Boolean deger = (txtTelefon.Text.Length == 11) && (txtTelefon.Text != "0XXX-XXX-XX-XX");
            return (bosluk && deger);
        }


        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form doktorlar = new Doktorlar();
            doktorlar.Show();
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
                komut.Connection = App_Data.Tools.Baglanti;
                komut.CommandType = CommandType.Text;
                komut.CommandText = "Update Doktorlar Set Doktor_adi=@adi,Doktor_soyadi=@soyadi,Telefon=@telefon Where Doktor_no = '" + txtID.Text + "' and Durumu ='1'";
                komut.Parameters.AddWithValue("@adi", txtAdi.Text.ToUpper().ToString());
                komut.Parameters.AddWithValue("@soyadi", txtSoyadi.Text.ToUpper().ToString());
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.ToString());
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                MessageBox.Show("Kayıt Başarıyla Güncellenmiştir !!! ");
                text_temizle();
            }
            else
                MessageBox.Show("Alanları Kontrol Ediniz.");
        }
    }
}
