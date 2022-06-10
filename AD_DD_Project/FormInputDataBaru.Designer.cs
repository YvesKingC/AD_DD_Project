namespace AD_DD_Project
{
    partial class FormInputDataBaru
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
            this.btnPegawai = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnSepatu = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnToko = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPegawai
            // 
            this.btnPegawai.Location = new System.Drawing.Point(47, 176);
            this.btnPegawai.Name = "btnPegawai";
            this.btnPegawai.Size = new System.Drawing.Size(159, 51);
            this.btnPegawai.TabIndex = 0;
            this.btnPegawai.Text = "Pegawai Baru";
            this.btnPegawai.UseVisualStyleBackColor = true;
            this.btnPegawai.Click += new System.EventHandler(this.btnPegawai_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(47, 260);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(159, 51);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "Member Baru";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnSepatu
            // 
            this.btnSepatu.Location = new System.Drawing.Point(239, 176);
            this.btnSepatu.Name = "btnSepatu";
            this.btnSepatu.Size = new System.Drawing.Size(159, 51);
            this.btnSepatu.TabIndex = 2;
            this.btnSepatu.Text = "Sepatu Baru";
            this.btnSepatu.UseVisualStyleBackColor = true;
            this.btnSepatu.Click += new System.EventHandler(this.btnSepatu_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(239, 98);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(159, 51);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Supplier Baru";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnToko
            // 
            this.btnToko.Location = new System.Drawing.Point(47, 98);
            this.btnToko.Name = "btnToko";
            this.btnToko.Size = new System.Drawing.Size(159, 51);
            this.btnToko.TabIndex = 4;
            this.btnToko.Text = "Toko Baru";
            this.btnToko.UseVisualStyleBackColor = true;
            this.btnToko.Click += new System.EventHandler(this.btnToko_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Baru";
            // 
            // btnPromo
            // 
            this.btnPromo.Location = new System.Drawing.Point(239, 260);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.Size = new System.Drawing.Size(159, 51);
            this.btnPromo.TabIndex = 6;
            this.btnPromo.Text = "Promo Diskon Baru";
            this.btnPromo.UseVisualStyleBackColor = true;
            this.btnPromo.Click += new System.EventHandler(this.btnPromo_Click);
            // 
            // FormInputDataBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 356);
            this.Controls.Add(this.btnPromo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnToko);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnSepatu);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnPegawai);
            this.Name = "FormInputDataBaru";
            this.Text = "Pilih Mana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPegawai;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnSepatu;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnToko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPromo;
    }
}