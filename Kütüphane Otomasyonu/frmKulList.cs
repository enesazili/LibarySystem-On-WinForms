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
    public partial class frmKulList : Form
    {
        public frmKulList()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridKullanicilar.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = gridKullanicilar.SelectedRows[0];
                    string tc = row.Cells["TCKimlikNo"].Value.ToString();
                    using(SqlConnection conn = connStr.connection())
                    {
                        string query = "DELETE FROM Kullanicilar WHERE TCKimlikNo = @tc";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@tc",tc);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kullanıcı Başarıyla Silindi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kulList();
                    }
                }
                else
                {
                    MessageBox.Show("Silmek İçin Bir Kullanıcı Seçin", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA: "+ex.Message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = connStr.connection())
                {
                    string query = "UPDATE Kullanicilar SET AdSoyad = @as, Cinsiyet=@cinsiyet, Telefon=@telefon, Adres=@adres, Eposta=@eposta, Yas =@yas , KitapSayisi = @kitapsayi WHERE TCKimlikNo = @tc";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@as",txtAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet",cmbCinsiyet.Text);
                    cmd.Parameters.AddWithValue("@telefon",txtTelNo.Text);
                    cmd.Parameters.AddWithValue("@adres",txtAdres.Text);
                    cmd.Parameters.AddWithValue("@eposta",txtEmail.Text);
                    cmd.Parameters.AddWithValue("@yas",numYas.Value);
                    cmd.Parameters.AddWithValue("@kitapsayi",numKitapSayi.Value);
                    cmd.Parameters.AddWithValue("@tc",txtTcNo.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Bilgileri Güncellendi.","UYARI",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kulList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKulList_Load(object sender, EventArgs e)
        {
            kulList();
        }
        private void kulList()
        {
            try
            {
                using(SqlConnection conn = new connStr().connection())
                {
                    string query = "SELECT * FROM Kullanicilar";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridKullanicilar.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA "+ ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridKullanicilar.Rows[e.RowIndex];
               txtAdSoyad.Text = row.Cells["AdSoyad"].Value.ToString();
               txtTcNo.Text = row.Cells["TCKimlikNo"].Value.ToString();
               cmbCinsiyet.Text = row.Cells["Cinsiyet"].Value.ToString();
               txtTelNo.Text = row.Cells["Telefon"].Value.ToString();
               txtAdres.Text = row.Cells["Adres"].Value.ToString();
               txtEmail.Text = row.Cells["Eposta"].Value.ToString();
               numYas.Value = Convert.ToDecimal(row.Cells["Yas"].Value);
                numKitapSayi.Value = Convert.ToDecimal(row.Cells["KitapSayisi"].Value);
            }
        }
    }
}
