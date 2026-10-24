using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class frmEmKitapVerme : Form
    {
        public frmEmKitapVerme()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        private void KullaniciListeleme()
        {
            using(SqlConnection conn = connStr.connection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT KullaniciID, AdSoyad FROM Kullanicilar";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbKullanici.DataSource = dt;
                    cmbKullanici.ValueMember = "KullaniciID";
                    cmbKullanici.DisplayMember = "AdSoyad";
                }
                catch(Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
        }
        private void KitapListeleme()
        {
            using (SqlConnection conn = connStr.connection())
            {
                conn.Open();
                string query = "SELECT KitapID, KitapAdi FROM Kitaplar WHERE StokSayisi > 0";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbKitap.DataSource = dt;
                cmbKitap.ValueMember = "KitapID";
                cmbKitap.DisplayMember = "KitapAdi";
            }
        }
        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            if (cmbKullanici.SelectedValue != null && cmbKitap.SelectedValue != null)
            {
                int kullaniciId = Convert.ToInt32(cmbKullanici.SelectedValue);
                int kitapId = Convert.ToInt32(cmbKitap.SelectedValue);
                DateTime verilis = dtpVerilis.Value;
                DateTime iade = dtpIade.Value;
                using(SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        SqlCommand emanetKomut = new SqlCommand("INSERT INTO Emanetler (KullaniciID, KitapID, AlisTarihi, TahminiIadeTarihi) VALUES (@kulid, @kitapid, @ver, @al)" ,conn, trans);
                        emanetKomut.Parameters.AddWithValue("@kulid", kullaniciId);
                        emanetKomut.Parameters.AddWithValue("@kitapid", kitapId);
                        emanetKomut.Parameters.AddWithValue("@ver", verilis);
                        emanetKomut.Parameters.AddWithValue("@al", iade);
                        emanetKomut.ExecuteNonQuery();
                        SqlCommand stokKomut = new SqlCommand("UPDATE Kitaplar SET StokSayisi = StokSayisi -1 WHERE KitapID = @kitapid", conn, trans);
                        stokKomut.Parameters.AddWithValue("@kitapid",kitapId);
                        stokKomut.ExecuteNonQuery();
                        trans.Commit();
                        MessageBox.Show("Emanet İşlemi Başarıyla Tamamlandı","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        KitapListeleme();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("HATA : "+ ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Ve Kitap Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmEmKitapVerme_Load(object sender, EventArgs e)
        {
            KullaniciListeleme();
            KitapListeleme();
            dtpVerilis.Value = DateTime.Today;
            dtpIade.Value = DateTime.Today.AddDays(7);
        }
    }
}
