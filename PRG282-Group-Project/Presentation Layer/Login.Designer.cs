
namespace PRG282_Group_Project
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtUsername = new System.Windows.Forms.TextBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_NewAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(579, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(579, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // edtUsername
            // 
            this.edtUsername.Location = new System.Drawing.Point(683, 258);
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(106, 22);
            this.edtUsername.TabIndex = 2;
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(683, 286);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.PasswordChar = '*';
            this.edtPassword.Size = new System.Drawing.Size(106, 22);
            this.edtPassword.TabIndex = 3;
            this.edtPassword.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(706, 326);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(83, 33);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btn_NewAccount
            // 
            this.btn_NewAccount.Location = new System.Drawing.Point(582, 326);
            this.btn_NewAccount.Name = "btn_NewAccount";
            this.btn_NewAccount.Size = new System.Drawing.Size(107, 33);
            this.btn_NewAccount.TabIndex = 5;
            this.btn_NewAccount.Text = "New Account";
            this.btn_NewAccount.UseVisualStyleBackColor = true;
            this.btn_NewAccount.Click += new System.EventHandler(this.btnNewAccount_Click);
            // 
            // frmLogin
            // 
            this.BackgroundImage = global::PRG282_Group_Project.Properties.Resources.login_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 518);
            this.Controls.Add(this.btn_NewAccount);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
    }
}

