using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKulEkle_Click(object sender, EventArgs e)
        {
            frmKulEkle frmKulEkle = new frmKulEkle();
            frmKulEkle.ShowDialog();
        }

        private void btnKulList_Click(object sender, EventArgs e)
        {
            frmKulList frmKulList = new frmKulList();
            frmKulList.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            frmKitapEkle frmKitapEkle = new frmKitapEkle();
            frmKitapEkle.ShowDialog();
        }

        private void btnKitapList_Click(object sender, EventArgs e)
        {
            frmKitapList frmKitapList = new frmKitapList();
            frmKitapList.ShowDialog();
        }

        private void btnEmKitapVerme_Click(object sender, EventArgs e)
        {
            frmEmKitapVerme frmEmKitapVerme = new frmEmKitapVerme();
            frmEmKitapVerme.ShowDialog();
        }

        private void btnEmKitapList_Click(object sender, EventArgs e)
        {
            frmEmKitapList frmEmKitapList = new frmEmKitapList();
            frmEmKitapList.ShowDialog();
        }

        private void btnEmKitapIade_Click(object sender, EventArgs e)
        {
            frmEmKitapIade frmEmKitapIade = new frmEmKitapIade();
            frmEmKitapIade.ShowDialog();
        }
    }
}
