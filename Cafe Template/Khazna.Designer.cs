namespace Cafe_Template
{
    partial class Khazna
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buyAddButton = new System.Windows.Forms.Button();
            this.buyPriceText = new System.Windows.Forms.TextBox();
            this.buyProductsCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addProductsCombo = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAddButton = new System.Windows.Forms.Button();
            this.addNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.elda5lLabel = new System.Windows.Forms.Label();
            this.sadyratLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.warydtaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1292, 588);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الصادرات";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(0, 109);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1285, 456);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.buyAddButton);
            this.tabPage3.Controls.Add(this.buyPriceText);
            this.tabPage3.Controls.Add(this.buyProductsCombo);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1277, 430);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "شراء";
            // 
            // buyAddButton
            // 
            this.buyAddButton.BackColor = System.Drawing.Color.White;
            this.buyAddButton.FlatAppearance.BorderSize = 0;
            this.buyAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyAddButton.ForeColor = System.Drawing.Color.Black;
            this.buyAddButton.Location = new System.Drawing.Point(702, 83);
            this.buyAddButton.Name = "buyAddButton";
            this.buyAddButton.Size = new System.Drawing.Size(75, 23);
            this.buyAddButton.TabIndex = 4;
            this.buyAddButton.Text = "اضافة";
            this.buyAddButton.UseVisualStyleBackColor = false;
            this.buyAddButton.Click += new System.EventHandler(this.buyAddButton_Click);
            // 
            // buyPriceText
            // 
            this.buyPriceText.Location = new System.Drawing.Point(408, 51);
            this.buyPriceText.Name = "buyPriceText";
            this.buyPriceText.Size = new System.Drawing.Size(119, 20);
            this.buyPriceText.TabIndex = 2;
            // 
            // buyProductsCombo
            // 
            this.buyProductsCombo.FormattingEnabled = true;
            this.buyProductsCombo.Location = new System.Drawing.Point(914, 51);
            this.buyProductsCombo.Name = "buyProductsCombo";
            this.buyProductsCombo.Size = new System.Drawing.Size(121, 21);
            this.buyProductsCombo.TabIndex = 1;
            this.buyProductsCombo.SelectedIndexChanged += new System.EventHandler(this.buyProductsCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(602, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "السعر";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1107, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1277, 430);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "تعديل اصناف الصادرات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addProductsCombo);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(271, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "مسح منتج";
            // 
            // addProductsCombo
            // 
            this.addProductsCombo.FormattingEnabled = true;
            this.addProductsCombo.Location = new System.Drawing.Point(31, 36);
            this.addProductsCombo.Name = "addProductsCombo";
            this.addProductsCombo.Size = new System.Drawing.Size(121, 21);
            this.addProductsCombo.TabIndex = 5;
            this.addProductsCombo.SelectedIndexChanged += new System.EventHandler(this.addProductsCombo_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(119, 105);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "مسح";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(220, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "المنتج";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addAddButton);
            this.groupBox1.Controls.Add(this.addNameText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(810, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اضافة منتج";
            // 
            // addAddButton
            // 
            this.addAddButton.BackColor = System.Drawing.Color.Red;
            this.addAddButton.FlatAppearance.BorderSize = 0;
            this.addAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAddButton.ForeColor = System.Drawing.Color.Black;
            this.addAddButton.Location = new System.Drawing.Point(135, 105);
            this.addAddButton.Name = "addAddButton";
            this.addAddButton.Size = new System.Drawing.Size(75, 23);
            this.addAddButton.TabIndex = 4;
            this.addAddButton.Text = "اضافة";
            this.addAddButton.UseVisualStyleBackColor = false;
            this.addAddButton.Click += new System.EventHandler(this.addAddButton_Click);
            // 
            // addNameText
            // 
            this.addNameText.Location = new System.Drawing.Point(40, 36);
            this.addNameText.Name = "addNameText";
            this.addNameText.Size = new System.Drawing.Size(119, 20);
            this.addNameText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "اسم المنتج";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.elda5lLabel);
            this.tabPage2.Controls.Add(this.sadyratLabel);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.warydtaLabel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الاحصائيات اليومية";
            // 
            // elda5lLabel
            // 
            this.elda5lLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elda5lLabel.ForeColor = System.Drawing.Color.White;
            this.elda5lLabel.Location = new System.Drawing.Point(683, 291);
            this.elda5lLabel.Name = "elda5lLabel";
            this.elda5lLabel.Size = new System.Drawing.Size(233, 40);
            this.elda5lLabel.TabIndex = 0;
            this.elda5lLabel.Text = "0.00";
            this.elda5lLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sadyratLabel
            // 
            this.sadyratLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadyratLabel.ForeColor = System.Drawing.Color.White;
            this.sadyratLabel.Location = new System.Drawing.Point(683, 194);
            this.sadyratLabel.Name = "sadyratLabel";
            this.sadyratLabel.Size = new System.Drawing.Size(233, 40);
            this.sadyratLabel.TabIndex = 0;
            this.sadyratLabel.Text = "0.00";
            this.sadyratLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(963, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 40);
            this.label9.TabIndex = 0;
            this.label9.Text = "صافي الدخل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(963, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 40);
            this.label6.TabIndex = 0;
            this.label6.Text = "اجمالي الصادرات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warydtaLabel
            // 
            this.warydtaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warydtaLabel.ForeColor = System.Drawing.Color.White;
            this.warydtaLabel.Location = new System.Drawing.Point(683, 96);
            this.warydtaLabel.Name = "warydtaLabel";
            this.warydtaLabel.Size = new System.Drawing.Size(233, 40);
            this.warydtaLabel.TabIndex = 0;
            this.warydtaLabel.Text = "0.00";
            this.warydtaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(963, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "اجمالي الواردات";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Khazna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tabControl1);
            this.Name = "Khazna";
            this.Size = new System.Drawing.Size(1295, 591);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buyAddButton;
        private System.Windows.Forms.TextBox buyPriceText;
        private System.Windows.Forms.ComboBox buyProductsCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox addProductsCombo;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addAddButton;
        private System.Windows.Forms.TextBox addNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label elda5lLabel;
        private System.Windows.Forms.Label sadyratLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label warydtaLabel;
        private System.Windows.Forms.Label label5;
    }
}
