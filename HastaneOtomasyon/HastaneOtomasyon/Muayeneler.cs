using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class Muayeneler : Form
    {
        public Muayeneler()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();
        private void kayitlariGoster()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from MuayeneListesi", App_Data.Tools.Baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void Muayeneler_Load(object sender, EventArgs e)
        {
            kayitlariGoster();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }
        private Boolean kontrol()
        {
            Boolean bosluk = (txtDoktorId.Text != "") && (tcKimlikNo.Text != "");
            Boolean deger = (tcKimlikNo.Text.Length == 11);
            return (bosluk && deger);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Muayene Set Durumu=0 Where TcKimlikNo='" + txtKayitSil.Text + "'", App_Data.Tools.Baglanti);
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                kayitlariGoster();
                txtKayitSil.Text = "TcKimlikNo";
            }
            catch
            {
                MessageBox.Show("Alanları Kontrol Ediniz !!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("Select TcKimlikNo,Doktor_no,Muayene_tarihi,Teshis from Muayene Where Durumu=1 and Muayene_tarihi Between "+Convert.ToDateTime(textBox6.Text)+" and "+Convert.ToDateTime(textBox3.Text)+" ", bag);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;*/
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnElemanSayısı_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlCommand com = new SqlCommand("Select Count(Doktor_ID) [Muayenedeki Kisi Sayısı] from Muayene Where Durumu=1  ", App_Data.Tools.Baglanti);
            SqlDataAdapter arama = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            arama.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            kayitlariGoster();
            MessageBox.Show("Liste Yenilendi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (kontrol())
            {
                SqlCommand komut = new SqlCommand();
                komut.Connection = App_Data.Tools.Baglanti;
                komut.CommandType = CommandType.Text;
                komut.CommandText = "Update Muayene Set Doktor_ID=@doktorId,Teshis=@teshis Where TcKimlikNo = '" + tcKimlikNo.Text + "' and Durumu ='1'";
                komut.Parameters.AddWithValue("@doktorId", Convert.ToInt32(txtDoktorId.Text));
                komut.Parameters.AddWithValue("@teshis", txtTeshis.Text.ToUpper().ToString());
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                kayitlariGoster();
                MessageBox.Show("Kayıt Başarıyla Güncellenmiştir !!! ");

            }
            else
                MessageBox.Show("Alanları Kontrol Ediniz !!!");
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            try
            {
                tablo.Clear();
                SqlCommand com = 
                new SqlCommand("select TcKimlikNo [Tc Kimlik Numarası],Hasta_adi [Hasta Adı],Hasta_Soyadi [Hasta Soyadı],Hasta_dtarihi [Doğum Tarihi],Telefon,Doktor_No [Tedavi Eden Doktor No],Teshis[Teşhis] from Hastalar Where TcKimlikNo= '" + textBox1.Text.ToString() + "' and Durumu='1' ", App_Data.Tools.Baglanti);
                SqlDataAdapter arama = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                arama.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox1.Text = "TcKimlikNo";
            }
            catch
            {
                MessageBox.Show("Aradığınız Kayıt Bulunamadı !!! ");
            }
        }
    }
}
