namespace AD_DD_Project
{
    partial class FormInputSupplierBaru
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
            this.tBoxIDSupplierBaru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxNoTelp = new System.Windows.Forms.TextBox();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwSupplier = new System.Windows.Forms.DataGridView();
            this.tBoxNamaSupp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxIDSupplierBaru
            // 
            this.tBoxIDSupplierBaru.Location = new System.Drawing.Point(120, 78);
            this.tBoxIDSupplierBaru.Name = "tBoxIDSupplierBaru";
            this.tBoxIDSupplierBaru.Size = new System.Drawing.Size(454, 20);
            this.tBoxIDSupplierBaru.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID Supplier Baru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Supplier Baru";
            // 
            // tBoxNoTelp
            // 
            this.tBoxNoTelp.Location = new System.Drawing.Point(120, 156);
            this.tBoxNoTelp.Name = "tBoxNoTelp";
            this.tBoxNoTelp.Size = new System.Drawing.Size(454, 20);
            this.tBoxNoTelp.TabIndex = 12;
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.Location = new System.Drawing.Point(120, 130);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(454, 20);
            this.tBoxAlamat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "No Telp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Alamat Baru";
            // 
            // dgwSupplier
            // 
            this.dgwSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSupplier.Location = new System.Drawing.Point(12, 221);
            this.dgwSupplier.Name = "dgwSupplier";
            this.dgwSupplier.Size = new System.Drawing.Size(563, 258);
            this.dgwSupplier.TabIndex = 8;
            // 
            // tBoxNamaSupp
            // 
            this.tBoxNamaSupp.Location = new System.Drawing.Point(120, 104);
            this.tBoxNamaSupp.Name = "tBoxNamaSupp";
            this.tBoxNamaSupp.Size = new System.Drawing.Size(454, 20);
            this.tBoxNamaSupp.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nama Supplier Baru";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 192);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(499, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormInputSupplierBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 492);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tBoxNamaSupp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBoxIDSupplierBaru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxNoTelp);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwSupplier);
            this.Name = "FormInputSupplierBaru";
            this.Text = "FormInputSupplierBaru";
            this.Load += new System.EventHandler(this.FormInputSupplierBaru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxIDSupplierBaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxNoTelp;
        private System.Windows.Forms.TextBox tBoxAlamat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwSupplier;
        private System.Windows.Forms.TextBox tBoxNamaSupp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}