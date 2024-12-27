namespace Restaurant
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.Color.NavajoWhite;
            this.LblEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEmail.Location = new System.Drawing.Point(316, 94);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(65, 24);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email";
            this.LblEmail.Click += new System.EventHandler(this.LblEmail_Click);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.NavajoWhite;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblPassword.Location = new System.Drawing.Point(316, 181);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(109, 24);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password";
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(320, 120);
            this.TbxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(225, 24);
            this.TbxEmail.TabIndex = 2;
            // 
            // TbxPassword
            // 
            this.TbxPassword.Location = new System.Drawing.Point(320, 207);
            this.TbxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(225, 24);
            this.TbxPassword.TabIndex = 3;
            this.TbxPassword.TextChanged += new System.EventHandler(this.TbxPassword_TextChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(381, 255);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(88, 34);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(861, 483);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnLogin;
    }
}

