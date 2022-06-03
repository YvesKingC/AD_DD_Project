namespace AD_DD_Project
{
    partial class FormFrontPanel
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
            this.btnPembelian = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnDataBaru = new System.Windows.Forms.Button();
            this.cBoxNamaPegawai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPembelian
            // 
            this.btnPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembelian.Location = new System.Drawing.Point(12, 103);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(222, 228);
            this.btnPembelian.TabIndex = 0;
            this.btnPembelian.Text = "Pembelian";
            this.btnPembelian.Click += new System.EventHandler(this.btnPembelian_Click);
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.Location = new System.Drawing.Point(240, 103);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(222, 228);
            this.btnPenjualan.TabIndex = 1;
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.UseVisualStyleBackColor = true;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btnDataBaru
            // 
            this.btnDataBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataBaru.Location = new System.Drawing.Point(468, 103);
            this.btnDataBaru.Name = "btnDataBaru";
            this.btnDataBaru.Size = new System.Drawing.Size(222, 228);
            this.btnDataBaru.TabIndex = 2;
            this.btnDataBaru.Text = "Data Baru";
            this.btnDataBaru.UseVisualStyleBackColor = true;
            this.btnDataBaru.Click += new System.EventHandler(this.btnDataBaru_Click);
            // 
            // cBoxNamaPegawai
            // 
            this.cBoxNamaPegawai.FormattingEnabled = true;
            this.cBoxNamaPegawai.Location = new System.Drawing.Point(165, 39);
            this.cBoxNamaPegawai.Name = "cBoxNamaPegawai";
            this.cBoxNamaPegawai.Size = new System.Drawing.Size(529, 21);
            this.cBoxNamaPegawai.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nama Pegawai";
            // 
            // FormFrontPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxNamaPegawai);
            this.Controls.Add(this.btnDataBaru);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.btnPembelian);
            this.Name = "FormFrontPanel";
            this.Text = "Wellcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPembelian;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnDataBaru;
        private System.Windows.Forms.ComboBox cBoxNamaPegawai;
        private System.Windows.Forms.Label label1;
    }
}

