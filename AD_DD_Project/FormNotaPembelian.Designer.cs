namespace AD_DD_Project
{
    partial class FormNotaPembelian
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTanggalPembelian = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblHargaSatuan = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.lblPemesan = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota Pembelian";
            // 
            // lblTanggalPembelian
            // 
            this.lblTanggalPembelian.AutoSize = true;
            this.lblTanggalPembelian.Location = new System.Drawing.Point(57, 80);
            this.lblTanggalPembelian.Name = "lblTanggalPembelian";
            this.lblTanggalPembelian.Size = new System.Drawing.Size(52, 13);
            this.lblTanggalPembelian.TabIndex = 1;
            this.lblTanggalPembelian.Text = "Tanggal :";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(58, 108);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(51, 13);
            this.lblSupplier.TabIndex = 2;
            this.lblSupplier.Text = "Supplier :";
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.AutoSize = true;
            this.lblNamaBarang.Location = new System.Drawing.Point(31, 166);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(78, 13);
            this.lblNamaBarang.TabIndex = 3;
            this.lblNamaBarang.Text = "Nama Barang :";
            // 
            // lblHargaSatuan
            // 
            this.lblHargaSatuan.AutoSize = true;
            this.lblHargaSatuan.Location = new System.Drawing.Point(30, 193);
            this.lblHargaSatuan.Name = "lblHargaSatuan";
            this.lblHargaSatuan.Size = new System.Drawing.Size(79, 13);
            this.lblHargaSatuan.TabIndex = 4;
            this.lblHargaSatuan.Text = "Harga Satuan :";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(40, 220);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(69, 13);
            this.lblTotalHarga.TabIndex = 5;
            this.lblTotalHarga.Text = "Total Harga :";
            // 
            // lblPemesan
            // 
            this.lblPemesan.AutoSize = true;
            this.lblPemesan.Location = new System.Drawing.Point(21, 136);
            this.lblPemesan.Name = "lblPemesan";
            this.lblPemesan.Size = new System.Drawing.Size(88, 13);
            this.lblPemesan.TabIndex = 6;
            this.lblPemesan.Text = "Nama Pemesan :";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(34, 280);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(231, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormNotaPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lblPemesan);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.lblHargaSatuan);
            this.Controls.Add(this.lblNamaBarang);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblTanggalPembelian);
            this.Controls.Add(this.label1);
            this.Name = "FormNotaPembelian";
            this.Text = "FormNotaPembelian";
            this.Load += new System.EventHandler(this.FormNotaPembelian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTanggalPembelian;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblHargaSatuan;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Label lblPemesan;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClose;
    }
}