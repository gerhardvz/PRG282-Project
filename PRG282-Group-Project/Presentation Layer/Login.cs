using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282_Group_Project.Business_Layer.UserBLL;

namespace PRG282_Group_Project
{
    public partial class frmLogin : Form
    {
        private Label label1;
        private TextBox edtUsername;
        private TextBox edtPassword;
        private Button btn_Login;
        private Button btn_NewAccount;
        private Label label2;

        public frmLogin()
        {
            InitializeComponent();
        }

   
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User loginUser = new User(edtUsername.Text,edtPassword.Text,false);
            bool validLogin = Read_User.VerifyUser(loginUser);
            //Popup message if validLogin is false else go to Main
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            //Popup to ask if a new user must be created. Ask if password should be encrypted
            bool isEncrypted = false;
            User user = new User(edtUsername.Text, edtPassword.Text, isEncrypted);
            string result = Insert_User.Add(user);
            //Popup to show if it was a success
        }
    }
}
