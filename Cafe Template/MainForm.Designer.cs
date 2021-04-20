namespace Cafe_Template
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tqarerButton = new System.Windows.Forms.Button();
            this.khaznaViewButton = new System.Windows.Forms.Button();
            this.sallahViewButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.authPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.authPasswordText = new System.Windows.Forms.TextBox();
            this.authConfirmButton = new System.Windows.Forms.Button();
            this.tqarer1 = new Cafe_Template.Tqarer();
            this.sallah1 = new Cafe_Template.Sallah();
            this.khazna1 = new Cafe_Template.Khazna();
            this.panel1.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tqarerButton);
            this.panel1.Controls.Add(this.khaznaViewButton);
            this.panel1.Controls.Add(this.sallahViewButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(316, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(112, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "اسم اللي عامل login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tqarerButton
            // 
            this.tqarerButton.BackColor = System.Drawing.Color.DarkRed;
            this.tqarerButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tqarerButton.FlatAppearance.BorderSize = 0;
            this.tqarerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tqarerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tqarerButton.Location = new System.Drawing.Point(875, -2);
            this.tqarerButton.Name = "tqarerButton";
            this.tqarerButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tqarerButton.Size = new System.Drawing.Size(96, 42);
            this.tqarerButton.TabIndex = 0;
            this.tqarerButton.Text = "التقارير";
            this.tqarerButton.UseVisualStyleBackColor = false;
            this.tqarerButton.Click += new System.EventHandler(this.tqarerButton_Click);
            // 
            // khaznaViewButton
            // 
            this.khaznaViewButton.BackColor = System.Drawing.Color.DarkRed;
            this.khaznaViewButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.khaznaViewButton.FlatAppearance.BorderSize = 0;
            this.khaznaViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.khaznaViewButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.khaznaViewButton.Location = new System.Drawing.Point(1079, -2);
            this.khaznaViewButton.Name = "khaznaViewButton";
            this.khaznaViewButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.khaznaViewButton.Size = new System.Drawing.Size(96, 42);
            this.khaznaViewButton.TabIndex = 0;
            this.khaznaViewButton.Text = "الخزنة";
            this.khaznaViewButton.UseVisualStyleBackColor = false;
            this.khaznaViewButton.Click += new System.EventHandler(this.khaznaViewButton_Click);
            // 
            // sallahViewButton
            // 
            this.sallahViewButton.BackColor = System.Drawing.Color.DarkRed;
            this.sallahViewButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sallahViewButton.FlatAppearance.BorderSize = 0;
            this.sallahViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sallahViewButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sallahViewButton.Location = new System.Drawing.Point(977, -2);
            this.sallahViewButton.Name = "sallahViewButton";
            this.sallahViewButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sallahViewButton.Size = new System.Drawing.Size(96, 42);
            this.sallahViewButton.TabIndex = 0;
            this.sallahViewButton.Text = "الصالة";
            this.sallahViewButton.UseVisualStyleBackColor = false;
            this.sallahViewButton.Click += new System.EventHandler(this.sallahViewButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DarkRed;
            this.logoutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutButton.Location = new System.Drawing.Point(-2, -2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoutButton.Size = new System.Drawing.Size(96, 42);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "تسجيل خروج";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // authPanel
            // 
            this.authPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.authPanel.Controls.Add(this.authConfirmButton);
            this.authPanel.Controls.Add(this.authPasswordText);
            this.authPanel.Controls.Add(this.label2);
            this.authPanel.Location = new System.Drawing.Point(228, 213);
            this.authPanel.Name = "authPanel";
            this.authPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.authPanel.Size = new System.Drawing.Size(868, 154);
            this.authPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(620, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "باسوورد الصلاحية";
            // 
            // authPasswordText
            // 
            this.authPasswordText.Location = new System.Drawing.Point(268, 67);
            this.authPasswordText.Name = "authPasswordText";
            this.authPasswordText.Size = new System.Drawing.Size(228, 20);
            this.authPasswordText.TabIndex = 1;
            this.authPasswordText.TextChanged += new System.EventHandler(this.authPasswordText_TextChanged);
            // 
            // authConfirmButton
            // 
            this.authConfirmButton.Location = new System.Drawing.Point(103, 103);
            this.authConfirmButton.Name = "authConfirmButton";
            this.authConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.authConfirmButton.TabIndex = 2;
            this.authConfirmButton.Text = "تأكيد";
            this.authConfirmButton.UseVisualStyleBackColor = true;
            this.authConfirmButton.Click += new System.EventHandler(this.authConfirmButton_Click);
            // 
            // tqarer1
            // 
            this.tqarer1.BackColor = System.Drawing.Color.Black;
            this.tqarer1.ForeColor = System.Drawing.Color.White;
            this.tqarer1.Location = new System.Drawing.Point(0, 43);
            this.tqarer1.Name = "tqarer1";
            this.tqarer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tqarer1.Size = new System.Drawing.Size(1295, 591);
            this.tqarer1.TabIndex = 3;
            // 
            // sallah1
            // 
            this.sallah1.BackColor = System.Drawing.Color.Black;
            this.sallah1.Location = new System.Drawing.Point(0, 43);
            this.sallah1.Name = "sallah1";
            this.sallah1.Size = new System.Drawing.Size(1295, 591);
            this.sallah1.TabIndex = 2;
            // 
            // khazna1
            // 
            this.khazna1.BackColor = System.Drawing.Color.Black;
            this.khazna1.Location = new System.Drawing.Point(0, 43);
            this.khazna1.Name = "khazna1";
            this.khazna1.Size = new System.Drawing.Size(1295, 591);
            this.khazna1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1297, 634);
            this.Controls.Add(this.authPanel);
            this.Controls.Add(this.tqarer1);
            this.Controls.Add(this.sallah1);
            this.Controls.Add(this.khazna1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "My Cafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tqarerButton;
        private System.Windows.Forms.Button khaznaViewButton;
        private System.Windows.Forms.Button sallahViewButton;
        private System.Windows.Forms.Button logoutButton;
        private Khazna khazna1;
        private Sallah sallah1;
        private Tqarer tqarer1;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Button authConfirmButton;
        private System.Windows.Forms.TextBox authPasswordText;
        private System.Windows.Forms.Label label2;
    }
}

