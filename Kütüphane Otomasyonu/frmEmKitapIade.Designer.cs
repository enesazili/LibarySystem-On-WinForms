namespace Kütüphane_Otomasyonu
{
    partial class frmEmKitapIade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridIadeEden = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridIadeEtmeyen = new System.Windows.Forms.DataGridView();
            this.btnIade = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpIade = new System.Windows.Forms.DateTimePicker();
            this.lblIade = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridIadeEden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIadeEtmeyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridIadeEden
            // 
            this.gridIadeEden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIadeEden.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridIadeEden.Location = new System.Drawing.Point(12, 36);
            this.gridIadeEden.MultiSelect = false;
            this.gridIadeEden.Name = "gridIadeEden";
            this.gridIadeEden.ReadOnly = true;
            this.gridIadeEden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIadeEden.ShowEditingIcon = false;
            this.gridIadeEden.Size = new System.Drawing.Size(671, 228);
            this.gridIadeEden.TabIndex = 0;
            this.gridIadeEden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIadeEden_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iade Edenler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(952, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Iade Etmeyenler";
            // 
            // gridIadeEtmeyen
            // 
            this.gridIadeEtmeyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridIadeEtmeyen.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridIadeEtmeyen.Location = new System.Drawing.Point(691, 36);
            this.gridIadeEtmeyen.MultiSelect = false;
            this.gridIadeEtmeyen.Name = "gridIadeEtmeyen";
            this.gridIadeEtmeyen.ReadOnly = true;
            this.gridIadeEtmeyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIadeEtmeyen.ShowEditingIcon = false;
            this.gridIadeEtmeyen.Size = new System.Drawing.Size(671, 228);
            this.gridIadeEtmeyen.TabIndex = 2;
            this.gridIadeEtmeyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIadeEtmeyen_CellClick);
            // 
            // btnIade
            // 
            this.btnIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIade.Location = new System.Drawing.Point(249, 19);
            this.btnIade.Name = "btnIade";
            this.btnIade.Size = new System.Drawing.Size(237, 85);
            this.btnIade.TabIndex = 4;
            this.btnIade.Text = "Iade Et";
            this.btnIade.UseVisualStyleBackColor = true;
            this.btnIade.Click += new System.EventHandler(this.btnIade_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpIade);
            this.groupBox1.Controls.Add(this.btnIade);
            this.groupBox1.Location = new System.Drawing.Point(819, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iade işlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iade Tarihi";
            // 
            // dtpIade
            // 
            this.dtpIade.Location = new System.Drawing.Point(21, 47);
            this.dtpIade.Name = "dtpIade";
            this.dtpIade.Size = new System.Drawing.Size(200, 20);
            this.dtpIade.TabIndex = 5;
            // 
            // lblIade
            // 
            this.lblIade.AutoSize = true;
            this.lblIade.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIade.Location = new System.Drawing.Point(217, 292);
            this.lblIade.Name = "lblIade";
            this.lblIade.Size = new System.Drawing.Size(0, 33);
            this.lblIade.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(21, 270);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(151, 85);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmEmKitapIade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 411);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblIade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridIadeEtmeyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridIadeEden);
            this.Name = "frmEmKitapIade";
            this.Text = "frmEmKitapIade";
            this.Load += new System.EventHandler(this.frmEmKitapIade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridIadeEden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIadeEtmeyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridIadeEden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridIadeEtmeyen;
        private System.Windows.Forms.Button btnIade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpIade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIade;
        private System.Windows.Forms.Button btnSil;
    }
}