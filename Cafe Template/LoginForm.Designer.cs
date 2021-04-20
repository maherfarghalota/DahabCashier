namespace Cafe_Template
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.userText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.editUsersButton = new System.Windows.Forms.Button();
            this.finishEditingButton = new System.Windows.Forms.Button();
            this.editUsers1 = new Cafe_Template.EditUsers();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // userText
            // 
            this.userText.ForeColor = System.Drawing.Color.Black;
            this.userText.Location = new System.Drawing.Point(224, 163);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 20);
            this.userText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(111, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.ForeColor = System.Drawing.Color.Black;
            this.passwordText.Location = new System.Drawing.Point(224, 210);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 1;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.White;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(163, 255);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(111, 42);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // editUsersButton
            // 
            this.editUsersButton.BackColor = System.Drawing.Color.White;
            this.editUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUsersButton.Location = new System.Drawing.Point(163, 315);
            this.editUsersButton.Name = "editUsersButton";
            this.editUsersButton.Size = new System.Drawing.Size(111, 27);
            this.editUsersButton.TabIndex = 2;
            this.editUsersButton.Text = "تعديل المستخدمين";
            this.editUsersButton.UseVisualStyleBackColor = false;
            this.editUsersButton.Click += new System.EventHandler(this.editUsersButton_Click);
            // 
            // finishEditingButton
            // 
            this.finishEditingButton.BackColor = System.Drawing.Color.Red;
            this.finishEditingButton.FlatAppearance.BorderSize = 0;
            this.finishEditingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishEditingButton.ForeColor = System.Drawing.Color.Black;
            this.finishEditingButton.Location = new System.Drawing.Point(22, 494);
            this.finishEditingButton.Name = "finishEditingButton";
            this.finishEditingButton.Size = new System.Drawing.Size(75, 23);
            this.finishEditingButton.TabIndex = 4;
            this.finishEditingButton.Text = "إنهاء";
            this.finishEditingButton.UseVisualStyleBackColor = false;
            this.finishEditingButton.Click += new System.EventHandler(this.finishEditingButton_Click);
            // 
            // editUsers1
            // 
            this.editUsers1.BackColor = System.Drawing.Color.PeachPuff;
            this.editUsers1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editUsers1.Location = new System.Drawing.Point(1, 0);
            this.editUsers1.Name = "editUsers1";
            this.editUsers1.Size = new System.Drawing.Size(465, 488);
            this.editUsers1.TabIndex = 3;
            this.editUsers1.Load += new System.EventHandler(this.editUsers1_Load);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Cafe_Template.Properties.Resources._0d260468f6a60649c2a55a3a58d9055e;
            this.ClientSize = new System.Drawing.Size(466, 518);
            this.Controls.Add(this.finishEditingButton);
            this.Controls.Add(this.editUsers1);
            this.Controls.Add(this.editUsersButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button editUsersButton;
        private EditUsers editUsers1;
        private System.Windows.Forms.Button finishEditingButton;
    }
}