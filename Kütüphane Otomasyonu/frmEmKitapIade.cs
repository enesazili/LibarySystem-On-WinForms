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
    public partial class frmEmKitapIade : Form
    {
        public frmEmKitapIade()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        private void frmEmKitapIade_Load(object sender, EventArgs e)
        {
            IadeEdenList();
            IadeEtmetyenList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridView aktifGrid = null;
            if (gridIadeEden.SelectedRows.Count<=0)
            {
                if (gridIadeEtmeyen.SelectedRows.Count<=0)
                {
                    MessageBox.Show("Lütfen Silinecek Bir Üye Seçin");
                    return;
                }
                else
                {
                    aktifGrid = gridIadeEtmeyen;
                }
            }
            else
            {
                if (gridIadeEtmeyen.SelectedRows.Count>0)
                {
                    MessageBox.Show("Lütfen Silinecek Sadece bir üye seçin");
                    return ;
                }
                else
                {
                    aktifGrid=gridIadeEden;
                }
            }
            DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstediğinize Eminmisiniz","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    int emanetId = Convert.ToInt32(aktifGrid.SelectedRows[0].Cells["EmanetID"].Value);
                    using(SqlConnection conn = connStr.connection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Emanetler WHERE EmanetID = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", emanetId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Kayıt Silindi");
                    IadeEdenList();
                    IadeEtmetyenList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: "+ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (gridIadeEtmeyen.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen Bir Kayır Seçin");
                return;
            }
            try
            {
                int emanetId = Convert.ToInt32(gridIadeEtmeyen.SelectedRows[0].Cells["EmanetID"].Value);
                DateTime iade = dtpIade.Value;
                using (SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    SqlTransaction trans = conn.BeginTransaction();
                    string guncelleQuery = "UPDATE Emanetler SET IadeTarihi = @tarih WHERE EmanetID = @id";
                    SqlCommand cmd = new SqlCommand(guncelleQuery, conn, trans);
                    cmd.Parameters.AddWithValue("@id", emanetId);
                    cmd.Parameters.AddWithValue("@tarih", iade);
                    cmd.ExecuteNonQuery();
                    string kitapId = gridIadeEtmeyen.SelectedRows[0].Cells["KitapID"].Value.ToString();
                    SqlCommand stokcmd = new SqlCommand("UPDATE Kitaplar SET StokSayisi = StokSayisi +1 WHERE KitapID = @kitapid",conn, trans);
                    stokcmd.Parameters.AddWithValue("@kitapid",kitapId);
                    stokcmd.ExecuteNonQuery();
                    trans.Commit();
                    MessageBox.Show("işlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IadeEdenList();
                    IadeEtmetyenList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata "+ ex.Message,"hata",MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
        private void IadeEdenList()
        {
            try
            {
                using(SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            E.EmanetID,
                            K.AdSoyad AS Kullanici,
                            KT.KitapAdi,
                            E.AlisTarihi,
                            E.TahminiIadeTarihi,
                            E.IadeTarihi
                        FROM Emanetler E
                        JOIN Kullanicilar K ON E.KullaniciID = K.KullaniciID
                        JOIN Kitaplar KT ON E.KitapID = KT.KitapID
                        WHERE E.IadeTarihi IS NOT NULL";
                    SqlDataAdapter da = new SqlDataAdapter(query,conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridIadeEden.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata "+ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void IadeEtmetyenList()
        {
            try
            {
                using (SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    E.EmanetID,
                    K.AdSoyad AS Kullanici,
                    KT.KitapAdi,  -- Kitap Adı
                    E.AlisTarihi,
                    E.TahminiIadeTarihi,
                    E.KitapID  -- KitapID'yi de ekleyin
                FROM Emanetler E
                JOIN Kullanicilar K ON E.KullaniciID = K.KullaniciID
                JOIN Kitaplar KT ON E.KitapID = KT.KitapID
                WHERE E.IadeTarihi IS NULL";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridIadeEtmeyen.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridIadeEtmeyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridIadeEtmeyen.Rows[e.RowIndex];

                DateTime tahminiIadeTarihi = Convert.ToDateTime(row.Cells["TahminiIadeTarihi"].Value);
                DateTime verilisTarihi = Convert.ToDateTime(row.Cells["AlisTarihi"].Value);

                if (DateTime.Now > tahminiIadeTarihi)
                {
                    lblIade.Text = "Geç Kalınmış!";
                    lblIade.ForeColor = Color.Red;
                }
                else
                {
                    lblIade.Text = "Zamanında İade Edilebilir.";
                    lblIade.ForeColor = Color.Green;
                }
            }
        }

        private void gridIadeEden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridIadeEden.Rows[e.RowIndex];

                DateTime tahminiIadeTarihi = Convert.ToDateTime(row.Cells["TahminiIadeTarihi"].Value);
                DateTime gercekIadeTarihi = Convert.ToDateTime(row.Cells["IadeTarihi"].Value);

                if (gercekIadeTarihi != DateTime.MinValue)
                {
                    if (gercekIadeTarihi > tahminiIadeTarihi)
                    {
                        lblIade.Text = "Geç Kalınmış!";
                        lblIade.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblIade.Text = "Zamanında İade Edilmiş!";
                        lblIade.ForeColor = Color.Green;
                    }
                }
                else
                {
                    lblIade.Text = "Kitap Henüz İade Edilmemiş!";
                    lblIade.ForeColor = Color.Orange;
                }
            }
        }
    }
}
