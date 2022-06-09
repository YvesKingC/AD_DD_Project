namespace AD_DD_Project
{
    partial class FormHistoryPembelian
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
            this.dgwHistoryPembelian = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoryPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwHistoryPembelian
            // 
            this.dgwHistoryPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHistoryPembelian.Location = new System.Drawing.Point(13, 13);
            this.dgwHistoryPembelian.Name = "dgwHistoryPembelian";
            this.dgwHistoryPembelian.Size = new System.Drawing.Size(1116, 372);
            this.dgwHistoryPembelian.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 402);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 36);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormHistoryPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwHistoryPembelian);
            this.Name = "FormHistoryPembelian";
            this.Text = "FormHistoryPembelian";
            this.Load += new System.EventHandler(this.FormHistoryPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHistoryPembelian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHistoryPembelian;
        private System.Windows.Forms.Button btnBack;
    }
}