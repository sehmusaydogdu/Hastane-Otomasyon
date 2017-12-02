using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HastaneOtomasyon
{
    public partial class Hastalar : Form
    {
        public Hastalar()
        {
            InitializeComponent();
        }

        DataTable tablo = new DataTable();

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void kayitlariGoster()
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from HastalarListesi", App_Data.Tools.Baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource =tablo;
        }

        private void Hastalar_Load(object sender, EventArgs e)
        {
            kayitlariGoster();
        }

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            Form hastaEkle = new HastaEkle();
            hastaEkle.Show();
            this.Hide();
        }

        private void btnHastalar_Click(object sender, EventArgs e)
        {
            kayitlariGoster();
            MessageBox.Show("Liste Yenilendi.");
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            Form anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ?", "Çıkış", MessageBoxButtons.OKCancel, MessageBoxIcon.Information))
                Application.Exit();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Form hastaGuncelleme = new HastaGuncelleme();
            hastaGuncelleme.Show();
            this.Hide();
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11)
            {
                tablo.Clear();
                SqlCommand com = 
                new SqlCommand("select TcKimlikNo [Tc Kimlik Numarası],Hasta_adi[Hasta Adı], Hasta_soyadi[Hasta Soyadı], Hasta_dtarihi[Doğum Tarihi],Telefon[Telefon Numarası] from Hastalar Where TcKimlikNo= '" + textBox1.Text.ToString() + "' ", App_Data.Tools.Baglanti);
                SqlDataAdapter arama = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                arama.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox1.Text = "TcKimlikNo";
            }
            else
                MessageBox.Show("Aradığınız Kayıt Bulunamadı !!! ");

        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 11)
            {
                SqlCommand komut = new SqlCommand("Update Hastalar Set Durumu=0 Where TcKimlikNo='" + textBox2.Text + "'", App_Data.Tools.Baglanti);
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                kayitlariGoster();

            }
            else
                MessageBox.Show("Alanları Kontrol Ediniz !!!");
        }
    }
}
