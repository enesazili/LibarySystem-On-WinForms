namespace Kütüphane_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKulEkle = new System.Windows.Forms.Button();
            this.btnKulList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEmKitapVerme = new System.Windows.Forms.Button();
            this.btnEmKitapList = new System.Windows.Forms.Button();
            this.btnEmKitapIade = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitapList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKulEkle
            // 
            this.btnKulEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulEkle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.kEkle1;
            this.btnKulEkle.Location = new System.Drawing.Point(6, 42);
            this.btnKulEkle.Name = "btnKulEkle";
            this.btnKulEkle.Size = new System.Drawing.Size(164, 104);
            this.btnKulEkle.TabIndex = 0;
            this.btnKulEkle.Text = "Kullanıcı Ekleme";
            this.btnKulEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKulEkle.UseVisualStyleBackColor = true;
            this.btnKulEkle.Click += new System.EventHandler(this.btnKulEkle_Click);
            // 
            // btnKulList
            // 
            this.btnKulList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKulList.Image = global::Kütüphane_Otomasyonu.Properties.Resources.kList1;
            this.btnKulList.Location = new System.Drawing.Point(185, 42);
            this.btnKulList.Name = "btnKulList";
            this.btnKulList.Size = new System.Drawing.Size(164, 104);
            this.btnKulList.TabIndex = 1;
            this.btnKulList.Text = "Kullanıcı Listeleme";
            this.btnKulList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKulList.UseVisualStyleBackColor = true;
            this.btnKulList.Click += new System.EventHandler(this.btnKulList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKulEkle);
            this.groupBox1.Controls.Add(this.btnKulList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLANICI İŞLEMLERİ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEmKitapIade);
            this.groupBox2.Controls.Add(this.btnEmKitapVerme);
            this.groupBox2.Controls.Add(this.btnEmKitapList);
            this.groupBox2.Location = new System.Drawing.Point(118, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 174);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KİTAP EMANET İŞLEMLERİ";
            // 
            // btnEmKitapVerme
            // 
            this.btnEmKitapVerme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmKitapVerme.Image = global::Kütüphane_Otomasyonu.Properties.Resources.kitapVer1;
            this.btnEmKitapVerme.Location = new System.Drawing.Point(6, 42);
            this.btnEmKitapVerme.Name = "btnEmKitapVerme";
            this.btnEmKitapVerme.Size = new System.Drawing.Size(164, 104);
            this.btnEmKitapVerme.TabIndex = 0;
            this.btnEmKitapVerme.Text = "Emanet Kitap Verme";
            this.btnEmKitapVerme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmKitapVerme.UseVisualStyleBackColor = true;
            this.btnEmKitapVerme.Click += new System.EventHandler(this.btnEmKitapVerme_Click);
            // 
            // btnEmKitapList
            // 
            this.btnEmKitapList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmKitapList.Image = global::Kütüphane_Otomasyonu.Properties.Resources.checklist1;
            this.btnEmKitapList.Location = new System.Drawing.Point(188, 42);
            this.btnEmKitapList.Name = "btnEmKitapList";
            this.btnEmKitapList.Size = new System.Drawing.Size(164, 104);
            this.btnEmKitapList.TabIndex = 1;
            this.btnEmKitapList.Text = "Emanet Kitap Listeleme";
            this.btnEmKitapList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmKitapList.UseVisualStyleBackColor = true;
            this.btnEmKitapList.Click += new System.EventHandler(this.btnEmKitapList_Click);
            // 
            // btnEmKitapIade
            // 
            this.btnEmKitapIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmKitapIade.Image = global::Kütüphane_Otomasyonu.Properties.Resources.exchange1;
            this.btnEmKitapIade.Location = new System.Drawing.Point(369, 42);
            this.btnEmKitapIade.Name = "btnEmKitapIade";
            this.btnEmKitapIade.Size = new System.Drawing.Size(164, 104);
            this.btnEmKitapIade.TabIndex = 2;
            this.btnEmKitapIade.Text = "Emanet Kitap İade";
            this.btnEmKitapIade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmKitapIade.UseVisualStyleBackColor = true;
            this.btnEmKitapIade.Click += new System.EventHandler(this.btnEmKitapIade_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKitapEkle);
            this.groupBox3.Controls.Add(this.btnKitapList);
            this.groupBox3.Location = new System.Drawing.Point(401, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KİTAP İŞLEMLERİ";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.bookadd1;
            this.btnKitapEkle.Location = new System.Drawing.Point(6, 42);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(164, 104);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitapList
            // 
            this.btnKitapList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapList.Image = global::Kütüphane_Otomasyonu.Properties.Resources.library1;
            this.btnKitapList.Location = new System.Drawing.Point(185, 42);
            this.btnKitapList.Name = "btnKitapList";
            this.btnKitapList.Size = new System.Drawing.Size(164, 104);
            this.btnKitapList.TabIndex = 1;
            this.btnKitapList.Text = "Kitap Listeleme";
            this.btnKitapList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapList.UseVisualStyleBackColor = true;
            this.btnKitapList.Click += new System.EventHandler(this.btnKitapList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 384);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKulEkle;
        private System.Windows.Forms.Button btnKulList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEmKitapIade;
        private System.Windows.Forms.Button btnEmKitapVerme;
        private System.Windows.Forms.Button btnEmKitapList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnKitapList;
    }
}

