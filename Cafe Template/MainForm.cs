using Cafe_Template.Models;
using System;
using System.Windows.Forms;

namespace Cafe_Template
{
    public partial class MainForm : Form
    {
        bool khazna;
        bool taqarer;
        public MainForm()
        {
            khazna = false;
            InitializeComponent();
            khazna1.Hide();
            sallah1.Show();
            tqarer1.Hide();
            label1.Text = LoginDataManager.userName;
            authPanel.Hide();
            taqarer = false;
        }

        private void khaznaViewButton_Click(object sender, EventArgs e)
        {
            if (!AdminManager.adminAccess)
            {
                authPanel.Show();
                authPanel.BringToFront();
                khazna = true;
                return;

            }
            khazna1.Show();
            sallah1.Hide();
            tqarer1.Hide();
        }

        private void sallahViewButton_Click(object sender, EventArgs e)
        {
            sallah1.Show();
            khazna1.Hide();
            tqarer1.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tqarerButton_Click(object sender, EventArgs e)
        {
            if (!AdminManager.adminAccess)
            {
                authPanel.Show();
                authPanel.BringToFront();
                taqarer = true;
                return;

            }
            sallah1.Hide();
            khazna1.Hide();
            tqarer1.Show();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => Close();
            loginForm.Show();
        }

        private void authConfirmButton_Click(object sender, EventArgs e)
        {
            if (authPasswordText.Text == "152000")
            {
                authPanel.Hide();
                if (taqarer)
                {
                    sallah1.Hide();
                    khazna1.Hide();
                    tqarer1.Show();
                    authPasswordText.Text = "";
                }
                else if (khazna)
                {
                    khazna1.Show();
                    sallah1.Hide();
                    tqarer1.Hide();
                    authPasswordText.Text = "";
                }
            }
            else
            {
                MessageBox.Show("باسوورد الصلاحية غير صحيح");
                return;
            }

        }

        private void authPasswordText_TextChanged(object sender, EventArgs e)
        {
            authPasswordText.PasswordChar = '*';
        }
    }
}
