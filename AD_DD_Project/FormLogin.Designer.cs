namespace AD_DD_Project
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tBoxUID = new System.Windows.Forms.TextBox();
            this.cBoxShowPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan UID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Password";
            // 
            // tBoxPass
            // 
            this.tBoxPass.Location = new System.Drawing.Point(166, 102);
            this.tBoxPass.Name = "tBoxPass";
            this.tBoxPass.Size = new System.Drawing.Size(223, 20);
            this.tBoxPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(304, 153);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tBoxUID
            // 
            this.tBoxUID.Location = new System.Drawing.Point(166, 48);
            this.tBoxUID.Name = "tBoxUID";
            this.tBoxUID.Size = new System.Drawing.Size(223, 20);
            this.tBoxUID.TabIndex = 6;
            // 
            // cBoxShowPass
            // 
            this.cBoxShowPass.AutoSize = true;
            this.cBoxShowPass.Location = new System.Drawing.Point(166, 129);
            this.cBoxShowPass.Name = "cBoxShowPass";
            this.cBoxShowPass.Size = new System.Drawing.Size(102, 17);
            this.cBoxShowPass.TabIndex = 7;
            this.cBoxShowPass.Text = "Show Password";
            this.cBoxShowPass.UseVisualStyleBackColor = true;
            this.cBoxShowPass.CheckedChanged += new System.EventHandler(this.cBoxShowPass_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 217);
            this.Controls.Add(this.cBoxShowPass);
            this.Controls.Add(this.tBoxUID);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tBoxPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tBoxUID;
        private System.Windows.Forms.CheckBox cBoxShowPass;
    }
}