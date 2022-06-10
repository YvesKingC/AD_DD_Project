namespace AD_DD_Project
{
    partial class FormLoadPembelian
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
            this.cBoxSupplier = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCetak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cBoxIDSepatu = new System.Windows.Forms.ComboBox();
            this.lblHargaSatuan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rBtnLunas = new System.Windows.Forms.RadioButton();
            this.rBtnBelumLunas = new System.Windows.Forms.RadioButton();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Supplier";
            // 
            // cBoxSupplier
            // 
            this.cBoxSupplier.FormattingEnabled = true;
            this.cBoxSupplier.Location = new System.Drawing.Point(148, 88);
            this.cBoxSupplier.Name = "cBoxSupplier";
            this.cBoxSupplier.Size = new System.Drawing.Size(175, 21);
            this.cBoxSupplier.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Harga Pembelian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status Pembelian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pembelian";
            // 
            // btnCetak
            // 
            this.btnCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCetak.Location = new System.Drawing.Point(248, 287);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(75, 36);
            this.btnCetak.TabIndex = 15;
            this.btnCetak.Text = "Cetak";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID Barang Dibeli";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quantity";
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.Location = new System.Drawing.Point(145, 198);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(148, 13);
            this.lblTotalHarga.TabIndex = 31;
            this.lblTotalHarga.Text = ">-------------------------------------------<";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(30, 287);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(148, 142);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(175, 20);
            this.numQuantity.TabIndex = 35;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // cBoxIDSepatu
            // 
            this.cBoxIDSepatu.FormattingEnabled = true;
            this.cBoxIDSepatu.Location = new System.Drawing.Point(148, 115);
            this.cBoxIDSepatu.Name = "cBoxIDSepatu";
            this.cBoxIDSepatu.Size = new System.Drawing.Size(324, 21);
            this.cBoxIDSepatu.TabIndex = 36;
            // 
            // lblHargaSatuan
            // 
            this.lblHargaSatuan.AutoSize = true;
            this.lblHargaSatuan.Location = new System.Drawing.Point(145, 172);
            this.lblHargaSatuan.Name = "lblHargaSatuan";
            this.lblHargaSatuan.Size = new System.Drawing.Size(148, 13);
            this.lblHargaSatuan.TabIndex = 38;
            this.lblHargaSatuan.Text = ">-------------------------------------------<";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Harga Barang";
            // 
            // rBtnLunas
            // 
            this.rBtnLunas.AutoSize = true;
            this.rBtnLunas.Location = new System.Drawing.Point(148, 229);
            this.rBtnLunas.Name = "rBtnLunas";
            this.rBtnLunas.Size = new System.Drawing.Size(54, 17);
            this.rBtnLunas.TabIndex = 39;
            this.rBtnLunas.TabStop = true;
            this.rBtnLunas.Text = "Lunas";
            this.rBtnLunas.UseVisualStyleBackColor = true;
            // 
            // rBtnBelumLunas
            // 
            this.rBtnBelumLunas.AutoSize = true;
            this.rBtnBelumLunas.Location = new System.Drawing.Point(222, 229);
            this.rBtnBelumLunas.Name = "rBtnBelumLunas";
            this.rBtnBelumLunas.Size = new System.Drawing.Size(86, 17);
            this.rBtnBelumLunas.TabIndex = 40;
            this.rBtnBelumLunas.TabStop = true;
            this.rBtnBelumLunas.Text = "Belum Lunas";
            this.rBtnBelumLunas.UseVisualStyleBackColor = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(142, 287);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 36);
            this.btnHistory.TabIndex = 41;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // FormLoadPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 346);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.rBtnBelumLunas);
            this.Controls.Add(this.rBtnLunas);
            this.Controls.Add(this.lblHargaSatuan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBoxIDSepatu);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBoxSupplier);
            this.Controls.Add(this.label1);
            this.Name = "FormLoadPembelian";
            this.Text = "Pembelian";
            this.Load += new System.EventHandler(this.FormLoadPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cBoxIDSepatu;
        private System.Windows.Forms.Label lblHargaSatuan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rBtnLunas;
        private System.Windows.Forms.RadioButton rBtnBelumLunas;
        private System.Windows.Forms.Button btnHistory;
    }
}