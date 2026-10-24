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
    public partial class frmKitapList : Form
    {
        public frmKitapList()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridKitaplar.SelectedRows.Count > 0)
            {
                try
                {
                    int kitapID = Convert.ToInt32(gridKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                    using (SqlConnection conn = connStr.connection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Kitaplar WHERE KitapID = @kitapID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@kitapID", kitapID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kitap başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KitapListe();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (gridKitaplar.SelectedRows.Count > 0)
            {
                try
                {
                    int kitapID = Convert.ToInt32(gridKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                    using (SqlConnection conn = connStr.connection())
                    {
                        conn.Open();
                        string query = "UPDATE Kitaplar SET KitapAdi = @adi, Yazar = @yazar, SayfaSayisi = @sayfa, StokSayisi = @stok WHERE KitapID = @kitapID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@adi", txtKitapAd.Text);
                        cmd.Parameters.AddWithValue("@yazar", txtKitapYazar.Text);
                        cmd.Parameters.AddWithValue("@sayfa", numSayfaSayi.Value);
                        cmd.Parameters.AddWithValue("@stok", numStok.Value);
                        cmd.Parameters.AddWithValue("@kitapID", kitapID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kitap başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KitapListe();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için bir kitap seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void KitapListe()
        {
            try
            {
                using(SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Kitaplar";
                    SqlDataAdapter da = new SqlDataAdapter(query,conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridKitaplar.DataSource = dt;
                    gridKitaplar.Columns["KitapID"].HeaderText = "ID";
                    gridKitaplar.Columns["KitapAdi"].HeaderText = "Kitap Adı";
                    gridKitaplar.Columns["Yazar"].HeaderText = "Yazar";
                    gridKitaplar.Columns["SayfaSayisi"].HeaderText = "Sayfa";
                    gridKitaplar.Columns["StokSayisi"].HeaderText = "Stok";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmKitapList_Load(object sender, EventArgs e)
        {
            KitapListe();
        }

        private void gridKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridKitaplar.SelectedRows.Count > 0)
            {
                int kitapID = Convert.ToInt32(gridKitaplar.SelectedRows[0].Cells["KitapID"].Value);
                string kitapAdi = gridKitaplar.SelectedRows[0].Cells["KitapAdi"].Value.ToString();
                string yazar = gridKitaplar.SelectedRows[0].Cells["Yazar"].Value.ToString();
                int sayfaSayisi = Convert.ToInt32(gridKitaplar.SelectedRows[0].Cells["SayfaSayisi"].Value);
                int stokSayisi = Convert.ToInt32(gridKitaplar.SelectedRows[0].Cells["StokSayisi"].Value);
                txtKitapAd.Text = kitapAdi;
                txtKitapYazar.Text = yazar;
                numSayfaSayi.Value = sayfaSayisi;
                numStok.Value = stokSayisi;
            }
        }
    }
}
