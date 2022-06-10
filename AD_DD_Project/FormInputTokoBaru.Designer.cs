namespace AD_DD_Project
{
    partial class FormInputTokoBaru
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
            this.dgwDataToko = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.tBoxNoTelp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxIDtokoBaru = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataToko)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDataToko
            // 
            this.dgwDataToko.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDataToko.Location = new System.Drawing.Point(13, 212);
            this.dgwDataToko.Name = "dgwDataToko";
            this.dgwDataToko.Size = new System.Drawing.Size(770, 258);
            this.dgwDataToko.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alamat Baru";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No Telp";
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.Location = new System.Drawing.Point(122, 105);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(661, 20);
            this.tBoxAlamat.TabIndex = 3;
            // 
            // tBoxNoTelp
            // 
            this.tBoxNoTelp.Location = new System.Drawing.Point(122, 131);
            this.tBoxNoTelp.Name = "tBoxNoTelp";
            this.tBoxNoTelp.Size = new System.Drawing.Size(661, 20);
            this.tBoxNoTelp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Toko Baru";
            // 
            // tBoxIDtokoBaru
            // 
            this.tBoxIDtokoBaru.Location = new System.Drawing.Point(122, 75);
            this.tBoxIDtokoBaru.Name = "tBoxIDtokoBaru";
            this.tBoxIDtokoBaru.Size = new System.Drawing.Size(661, 20);
            this.tBoxIDtokoBaru.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Toko Baru";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(708, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 172);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormInputTokoBaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 482);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBoxIDtokoBaru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxNoTelp);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwDataToko);
            this.Name = "FormInputTokoBaru";
            this.Text = "FormInputTokoBaru";
            this.Load += new System.EventHandler(this.FormInputTokoBaru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDataToko)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDataToko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxAlamat;
        private System.Windows.Forms.TextBox tBoxNoTelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxIDtokoBaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}