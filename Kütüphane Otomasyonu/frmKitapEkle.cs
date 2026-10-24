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
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection conn = connStr.connection())
                {
                    conn.Open();
                    string query = "INSERT INTO Kitaplar (KitapAdi, Yazar, SayfaSayisi, StokSayisi) VALUES (@ad, @yazar, @sayfa, @stok)";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@ad", txtKitapAd.Text);
                    cmd.Parameters.AddWithValue("@yazar", txtKitapYazar.Text);
                    cmd.Parameters.AddWithValue("@sayfa", numSayfaSayi.Value);
                    cmd.Parameters.AddWithValue("@stok", numStok.Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kitap Başarıyla Eklendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtKitapAd.Clear();
                    txtKitapYazar.Clear();
                    numSayfaSayi.Value = 0;
                    numStok.Value = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA: "+ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
