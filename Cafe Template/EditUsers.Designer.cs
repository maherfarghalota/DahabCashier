namespace Cafe_Template
{
    partial class EditUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newAddButton = new System.Windows.Forms.Button();
            this.newAdminPassText = new System.Windows.Forms.TextBox();
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newUserText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editPasswordText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.editNameText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.usersCombo = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.fillComboButton = new System.Windows.Forms.Button();
            this.adminPasswordText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(467, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Cafe_Template.Properties.Resources._5043e8b3aea892a6d0d1d4245f7d744b;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.newAddButton);
            this.tabPage1.Controls.Add(this.newAdminPassText);
            this.tabPage1.Controls.Add(this.newPasswordText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.newNameText);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.newUserText);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "إضافة";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newAddButton
            // 
            this.newAddButton.BackColor = System.Drawing.Color.Black;
            this.newAddButton.FlatAppearance.BorderSize = 0;
            this.newAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newAddButton.ForeColor = System.Drawing.Color.White;
            this.newAddButton.Location = new System.Drawing.Point(64, 378);
            this.newAddButton.Name = "newAddButton";
            this.newAddButton.Size = new System.Drawing.Size(75, 23);
            this.newAddButton.TabIndex = 2;
            this.newAddButton.Text = "إضافة";
            this.newAddButton.UseVisualStyleBackColor = false;
            this.newAddButton.Click += new System.EventHandler(this.newAddButton_Click);
            // 
            // newAdminPassText
            // 
            this.newAdminPassText.Location = new System.Drawing.Point(113, 318);
            this.newAdminPassText.Name = "newAdminPassText";
            this.newAdminPassText.PasswordChar = '*';
            this.newAdminPassText.Size = new System.Drawing.Size(100, 20);
            this.newAdminPassText.TabIndex = 1;
            // 
            // newPasswordText
            // 
            this.newPasswordText.Location = new System.Drawing.Point(113, 160);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(100, 20);
            this.newPasswordText.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(280, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "باسوورد المصرح به";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "الباسوورد";
            // 
            // newNameText
            // 
            this.newNameText.Location = new System.Drawing.Point(113, 111);
            this.newNameText.Name = "newNameText";
            this.newNameText.Size = new System.Drawing.Size(100, 20);
            this.newNameText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(280, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "الاسم";
            // 
            // newUserText
            // 
            this.newUserText.Location = new System.Drawing.Point(113, 68);
            this.newUserText.Name = "newUserText";
            this.newUserText.Size = new System.Drawing.Size(100, 20);
            this.newUserText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Cafe_Template.Properties.Resources._5043e8b3aea892a6d0d1d4245f7d744b;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.editPasswordText);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.editNameText);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.usersCombo);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.updateButton);
            this.tabPage2.Controls.Add(this.fillComboButton);
            this.tabPage2.Controls.Add(this.adminPasswordText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تعديل";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // editPasswordText
            // 
            this.editPasswordText.Location = new System.Drawing.Point(104, 285);
            this.editPasswordText.Name = "editPasswordText";
            this.editPasswordText.Size = new System.Drawing.Size(121, 20);
            this.editPasswordText.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "الباسوورد";
            // 
            // editNameText
            // 
            this.editNameText.Location = new System.Drawing.Point(104, 236);
            this.editNameText.Name = "editNameText";
            this.editNameText.Size = new System.Drawing.Size(121, 20);
            this.editNameText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(271, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "الاسم";
            // 
            // usersCombo
            // 
            this.usersCombo.FormattingEnabled = true;
            this.usersCombo.Location = new System.Drawing.Point(104, 193);
            this.usersCombo.Name = "usersCombo";
            this.usersCombo.Size = new System.Drawing.Size(121, 21);
            this.usersCombo.TabIndex = 5;
            this.usersCombo.SelectedIndexChanged += new System.EventHandler(this.usersCombo_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(116, 389);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "مسح";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Black;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(35, 389);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "تحديث";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // fillComboButton
            // 
            this.fillComboButton.BackColor = System.Drawing.Color.Black;
            this.fillComboButton.FlatAppearance.BorderSize = 0;
            this.fillComboButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillComboButton.ForeColor = System.Drawing.Color.White;
            this.fillComboButton.Location = new System.Drawing.Point(193, 114);
            this.fillComboButton.Name = "fillComboButton";
            this.fillComboButton.Size = new System.Drawing.Size(75, 23);
            this.fillComboButton.TabIndex = 4;
            this.fillComboButton.Text = "ملئ البيانات";
            this.fillComboButton.UseVisualStyleBackColor = false;
            this.fillComboButton.Click += new System.EventHandler(this.fillComboButton_Click);
            // 
            // adminPasswordText
            // 
            this.adminPasswordText.Location = new System.Drawing.Point(104, 67);
            this.adminPasswordText.Name = "adminPasswordText";
            this.adminPasswordText.PasswordChar = '*';
            this.adminPasswordText.Size = new System.Drawing.Size(121, 20);
            this.adminPasswordText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(271, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "المستخدمين";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "باسوورد المصرح به";
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tabControl1);
            this.Name = "EditUsers";
            this.Size = new System.Drawing.Size(467, 487);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button newAddButton;
        private System.Windows.Forms.TextBox newAdminPassText;
        private System.Windows.Forms.TextBox newPasswordText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newUserText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editPasswordText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox editNameText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox usersCombo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button fillComboButton;
        private System.Windows.Forms.TextBox adminPasswordText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
