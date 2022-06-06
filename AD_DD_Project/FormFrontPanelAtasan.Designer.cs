namespace AD_DD_Project
{
    partial class FormFrontPanelAtasan
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
            this.SuspendLayout();
            // 
            // btnPembelian
            // 
            this.btnPembelian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembelian.Location = new System.Drawing.Point(12, 12);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(222, 319);
            this.btnPembelian.TabIndex = 0;
            this.btnPembelian.Text = "Pembelian";
            this.btnPembelian.Click += new System.EventHandler(this.btnPembelian_Click);
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.Location = new System.Drawing.Point(240, 12);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(222, 319);
            this.btnPenjualan.TabIndex = 1;
            this.btnPenjualan.Text = "Penjualan";
            this.btnPenjualan.UseVisualStyleBackColor = true;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btnDataBaru
            // 
            this.btnDataBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataBaru.Location = new System.Drawing.Point(468, 12);
            this.btnDataBaru.Name = "btnDataBaru";
            this.btnDataBaru.Size = new System.Drawing.Size(222, 319);
            this.btnDataBaru.TabIndex = 2;
            this.btnDataBaru.Text = "Data Baru";
            this.btnDataBaru.UseVisualStyleBackColor = true;
            this.btnDataBaru.Click += new System.EventHandler(this.btnDataBaru_Click);
            // 
            // FormFrontPanelAtasan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 343);
            this.Controls.Add(this.btnDataBaru);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.btnPembelian);
            this.Name = "FormFrontPanelAtasan";
            this.Text = "Wellcome";
            this.Load += new System.EventHandler(this.FormFrontPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPembelian;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnDataBaru;
    }
}

