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
    public partial class frmEmKitapList : Form
    {
        public frmEmKitapList()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        int secili = -1;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secili == -1)
            {
                MessageBox.Show("Bir Kayır Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    string query = "UPDATE Emanetler SET AlisTarihi = @ver, TahminiIadeTarihi = @al WHERE EmanetID = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ver", dtpVerilis.Value);
                    cmd.Parameters.AddWithValue("@al", dtpIade.Value);
                    cmd.Parameters.AddWithValue("@id", secili);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Emanet Bilgileri Güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmanetListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: "+ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secili == -1)
            {
                MessageBox.Show("Bir Kayır Seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyormusunuz", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = connStr.connection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Emanetler WHERE EmanetID = @id";
                        SqlCommand komut = new SqlCommand(query, conn);
                        komut.Parameters.AddWithValue("@id", secili);
                        komut.ExecuteNonQuery();
                    }
                    MessageBox.Show("Emanet Bilgileri Silindi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    secili = -1;
                    EmanetListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: "+ ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("İşlem İptal Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EmanetListele()
        {
            try
            {
                using(SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    string query = @"SELECT 
                            E.EmanetID, 
                            K.AdSoyad AS Kullanici, 
                            KT.KitapAdi AS Kitap, 
                            E.AlisTarihi, 
                            E.TahminiIadeTarihi,
                            E.IadeTarihi
                         FROM Emanetler E
                         JOIN Kullanicilar K ON E.KullaniciID = K.KullaniciID
                         JOIN Kitaplar KT ON E.KitapID = KT.KitapID";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);
                    gridEmanet.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: "+ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmEmKitapList_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void gridEmanet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = gridEmanet.Rows[e.RowIndex];
                    secili = Convert.ToInt32(row.Cells["EmanetID"].Value);
                    dtpVerilis.Value = Convert.ToDateTime(row.Cells["AlisTarihi"].Value);
                    dtpIade.Value = Convert.ToDateTime(row.Cells["TahminiIadeTarihi"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
