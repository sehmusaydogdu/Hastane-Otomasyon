using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace HastaneOtomasyon
{
    public partial class Doktorlar : Form
    {
        public Doktorlar()
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
            SqlDataAdapter adtr = new SqlDataAdapter("select * from DoktorlarListesi",App_Data.Tools.Baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void Doktorlar_Load(object sender, EventArgs e)
        {
            kayitlariGoster();
        }

        private void btnDoktorlar_Click(object sender, EventArgs e)
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

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            Form doktorguncelle = new DoktorGuncelle();
            doktorguncelle.Show();
            this.Hide();
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Form f = new DoktorEkle();
            this.Hide();
            f.Show();
        }

        private void btnDoktorArama_Click(object sender, EventArgs e)
        {
            try
            {
                tablo.Clear();
                SqlDataAdapter arama = new SqlDataAdapter("Select Doktor_no [DoktorID],Doktor_adi [Doktor Adı],Doktor_soyadi [Doktor Soyadı],Telefon [Telefon Numarası] from Doktorlar Where Doktor_adi= '" + txtDoktorAra.Text.ToUpper().ToString() + "' ", App_Data.Tools.Baglanti);
                DataSet ds = new DataSet();
                arama.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Aradığınız Kayıt Bulunamadı !!! ");
            }

        }

        private void btnDoktorSilme_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Update Doktorlar Set Durumu=0 Where Doktor_no='" + txtDoktorSil.Text + "'", App_Data.Tools.Baglanti);
                komut.Connection.Open();
                komut.ExecuteNonQuery();
                komut.Connection.Close();
                kayitlariGoster();
            }
            catch
            {
                MessageBox.Show("Alanları Kontrol Ediniz !!!");
            }
        }
    }
}
