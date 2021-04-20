using System;
using System.Windows.Forms;
using Cafe_Template.Models;

namespace Cafe_Template
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            userText.Focus();
            editUsers1.Hide();
            finishEditingButton.Hide();
            DataManager.loadPrinterPath();
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (checkUserData())
                goToMainForm();
            else
                MessageBox.Show("اسم المستخدم او كلمه المرور خاطئه");
        }

        private void editUsersButton_Click(object sender, EventArgs e)
        {
            goToEditUserForm();
        }

        private void finishEditingButton_Click(object sender, EventArgs e)
        {
            goToLoginForm();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataManager.loadUsersData();
        }

        void goToEditUserForm()
        {
            editUsers1.Show();
            finishEditingButton.Show();
        }

        void goToLoginForm()
        {
            editUsers1.Hide();
            finishEditingButton.Hide();
        }

        void goToMainForm()
        {
            Hide();
            var mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }

        bool checkUserData()
        {
            for (int i = 0; i < DataManager.users.Count; i++)
            {
                if (userText.Text == DataManager.users[i].userName && passwordText.Text == DataManager.users[i].password)
                {
                    AdminManager.adminAccess = DataManager.users[i].adminAccess;
                    LoginDataManager.userName = DataManager.users[i].name;
                    return true;
                }
            }

            return false;
        }

        private void editUsers1_Load(object sender, EventArgs e)
        {

        }
    }
}
