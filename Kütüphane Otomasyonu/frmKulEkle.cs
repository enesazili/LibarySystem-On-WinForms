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
    public partial class frmKulEkle : Form
    {
        public frmKulEkle()
        {
            InitializeComponent();
        }
        connStr connStr = new connStr();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection connString = connStr.connection())
                {
                    connString.Open();
                    string query = "INSERT INTO Kullanicilar (AdSoyad, Yas, TCKimlikNo, Cinsiyet, Telefon, Adres, Eposta,KitapSayisi) VALUES (@as,@yas,@tc,@cinsiyet,@tel,@adres,@eposta,@kitapsayi)";
                    SqlCommand komut = new SqlCommand(query, connString);
                    komut.Parameters.AddWithValue("@as",txtAdSoyad.Text);
                    komut.Parameters.AddWithValue("@yas",numYas.Value);
                    komut.Parameters.AddWithValue("@tc",txtTcNo.Text);
                    komut.Parameters.AddWithValue("@cinsiyet",cmbCinsiyet.SelectedItem?.ToString());
                    komut.Parameters.AddWithValue("@tel",txtTelNo.Text);
                    komut.Parameters.AddWithValue("@adres",txtAdres.Text);
                    komut.Parameters.AddWithValue("@eposta",txtEmail.Text);
                    komut.Parameters.AddWithValue("@kitapsayi",numKitapSayi.Value);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Başarıyla Kaydedilid","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata: "+ ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
