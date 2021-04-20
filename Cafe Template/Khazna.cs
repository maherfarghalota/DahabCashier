using System.Windows.Forms;
using Cafe_Template.Models;
using System;
using System.Linq;

namespace Cafe_Template
{
    public partial class Khazna : UserControl
    {
        public Khazna()
        {
            InitializeComponent();
            DataManager.loadProductsData();
            DataManager.loadProductsExportData();
            DataManager.loadOrdersData();
            countStatisticalData();
            loadComboBoxData();
            buyAddButton.Enabled = false;
            buyPriceText.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void loadComboBoxData()
        {
            buyProductsCombo.Items.Clear();
            addProductsCombo.Items.Clear();
            buyProductsCombo.Text = "";
            addProductsCombo.Text = "";
            foreach (var item in DataManager.products)
            {
                buyProductsCombo.Items.Add(item);
                addProductsCombo.Items.Add(item);
            }
        }

        public void countStatisticalData()
        {
            double sadyratSum = 0.0;
            double md5latSum = 0.0;
            var orders = DataManager.orders.Where(item => item.Key.Contains(DateTime.Now.ToString("dd/MM/yyyy"))).Select(i => i.Value);
            var products = DataManager.productsExport.Where(item => item.Key.Contains(DateTime.Now.ToString("dd/MM/yyyy"))).Select(i => i.Value);

            if (orders.Count() > 0)
            {
                foreach (var dayItem in orders)
                {
                    foreach (var item in dayItem)
                    {
                        md5latSum += item.totalPrice;
                    }
                }
            }

            if(products.Count() > 0)
            {
                foreach (var dayItem in products)
                {
                    foreach(var item in dayItem)
                    {
                        var splittedData = item.Split('*');
                        sadyratSum += double.Parse(splittedData[1]);
                    }
                }
            }

            sadyratLabel.Text = sadyratSum.ToString();
            warydtaLabel.Text = md5latSum.ToString();
            elda5lLabel.Text = (md5latSum - sadyratSum).ToString();

           

        }

        private void buyAddButton_Click(object sender, System.EventArgs e)
        {
            if(buyPriceText.Text == "")
            {
                MessageBox.Show("يجب ادخال سعر");
                return;
            }

            DataManager.saveProductExport(buyProductsCombo.Text, buyPriceText.Text, DateTime.Now.ToString("dd/MM/yyyy"));
            DataManager.loadProductsExportData();
            countStatisticalData();
            buyProductsCombo.Text = "";
            buyPriceText.Text = "";
            MessageBox.Show("تم اضافه الطلب بنجاح");

        }

        private void buyProductsCombo_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            buyAddButton.Enabled = true;
            buyPriceText.Enabled = true;
        }

        private void addAddButton_Click(object sender, EventArgs e)
        {
            if(addNameText.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم المنتج");
                return;
            }

            DataManager.products.Add(addNameText.Text);
            DataManager.updateProductsData();
            addNameText.Text = "";
            MessageBox.Show("تم الاضافه");
            loadComboBoxData();
        }

        private void addProductsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataManager.products.Remove(addProductsCombo.Text);
            DataManager.updateProductsData();
            addProductsCombo.Text = "";
            MessageBox.Show("تم المسح");
            loadComboBoxData();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            countStatisticalData();
        }
    }
}
