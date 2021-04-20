namespace Cafe_Template
{
    partial class Tqarer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.monthly = new System.Windows.Forms.RadioButton();
            this.yearly = new System.Windows.Forms.RadioButton();
            this.daily = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dayCombo = new System.Windows.Forms.ComboBox();
            this.monthCombo = new System.Windows.Forms.ComboBox();
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.printingDailyButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.editingAsnafButton = new System.Windows.Forms.Button();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.productPriceText = new System.Windows.Forms.TextBox();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.addingProductButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.productTypeCombo = new System.Windows.Forms.ComboBox();
            this.productNameCombo = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editingProductsGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.savingEditButton = new System.Windows.Forms.Button();
            this.editCategoriesCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoriesCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editingProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.BackColor = System.Drawing.Color.Black;
            this.monthly.ForeColor = System.Drawing.Color.White;
            this.monthly.Location = new System.Drawing.Point(1086, 27);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(81, 17);
            this.monthly.TabIndex = 0;
            this.monthly.TabStop = true;
            this.monthly.Text = "تقرير شهري";
            this.monthly.UseVisualStyleBackColor = false;
            this.monthly.CheckedChanged += new System.EventHandler(this.monthly_CheckedChanged);
            // 
            // yearly
            // 
            this.yearly.AutoSize = true;
            this.yearly.BackColor = System.Drawing.Color.Black;
            this.yearly.ForeColor = System.Drawing.Color.White;
            this.yearly.Location = new System.Drawing.Point(985, 27);
            this.yearly.Name = "yearly";
            this.yearly.Size = new System.Drawing.Size(80, 17);
            this.yearly.TabIndex = 0;
            this.yearly.TabStop = true;
            this.yearly.Text = "تقرير سنوي";
            this.yearly.UseVisualStyleBackColor = false;
            this.yearly.CheckedChanged += new System.EventHandler(this.yearly_CheckedChanged);
            // 
            // daily
            // 
            this.daily.AutoSize = true;
            this.daily.BackColor = System.Drawing.Color.Black;
            this.daily.ForeColor = System.Drawing.Color.White;
            this.daily.Location = new System.Drawing.Point(1188, 27);
            this.daily.Name = "daily";
            this.daily.Size = new System.Drawing.Size(76, 17);
            this.daily.TabIndex = 0;
            this.daily.TabStop = true;
            this.daily.Text = "تقرير يومي";
            this.daily.UseVisualStyleBackColor = false;
            this.daily.CheckedChanged += new System.EventHandler(this.daily_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(1204, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "يوم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(1038, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "شهر";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(873, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "سنة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayCombo
            // 
            this.dayCombo.FormattingEnabled = true;
            this.dayCombo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayCombo.Location = new System.Drawing.Point(1113, 88);
            this.dayCombo.Name = "dayCombo";
            this.dayCombo.Size = new System.Drawing.Size(85, 21);
            this.dayCombo.TabIndex = 2;
            // 
            // monthCombo
            // 
            this.monthCombo.FormattingEnabled = true;
            this.monthCombo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.monthCombo.Location = new System.Drawing.Point(947, 88);
            this.monthCombo.Name = "monthCombo";
            this.monthCombo.Size = new System.Drawing.Size(85, 21);
            this.monthCombo.TabIndex = 2;
            // 
            // yearCombo
            // 
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.yearCombo.Location = new System.Drawing.Point(782, 88);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(85, 21);
            this.yearCombo.TabIndex = 2;
            this.yearCombo.SelectedIndexChanged += new System.EventHandler(this.yearCombo_SelectedIndexChanged);
            // 
            // printingDailyButton
            // 
            this.printingDailyButton.BackColor = System.Drawing.Color.DarkRed;
            this.printingDailyButton.FlatAppearance.BorderSize = 0;
            this.printingDailyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printingDailyButton.ForeColor = System.Drawing.Color.White;
            this.printingDailyButton.Location = new System.Drawing.Point(0, 0);
            this.printingDailyButton.Name = "printingDailyButton";
            this.printingDailyButton.Size = new System.Drawing.Size(97, 67);
            this.printingDailyButton.TabIndex = 4;
            this.printingDailyButton.Text = "طباعة التقرير اليومي";
            this.printingDailyButton.UseVisualStyleBackColor = false;
            this.printingDailyButton.Click += new System.EventHandler(this.printingDailyButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(577, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "بحث";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // editingAsnafButton
            // 
            this.editingAsnafButton.ForeColor = System.Drawing.Color.Black;
            this.editingAsnafButton.Location = new System.Drawing.Point(232, 88);
            this.editingAsnafButton.Name = "editingAsnafButton";
            this.editingAsnafButton.Size = new System.Drawing.Size(99, 23);
            this.editingAsnafButton.TabIndex = 6;
            this.editingAsnafButton.Text = "تعديل الاصناف";
            this.editingAsnafButton.UseVisualStyleBackColor = true;
            this.editingAsnafButton.Click += new System.EventHandler(this.editingAsnafButton_Click);
            // 
            // orderGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderGridView.Location = new System.Drawing.Point(664, 150);
            this.orderGridView.Name = "orderGridView";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.orderGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.orderGridView.Size = new System.Drawing.Size(600, 282);
            this.orderGridView.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.categoriesCombo);
            this.panel1.Location = new System.Drawing.Point(131, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 426);
            this.panel1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(334, 373);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.productPriceText);
            this.tabPage1.Controls.Add(this.productNameText);
            this.tabPage1.Controls.Add(this.addingProductButton);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.productTypeCombo);
            this.tabPage1.Controls.Add(this.productNameCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(326, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مسح \\ اضافة";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // productPriceText
            // 
            this.productPriceText.Location = new System.Drawing.Point(105, 238);
            this.productPriceText.Name = "productPriceText";
            this.productPriceText.Size = new System.Drawing.Size(121, 20);
            this.productPriceText.TabIndex = 3;
            this.productPriceText.TextChanged += new System.EventHandler(this.productPriceText_TextChanged);
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(105, 192);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(121, 20);
            this.productNameText.TabIndex = 3;
            this.productNameText.TextChanged += new System.EventHandler(this.productNameText_TextChanged);
            // 
            // addingProductButton
            // 
            this.addingProductButton.FlatAppearance.BorderSize = 0;
            this.addingProductButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addingProductButton.ForeColor = System.Drawing.Color.Black;
            this.addingProductButton.Location = new System.Drawing.Point(70, 275);
            this.addingProductButton.Name = "addingProductButton";
            this.addingProductButton.Size = new System.Drawing.Size(75, 23);
            this.addingProductButton.TabIndex = 2;
            this.addingProductButton.Text = "اضافة الصنف";
            this.addingProductButton.UseVisualStyleBackColor = true;
            this.addingProductButton.Click += new System.EventHandler(this.addingProductButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(136, 49);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "مسح الصنف";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(250, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "سعر الصنف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "اسم الصنف";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(250, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "نوع الصنف";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(250, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "اسم الصنف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productTypeCombo
            // 
            this.productTypeCombo.FormattingEnabled = true;
            this.productTypeCombo.Location = new System.Drawing.Point(105, 143);
            this.productTypeCombo.Name = "productTypeCombo";
            this.productTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.productTypeCombo.TabIndex = 0;
            this.productTypeCombo.SelectedIndexChanged += new System.EventHandler(this.productTypeCombo_SelectedIndexChanged);
            // 
            // productNameCombo
            // 
            this.productNameCombo.FormattingEnabled = true;
            this.productNameCombo.Location = new System.Drawing.Point(105, 22);
            this.productNameCombo.Name = "productNameCombo";
            this.productNameCombo.Size = new System.Drawing.Size(121, 21);
            this.productNameCombo.TabIndex = 0;
            this.productNameCombo.SelectedIndexChanged += new System.EventHandler(this.productNameCombo_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.editingProductsGrid);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.savingEditButton);
            this.tabPage2.Controls.Add(this.editCategoriesCombo);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(326, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تعديل";
            // 
            // editingProductsGrid
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editingProductsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.editingProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editingProductsGrid.Location = new System.Drawing.Point(49, 34);
            this.editingProductsGrid.Name = "editingProductsGrid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.editingProductsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.editingProductsGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.editingProductsGrid.Size = new System.Drawing.Size(224, 279);
            this.editingProductsGrid.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(205, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "الفئة";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // savingEditButton
            // 
            this.savingEditButton.FlatAppearance.BorderSize = 0;
            this.savingEditButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savingEditButton.ForeColor = System.Drawing.Color.Black;
            this.savingEditButton.Location = new System.Drawing.Point(118, 319);
            this.savingEditButton.Name = "savingEditButton";
            this.savingEditButton.Size = new System.Drawing.Size(75, 23);
            this.savingEditButton.TabIndex = 2;
            this.savingEditButton.Text = "حفظ التعديلات";
            this.savingEditButton.UseVisualStyleBackColor = true;
            this.savingEditButton.Click += new System.EventHandler(this.savingEditButton_Click);
            // 
            // editCategoriesCombo
            // 
            this.editCategoriesCombo.FormattingEnabled = true;
            this.editCategoriesCombo.Location = new System.Drawing.Point(60, 7);
            this.editCategoriesCombo.Name = "editCategoriesCombo";
            this.editCategoriesCombo.Size = new System.Drawing.Size(121, 21);
            this.editCategoriesCombo.TabIndex = 0;
            this.editCategoriesCombo.SelectedIndexChanged += new System.EventHandler(this.editCategoriesCombo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(257, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "الفئة";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoriesCombo
            // 
            this.categoriesCombo.FormattingEnabled = true;
            this.categoriesCombo.Location = new System.Drawing.Point(112, 23);
            this.categoriesCombo.Name = "categoriesCombo";
            this.categoriesCombo.Size = new System.Drawing.Size(121, 21);
            this.categoriesCombo.TabIndex = 0;
            this.categoriesCombo.SelectedIndexChanged += new System.EventHandler(this.categoriesCombo_SelectedIndexChanged);
            // 
            // Tqarer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderGridView);
            this.Controls.Add(this.editingAsnafButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.printingDailyButton);
            this.Controls.Add(this.yearCombo);
            this.Controls.Add(this.monthCombo);
            this.Controls.Add(this.dayCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearly);
            this.Controls.Add(this.daily);
            this.Controls.Add(this.monthly);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Tqarer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1295, 591);
            this.Load += new System.EventHandler(this.Tqarer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editingProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton monthly;
        private System.Windows.Forms.RadioButton yearly;
        private System.Windows.Forms.RadioButton daily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dayCombo;
        private System.Windows.Forms.ComboBox monthCombo;
        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.Button printingDailyButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button editingAsnafButton;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoriesCombo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox productPriceText;
        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Button addingProductButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox productTypeCombo;
        private System.Windows.Forms.ComboBox productNameCombo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView editingProductsGrid;
        private System.Windows.Forms.Button savingEditButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox editCategoriesCombo;
    }
}
