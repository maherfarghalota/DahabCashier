using System;
using System.Windows.Forms;
using Cafe_Template.Models;
using System.Linq;

namespace Cafe_Template
{
    public partial class EditUsers : UserControl
    {
        public EditUsers()
        {
            InitializeComponent();
            usersCombo.Hide();
            editNameText.Hide();
            editPasswordText.Hide();
            updateButton.Hide();
            deleteButton.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
        }

        private void fillComboButton_Click(object sender, EventArgs e)
        {

            if (checkAdminAccess(false))
            {
                usersCombo.Items.Clear();
                for (int i = 0; i < DataManager.users.Count; i++)
                {
                    usersCombo.Items.Add(DataManager.users[i].userName);
                }

                usersCombo.Show();
                editNameText.Show();
                editPasswordText.Show();
                updateButton.Show();
                deleteButton.Show();
                label6.Show();
                label7.Show();
                label8.Show();
            }
            else
            {
                MessageBox.Show("كلمه مرور المصرح به خاطئه");
            }
        }

        private void newAddButton_Click(object sender, EventArgs e)
        {
            if (checkValideDataForAdd())
            {
                if (checkUserNameValide())
                {
                    if (checkAdminAccess(true))
                    {
                        addNewUser();
                        MessageBox.Show("تم الاضافه بنجاح");
                        newUserText.Text = "";
                        newPasswordText.Text = "";
                        newNameText.Text = "";
                        newAdminPassText.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("كلمه مرور المصرح به خاطئه");
                    }
                }
                else
                {
                    MessageBox.Show("يوجد اسم مستخدم بهذا الاسم");
                }

            }
            else
            {
                MessageBox.Show("يجب ملىء جميع الحقول");
            }
        }

        bool checkValideDataForAdd()
        {
            if (newUserText.Text == "" || newPasswordText.Text == "" || newNameText.Text == "" || newAdminPassText.Text == "")
            {
                return false;
            }
            return true;
        }

        bool checkValideDataForEdit()
        {
            if (editNameText.Text == "" || editPasswordText.Text == "")
            {
                return false;
            }
            return true;
        }

        bool checkAdminAccess(bool addFormOpened)
        {
            if (addFormOpened)
            {
                if (newAdminPassText.Text == DataManager.users[0].password)
                    return true;
                else
                    return false;
            }
            else
            {
                if (adminPasswordText.Text == DataManager.users[0].password)
                    return true;
                else
                    return false;
            }

        }

        void addNewUser()
        {
            User newUser = new User();
            newUser.userName = newUserText.Text;
            newUser.name = newNameText.Text;
            newUser.password = newPasswordText.Text;
            DataManager.users.Add(newUser);
            DataManager.updateUserData();
        }

        bool checkUserNameValide()
        {
            foreach (var user in DataManager.users)
            {
                if (newUserText.Text == user.userName)
                {
                    return false;
                }
            }
            return true;
        }

        private void usersCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var user in DataManager.users)
            {
                if (usersCombo.Text == user.userName)
                {
                    editNameText.Text = user.name;
                    editPasswordText.Text = user.password;
                    return;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var itemToRemove = DataManager.users.Find(r => r.userName == usersCombo.Text);
            if (itemToRemove == null)
            {
                MessageBox.Show("لا يوجد مستخدم بهذا الاسم");
                return;
            }
            else if (itemToRemove.adminAccess)
            {
                MessageBox.Show("لا يمكن مسح الادمن");
                return;
            }


            DataManager.users.Remove(itemToRemove);
            DataManager.updateUserData();
            MessageBox.Show("تم المسح");
            editNameText.Text = "";
            editPasswordText.Text = "";
            usersCombo.Items.Clear();
            for (int i = 0; i < DataManager.users.Count; i++)
            {
                usersCombo.Items.Add(DataManager.users[i].userName);
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (checkValideDataForEdit())
            {
                if (DataManager.users.Find(w => w.userName == usersCombo.Text) != null)
                {
                    DataManager.users.Where(w => w.userName == usersCombo.Text).ToList().ForEach(w => { w.name = editNameText.Text; w.password = editPasswordText.Text; });
                    DataManager.updateUserData();
                    MessageBox.Show("تم التعديل");
                    editNameText.Text = "";
                    editPasswordText.Text = "";
                    usersCombo.Items.Clear();
                    for (int i = 0; i < DataManager.users.Count; i++)
                    {
                        usersCombo.Items.Add(DataManager.users[i].userName);
                    }
                }
                else
                {
                    MessageBox.Show("يجب اختيار اسم المستخدم");
                }

            }
            else
            {
                MessageBox.Show("يجب ملىء جميع الحقول");
            }
        }
    }
}
