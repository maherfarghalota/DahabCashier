using Cafe_Template.Models;
using PrinterUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Template
{
    public partial class Tqarer : UserControl
    {
        string typeOfReport = "";
        public Tqarer()
        {
            InitializeComponent();
            orderGridView.Hide();
            panel1.Hide();
            tabControl1.Hide();
        }

        private void Tqarer_Load(object sender, EventArgs e)
        {
            dayCombo.Enabled = false;
            monthCombo.Enabled = false;
            yearCombo.Enabled = false;

            orderGridView.ColumnCount = 5;
            orderGridView.Columns[0].Name = "الوقت";
            orderGridView.Columns[1].Name = "طربيظه";
            orderGridView.Columns[2].Name = "السعر";
            orderGridView.Columns[3].Name = "الخصم";
            orderGridView.Columns[4].Name = "السعر الكامل";

            DataManager.loadOrdersData();
            asnafEditLoad();
        }

        private void asnafEditLoad()
        {
            categoriesCombo.Items.Add("مشروبات ساخنه");
            categoriesCombo.Items.Add("مشروبات بارده");
            categoriesCombo.Items.Add("وجبات");

            editCategoriesCombo.Items.Add("مشروبات ساخنه");
            editCategoriesCombo.Items.Add("مشروبات بارده");
            editCategoriesCombo.Items.Add("وجبات");

            productTypeCombo.Items.Add("مشروبات ساخنه");
            productTypeCombo.Items.Add("مشروبات بارده");
            productTypeCombo.Items.Add("وجبات");

            editingProductsGrid.ColumnCount = 2;
            editingProductsGrid.Columns[0].Name = "المشروب";
            editingProductsGrid.Columns[1].Name = "السعر";

            editingProductsGrid.Rows.Clear();
            //int n = -1;
            //foreach (var item in DataManager.menu)
            //{
            //    foreach (var drink in item.Value)
            //    {
            //        n = editingProductsGrid.Rows.Add();
            //        editingProductsGrid.Rows[n].Cells[0].Value = drink.name;
            //        editingProductsGrid.Rows[n].Cells[0].ReadOnly = true;
            //        editingProductsGrid.Rows[n].Cells[1].Value = drink.price;
            //    }
            //}
        }

        void loadDrinks(int selectedCombo)
        {
            editingProductsGrid.Rows.Clear();
            productNameCombo.Items.Clear();
            int n = -1;
            string selectedCategory = "";
            if (selectedCombo == 1)
                selectedCategory = categoriesCombo.SelectedItem.ToString();
            else if (selectedCombo == 2)
                selectedCategory = editCategoriesCombo.SelectedItem.ToString();
            if (DataManager.menu[selectedCategory].Count == 0)
                throw new Exception();
            foreach (var drink in DataManager.menu[selectedCategory])
            {
                if (selectedCombo == 2)
                {
                    n = editingProductsGrid.Rows.Add();
                    editingProductsGrid.Rows[n].Cells[0].Value = drink.name;
                    editingProductsGrid.Rows[n].Cells[0].ReadOnly = true;
                    editingProductsGrid.Rows[n].Cells[1].Value = drink.price.ToString();
                }
                else if (selectedCombo == 1)
                    productNameCombo.Items.Add(drink.name);
            }
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            DataManager.loadOrdersData();
            if (typeOfReport == "")
            {
                MessageBox.Show("يجب اختيار نوع التقرير");
                return;
            }

            string dateOfReport = "";

            if (checkValideData())
            {
                if (typeOfReport == "daily")
                {
                    dateOfReport = dayCombo.Text + "/" + monthCombo.Text + "/" + yearCombo.Text;
                }
                else if (typeOfReport == "monthly")
                {
                    dateOfReport = monthCombo.Text + "/" + yearCombo.Text;
                }
                else
                {
                    dateOfReport = yearCombo.Text;
                }
                getOrders(dateOfReport);
                orderGridView.Show();
            }
            else
            {
                MessageBox.Show("يجب اختيار الحقول المطلوبه");
            }
        }

        private void daily_CheckedChanged(object sender, EventArgs e)
        {
            dayCombo.Enabled = true;
            monthCombo.Enabled = true;
            yearCombo.Enabled = true;
            typeOfReport = "daily";
        }

        private void monthly_CheckedChanged(object sender, EventArgs e)
        {
            dayCombo.Enabled = false;
            monthCombo.Enabled = true;
            yearCombo.Enabled = true;
            typeOfReport = "monthly";
        }

        private void yearly_CheckedChanged(object sender, EventArgs e)
        {
            dayCombo.Enabled = false;
            monthCombo.Enabled = false;
            yearCombo.Enabled = true;
            typeOfReport = "yearly";
        }

        bool checkValideData()
        {
            if (typeOfReport == "daily")
            {
                if (dayCombo.Text == "" || monthCombo.Text == "" || yearCombo.Text == "")
                    return false;
            }
            else if (typeOfReport == "monthly")
            {
                if (monthCombo.Text == "" || yearCombo.Text == "")
                    return false;
            }
            else
            {
                if (yearCombo.Text == "")
                    return false;
            }

            return true;
        }

        void getOrders(string date)
        {
            orderGridView.Rows.Clear();
            if (typeOfReport == "daily")
            {
                var orders = DataManager.orders.Where(item => item.Key == date).Select(i => i.Value);
                if (orders.Count() == 0)
                {
                    MessageBox.Show("لا يوجد تقارير");
                    return;
                }
                displayOrders(orders);
            }
            else
            {
                var orders = DataManager.orders.Where(item => item.Key.Contains(date)).Select(i => i.Value);
                if (orders.Count() == 0)
                {
                    MessageBox.Show("لا يوجد تقارير");
                    return;
                }
                displayOrders(orders);
            }
        }

        void displayOrders(IEnumerable<List<Order>> orders)
        {
            int n = -1;
            foreach (var dayOrders in orders)
            {
                foreach (var order in dayOrders)
                {
                    n = orderGridView.Rows.Add();
                    orderGridView.Rows[n].Cells[0].Value = order.date.ToString();
                    orderGridView.Rows[n].Cells[1].Value = order.tarabyza;
                    orderGridView.Rows[n].Cells[2].Value = order.price.ToString();
                    orderGridView.Rows[n].Cells[3].Value = order.discount.ToString();
                    orderGridView.Rows[n].Cells[4].Value = order.totalPrice.ToString();
                }

            }

        }

        private void editingAsnafButton_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void yearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void getDailyReport()
        {
            DataManager.loadOrdersData();
            if (typeOfReport == "")
            {
                MessageBox.Show("يجب اختيار نوع التقرير");
                return;
            }

            string dateOfReport = "";

            if (checkValideData())
            {
                if (typeOfReport == "daily")
                {
                    dateOfReport = dayCombo.Text + "/" + monthCombo.Text + "/" + yearCombo.Text;
                }
            }

            if (typeOfReport == "daily")
            {
                var orders = DataManager.orders.Where(item => item.Key == dateOfReport).Select(i => i.Value);
                if (orders.Count() == 0)
                {
                    MessageBox.Show("لا يوجد تقارير");
                    return;
                }

                PrinterUtility.EscPosEpsonCommands.EscPosEpson tempObj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
                var bytesValue = tempObj.CharSize.DoubleWidth6();
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Center());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.FontSelect.FontC());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Dahab Cafe\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.Nomarl());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.DoubleWidth4());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Report\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.DoubleWidth2());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Left());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Date    Table    Total\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                double totalPrice = 0.0;
                foreach (var dayOrder in orders)
                {
                    foreach (var order in dayOrder)
                    {
                        bytesValue = PrintExtensions.AddBytes(bytesValue, string.Format("{0, -40}{1, 6}{2, 9}\n", order.date.ToString(), order.tarabyza, order.totalPrice.ToString()));
                        totalPrice += order.totalPrice;

                    }
                }

                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Right());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Total Price : " + totalPrice.ToString() + "\n\n\n\n\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Left());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes(CutPage()));
                // PrinterUtility.PrintExtensions.Print(bytesValue, Cafe_Template.Properties.Settings.Default.PrinterPath);
                try
                {
                    PrintExtensions.Print(bytesValue, DataManager.printerPath);
                }
                catch
                {
                    MessageBox.Show("برجاء فحص الطابعة");
                }
                var items = StatisticsCalculator.drinksCalculation(dateOfReport);
                tempObj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
                bytesValue = Encoding.ASCII.GetBytes("");
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Center());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.FontSelect.FontC());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Dahab Cafe\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.Nomarl());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.DoubleWidth4());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Report\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.DoubleWidth2());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Left());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Item    Count\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                foreach (var item in items)
                {
                    bytesValue = PrintExtensions.AddBytes(bytesValue, string.Format("{0, -40}{1, 6}\n", item.Key, item.Value.ToString()));

                }


                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Center());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
                bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Left());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("\n\n\n\n\n\n"));
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes(CutPage()));
                // PrinterUtility.PrintExtensions.Print(bytesValue, Cafe_Template.Properties.Settings.Default.PrinterPath);
                try
                {
                    PrintExtensions.Print(bytesValue, DataManager.printerPath);
                }
                catch
                {
                    MessageBox.Show("برجاء فحص الطابعة");
                }
            }
        }
        private string CutPage()
        {
            ;

            string GS = Convert.ToString((char)29);
            string ESC = Convert.ToString((char)27);
            string COMMAND = "";
            COMMAND = ESC + "@";
            COMMAND += GS + "V" + (char)48;
            return COMMAND;
        }
        private void categoriesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadDrinks(1);
                editCategoriesCombo.Enabled = true;
                savingEditButton.Enabled = true;
                productNameCombo.Enabled = true;
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
                editCategoriesCombo.Enabled = false;
                savingEditButton.Enabled = false;
                productNameCombo.Enabled = true;
            }
            tabControl1.Show();
        }

        private void savingEditButton_Click(object sender, EventArgs e)
        {
            if (checkConstrain())
            {
                updateMenu();
                MessageBox.Show("تم الحفظ بنجاح");
                tabControl1.Hide();
                categoriesCombo.Text = "";
                //  goToSystemManagerForm();
            }
            else
            {
                MessageBox.Show("يجب ادخال سعر للمشروبات صحيح");
            }
        }

        void updateMenu()
        {
            int indexCounter = 0;
            foreach (var drink in DataManager.menu[editCategoriesCombo.SelectedItem.ToString()])
            {

                drink.price = editingProductsGrid.Rows[indexCounter].Cells["السعر"].Value.ToString();
                indexCounter++;

            }
            DataManager.updateMenuData();

        }

        bool checkConstrain()
        {
            for (int i = 0; i < editingProductsGrid.Rows.Count - 1; i++)
            {
                try
                {
                    var value = double.Parse(editingProductsGrid.Rows[i].Cells["السعر"].Value.ToString());
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        bool checkConstrainForAdding()
        {
            if (productNameText.Text.Count() == 0 || productPriceText.Text.Count() == 0)
            {
                MessageBox.Show("يجب ملىء جميع الحقول");
                return false;
            }
            else
            {
                try
                {
                    var price = double.Parse(productPriceText.Text);
                    return true;
                }
                catch
                {
                    MessageBox.Show("يجب ادخال سعر رقمى");
                    return false;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var item in DataManager.menu[categoriesCombo.SelectedItem.ToString()])
            {
                if (item.name == productNameCombo.SelectedItem.ToString())
                {
                    DataManager.menu[categoriesCombo.SelectedItem.ToString()].RemoveAt(index);
                    DataManager.updateMenuData();
                    MessageBox.Show("تم المسح");
                    productNameCombo.Text = "";
                    deleteButton.Enabled = false;
                    tabControl1.Hide();
                    categoriesCombo.Text = "";
                    break;
                }
                index++;
            }

        }

        private void addingProductButton_Click(object sender, EventArgs e)
        {
            if (checkConstrainForAdding())
            {
                Drink drink = new Drink();
                drink.name = productNameText.Text;
                drink.price = productPriceText.Text;
                DataManager.menu[productTypeCombo.Text.ToString()].Add(drink);
                try
                {
                    DataManager.updateMenuData();
                    MessageBox.Show("تمت الاضافة");
                }
                catch
                {
                    MessageBox.Show("يوجد صنف بنفس الاسم");
                }
                productTypeCombo.Text = "";
                productNameText.Text = "";
                productPriceText.Text = "";
                productNameText.Enabled = false;
                productPriceText.Enabled = false;
                addingProductButton.Enabled = false;
                tabControl1.Hide();
                categoriesCombo.Text = "";
            }
        }

        private void productNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            productNameText.Enabled = false;
            productPriceText.Enabled = false;
            addingProductButton.Enabled = false;
        }

        private void productTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            productNameText.Enabled = true;
        }

        private void productNameText_TextChanged(object sender, EventArgs e)
        {
            productPriceText.Enabled = true;
        }

        private void productPriceText_TextChanged(object sender, EventArgs e)
        {
            addingProductButton.Enabled = true;
        }

        private void editCategoriesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadDrinks(2);
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
            }
        }

        private void printingDailyButton_Click(object sender, EventArgs e)
        {
            getDailyReport();
        }
    }
}
