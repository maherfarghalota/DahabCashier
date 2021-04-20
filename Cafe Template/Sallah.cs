using Cafe_Template.Models;
using PrinterUtility;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafe_Template
{
    public partial class Sallah : UserControl
    {
        string selectedTarabyza = "";
        string typeOfDrinks = "";

        public Sallah()
        {
            InitializeComponent();
            DataManager.loadMenuData();
            if (AdminManager.adminAccess)
            {
                authLabel.Hide();
                authPasswordText.Hide();
            }
            //    DataManager.loadPaths();
            //orderGridView.Hide();
            label4.Hide();
            label5.Hide();
            asnafPanel.Hide();
            categoriesPanel.Hide();
            button21.Hide();
            discountPanel.Visible = false;

            drinksGridView.ColumnCount = 2;
            drinksGridView.Columns[0].Name = "المشروب";
            drinksGridView.Columns[1].Name = "الكميه";

            orderGridView.ColumnCount = 3;
            orderGridView.Columns[0].Name = "المشروب";
            orderGridView.Columns[1].Name = "الكميه";
            orderGridView.Columns[2].Name = "السعر";

        }

        private void switchTablesButton_Click(object sender, EventArgs e)
        {
            var switchTablesForm = new SwitchTables();
            switchTablesForm.ShowDialog();
        }

        private void table1_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "1";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table2_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "2";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table3_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "3";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table4_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "4";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table5_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "5";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table6_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "6";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table7_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "7";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table8_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "8";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table9_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "9";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table10_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "10";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table11_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "11";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table12_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "12";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table13_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "13";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            if (selectedTarabyza == "")
            {
                MessageBox.Show("ارجو اختيار الطرابيظه");
                return;
            }

            typeOfDrinks = "مشروبات ساخنه";
            try
            {
                loadDrinks();
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
                return;
            }
            asnafPanel.Show();
        }

        private void coldButton_Click(object sender, EventArgs e)
        {
            if (selectedTarabyza == "")
            {
                MessageBox.Show("ارجو اختيار الطرابيظه");
                return;
            }

            typeOfDrinks = "مشروبات بارده";
            try
            {
                loadDrinks();
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
                return;
            }
            asnafPanel.Show();
        }

        private void sheshaButton_Click(object sender, EventArgs e)
        {
            if (selectedTarabyza == "")
            {
                MessageBox.Show("ارجو اختيار الطرابيظه");
                return;
            }

            typeOfDrinks = "شيشة";
            try
            {
                loadDrinks();
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
                return;
            }
            asnafPanel.Show();
        }

        private void foodButton_Click(object sender, EventArgs e)
        {

            if (selectedTarabyza == "")
            {
                MessageBox.Show("ارجو اختيار الطرابيظه");
                return;
            }

            typeOfDrinks = "وجبات";
            try
            {
                loadDrinks();
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
                return;
            }
            asnafPanel.Show();
        }

        private void playstationButton_Click(object sender, EventArgs e)
        {
            if (selectedTarabyza == "")
            {
                MessageBox.Show("ارجو اختيار الطرابيظه");
                return;
            }

            typeOfDrinks = "بلاي ستيشن";
            try
            {
                loadDrinks();
            }
            catch
            {
                MessageBox.Show("هذه الفئة فارغة، برجاء اضافة اصناف بها اولا");
                return;
            }
            asnafPanel.Show();
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            //orderGridView.Hide();
            label4.Hide();
            label5.Hide();
            asnafPanel.Hide();
            categoriesPanel.Hide();
            button21.Hide();
            discountPanel.Visible = false;
            orderGridView.Rows.Clear();
            selectedTarabyza = "";
        }

        private void payButton_Click(object sender, EventArgs e)
        {

            if (checkValideOrder())
            {
                printing();
                DataManager.saveOrder(salaManager.popSelectedOrder(selectedTarabyza));
                DataManager.loadOrdersData();
                label4.Text = "No Order Yet";
                label5.Text = "No Order Yet";
                asnafPanel.Hide();
                categoriesPanel.Hide();
                //orderGridView.Hide();
                orderGridView.Rows.Clear();
                label4.Hide();
                label5.Hide();
                button21.Hide();
                if (selectedTarabyza == "1")
                {
                    table1.BackColor = Color.White;
                }
                else if (selectedTarabyza == "2")
                {
                    table2.BackColor = Color.White;
                }
                else if (selectedTarabyza == "3")
                {
                    table3.BackColor = Color.White;
                }
                else if (selectedTarabyza == "4")
                {
                    table4.BackColor = Color.White;
                }
                else if (selectedTarabyza == "5")
                {
                    table5.BackColor = Color.White;
                }
                else if (selectedTarabyza == "6")
                {
                    table6.BackColor = Color.White;
                }
                else if (selectedTarabyza == "7")
                {
                    table7.BackColor = Color.White;
                }
                else if (selectedTarabyza == "8")
                {
                    table8.BackColor = Color.White;
                }
                else if (selectedTarabyza == "9")
                {
                    table9.BackColor = Color.White;
                }
                else if (selectedTarabyza == "10")
                {
                    table10.BackColor = Color.White;
                }
                else if (selectedTarabyza == "11")
                {
                    table11.BackColor = Color.White;
                }
                else if (selectedTarabyza == "12")
                {
                    table12.BackColor = Color.White;
                }
                else if (selectedTarabyza == "13")
                {
                    table13.BackColor = Color.White;
                }
                else if (selectedTarabyza == "14")
                {
                    table14.BackColor = Color.White;
                }
                else if (selectedTarabyza == "15")
                {
                    table15.BackColor = Color.White;
                }
                else if (selectedTarabyza == "16")
                {
                    table16.BackColor = Color.White;
                }
                else if (selectedTarabyza == "17")
                {
                    table17.BackColor = Color.White;
                }
                else if (selectedTarabyza == "18")
                {
                    table18.BackColor = Color.White;
                }
                else if (selectedTarabyza == "19")
                {
                    table19.BackColor = Color.White;
                }
                else if (selectedTarabyza == "20")
                {
                    table20.BackColor = Color.White;
                }
                else if (selectedTarabyza == "21")
                {
                    table21.BackColor = Color.White;
                }
                else if (selectedTarabyza == "22")
                {
                    table22.BackColor = Color.White;
                }
                else if (selectedTarabyza == "23")
                {
                    table23.BackColor = Color.White;
                }
                else if (selectedTarabyza == "24")
                {
                    table24.BackColor = Color.White;
                }
                else if (selectedTarabyza == "25")
                {
                    table25.BackColor = Color.White;
                }
                else if (selectedTarabyza == "26")
                {
                    table26.BackColor = Color.White;
                }
                selectedTarabyza = "";
            }
            else
            {
                MessageBox.Show("يجب طلب الاوردر اولا");
            }
        }

        void loadDrinks()
        {
            drinksGridView.Rows.Clear();
            int n = -1;
            if (DataManager.menu[typeOfDrinks].Count == 0)
                throw new Exception();

            foreach (var drink in DataManager.menu[typeOfDrinks])
            {
                n = drinksGridView.Rows.Add();
                drinksGridView.Rows[n].Cells[0].Value = drink.name;
                drinksGridView.Rows[n].Cells[0].ReadOnly = true;
                drinksGridView.Rows[n].Cells[1].Value = "0";
            }
        }

        void displayOrderDetails()
        {
            foreach (var item in salaManager.liveOrders)
            {
                if (item.tarabyza == selectedTarabyza)
                {
                    //DisplayTarabyza details
                    return;
                }
            }
        }

        bool checkOrderConstrain()
        {
            int counter = 0;
            for (int i = 0; i < drinksGridView.Rows.Count - 1; i++)
            {
                try
                {
                    var value = int.Parse(drinksGridView.Rows[i].Cells["الكميه"].Value.ToString());
                    if (value < 0)
                        return false;
                    else if (value == 0)
                        counter++;

                }
                catch
                {
                    return false;
                }
            }
            if (counter == drinksGridView.Rows.Count - 1)
                return false;

            return true;
        }

        void addDrinksToOrder()
        {
            foreach (var item in salaManager.liveOrders)
            {
                if (item.tarabyza == selectedTarabyza)
                {
                    for (int i = 0; i < drinksGridView.Rows.Count - 1; i++)
                    {
                        if (drinksGridView.Rows[i].Cells["الكميه"].Value.ToString() == "0")
                            continue;
                        string drinkName = drinksGridView.Rows[i].Cells["المشروب"].Value.ToString();
                        string drinkAmount = drinksGridView.Rows[i].Cells["الكميه"].Value.ToString();

                        if (item.drinks.ContainsKey(drinkName))
                        {
                            item.drinks[drinkName].amount += int.Parse(drinkAmount);
                        }
                        else
                        {
                            Drink drink = new Drink();
                            drink.name = drinkName;
                            drink.amount = int.Parse(drinkAmount);
                            drink.price = DataManager.menu[typeOfDrinks][i].price;
                            item.drinks.Add(drinkName, drink);
                        }
                    }

                    return;
                }
            }

            //----------------------------------------

            Order newOrder = new Order();
            newOrder.date = DateTime.Now;
            newOrder.discount = 0.0;
            newOrder.tarabyza = selectedTarabyza;

            for (int i = 0; i < drinksGridView.Rows.Count - 1; i++)
            {
                if (drinksGridView.Rows[i].Cells["الكميه"].Value.ToString() == "0")
                    continue;
                string drinkName = drinksGridView.Rows[i].Cells["المشروب"].Value.ToString();
                string drinkAmount = drinksGridView.Rows[i].Cells["الكميه"].Value.ToString();

                Drink drink = new Drink();
                drink.name = drinkName;
                drink.amount = int.Parse(drinkAmount);
                drink.price = DataManager.menu[typeOfDrinks][i].price;
                newOrder.drinks.Add(drinkName, drink);

            }
            salaManager.liveOrders.Add(newOrder);


        }

        void reloadOrderData()
        {
            string orderDetails = "";
            for (int i = 0; i < salaManager.liveOrders.Count; i++)
            {
                if (salaManager.liveOrders[i].tarabyza == selectedTarabyza)
                {
                    orderDetails += "Date is  " + salaManager.liveOrders[i].date.ToString() + "  and  " + "Table  " + selectedTarabyza + "  ";
                    label4.Text = orderDetails;
                    double totalPrice = 0.0;
                    int n = -1;
                    orderGridView.Rows.Clear();
                    foreach (var drink in salaManager.liveOrders[i].drinks)
                    {
                        n = orderGridView.Rows.Add();
                        double drinkTotalPrice = double.Parse(drink.Value.amount.ToString()) * double.Parse(drink.Value.price);
                        orderGridView.Rows[n].Cells[0].Value = drink.Key;
                        orderGridView.Rows[n].Cells[1].Value = drink.Value.amount.ToString();
                        orderGridView.Rows[n].Cells[2].Value = drinkTotalPrice.ToString();
                        orderGridView.Rows[n].Cells[0].ReadOnly = true;
                        orderGridView.Rows[n].Cells[1].ReadOnly = true;
                        orderGridView.Rows[n].Cells[2].ReadOnly = true;
                        totalPrice += drinkTotalPrice;
                    }
                    salaManager.liveOrders[i].price = totalPrice;
                    salaManager.liveOrders[i].taxPrice = (totalPrice * salaManager.liveOrders[i].tax);
                    salaManager.liveOrders[i].servicePrice = (totalPrice + salaManager.liveOrders[i].taxPrice) * salaManager.liveOrders[i].service;
                    salaManager.liveOrders[i].totalPrice = (totalPrice + salaManager.liveOrders[i].servicePrice + salaManager.liveOrders[i].taxPrice) - salaManager.liveOrders[i].discount;
                    label5.Text = "Price : " + salaManager.liveOrders[i].price.ToString() + "  Discount: " + salaManager.liveOrders[i].discount.ToString() + "Tax price : " + salaManager.liveOrders[i].taxPrice.ToString() + "service price : " + salaManager.liveOrders[i].servicePrice.ToString() + "  Total Price : " + salaManager.liveOrders[i].totalPrice.ToString();
                    return;
                }
            }
            label4.Text = "No Order Yet";
            label5.Text = "No Order Yet";
            orderGridView.Rows.Clear();
        }

        bool checkValideOrder()
        {
            foreach (var item in salaManager.liveOrders)
            {
                if (item.tarabyza == selectedTarabyza && item.drinks.Count > 0)
                    return true;
            }
            return false;
        }

        bool checkValideDiscount()
        {
            try
            {
                var value = double.Parse(discountPersentageTextBox.Text);
                if (value < 0 || value > 100)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void addToOrdersButton_Click(object sender, EventArgs e)
        {
            if (selectedTarabyza == "")
            {
                MessageBox.Show("ارجو اختيار ترابيزه");
                return;
            }

            if (typeOfDrinks == "")
            {
                MessageBox.Show("ارجو اختيار نوع المشروب");
                return;
            }


            if (checkOrderConstrain())
            {
                addDrinksToOrder();
                reloadOrderData();
                orderGridView.Show();
                label4.Show();
                label5.Show();
                button21.Show();
                asnafPanel.Hide();
                if (selectedTarabyza == "1")
                {
                    table1.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "2")
                {
                    table2.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "3")
                {
                    table3.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "4")
                {
                    table4.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "5")
                {
                    table5.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "6")
                {
                    table6.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "7")
                {
                    table7.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "8")
                {
                    table8.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "9")
                {
                    table9.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "10")
                {
                    table10.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "11")
                {
                    table11.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "12")
                {
                    table12.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "13")
                {
                    table13.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "14")
                {
                    table14.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "15")
                {
                    table15.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "16")
                {
                    table16.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "17")
                {
                    table17.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "18")
                {
                    table18.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "19")
                {
                    table19.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "20")
                {
                    table20.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "21")
                {
                    table21.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "22")
                {
                    table22.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "23")
                {
                    table23.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "24")
                {
                    table24.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "25")
                {
                    table25.BackColor = Color.Red;
                }
                else if (selectedTarabyza == "26")
                {
                    table26.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال كميه للمشروبات صحيح");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkValideOrder())
            {
                //check login admin
                discountPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("يجب طلب الاوردر اولا");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (!AdminManager.adminAccess)
            {
                if (!(authPasswordText.Text == "152000"))
                {
                    MessageBox.Show("باسوورد غير صحيح");
                    return;
                }
            }
            if (checkValideDiscount())
            {
                foreach (var item in salaManager.liveOrders)
                {
                    if (item.tarabyza == selectedTarabyza)
                    {
                        item.discount = item.price * (double.Parse(discountPersentageTextBox.Text) / 100);
                        reloadOrderData();
                        discountPanel.Visible = false;
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("يجب ادخال قيمه ما بين 0 و 100");
            }
        }

        private string CutPage()
        {
            //List<Byte> oby = new List<byte>();
            ////oby.Add(Convert.ToByte(Convert.ToChar(0x1D)));
            ////oby.Add((byte)5);
            //oby.Add(Convert.ToByte(Convert.ToString((char)27)));
            //oby.Add(Convert.ToByte('@'));
            //oby.Add(Convert.ToByte(Convert.ToString((char)29)));
            //oby.Add(Convert.ToByte('V'));
            //oby.Add((byte)80);

            string GS = Convert.ToString((char)29);
            string ESC = Convert.ToString((char)27);
            string COMMAND = "";
            COMMAND = ESC + "@";
            COMMAND += GS + "V" + (char)48;
            return COMMAND;
        }
        private void printing()
        {
            PrinterUtility.EscPosEpsonCommands.EscPosEpson tempObj = new PrinterUtility.EscPosEpsonCommands.EscPosEpson();
            var bytesValue = tempObj.CharSize.DoubleWidth6();
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Center());
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.FontSelect.FontC());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Dahab Cafe\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.Nomarl());
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.DoubleWidth4());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Invoice\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.CharSize.DoubleWidth2());
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Left());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Date: " + DateTime.Now.ToString() + "\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Table Number: " + selectedTarabyza + "\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Item    Quantity    Net    Total\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
            double totalPrice = 0.0;
            int selectedTarabezaIndex = 0;
            for (int i = 0; i < salaManager.liveOrders.Count; i++)
            {
                if (salaManager.liveOrders[i].tarabyza == selectedTarabyza)
                {
                    selectedTarabezaIndex = i;
                    // salaManager.liveOrders[i]
                    foreach (var drink in salaManager.liveOrders[i].drinks)
                    {
                        double drinkTotalPrice = double.Parse(drink.Value.amount.ToString()) * double.Parse(drink.Value.price);
                        bytesValue = PrintExtensions.AddBytes(bytesValue, string.Format("{0, -40}{1, 6}{2, 9}{3, 9:N2}\n", drink.Value.name, drink.Value.amount, drink.Value.price, drinkTotalPrice.ToString()));
                        totalPrice += drinkTotalPrice;
                    }

                    break;
                }
            }
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Right());
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Separator());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Price : " + salaManager.liveOrders[selectedTarabezaIndex].price.ToString() + "\n"));
            //bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes(totalPrice.ToString() + "\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Tax : " + salaManager.liveOrders[selectedTarabezaIndex].taxPrice + "\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Service : " + salaManager.liveOrders[selectedTarabezaIndex].servicePrice + "\n"));
            if (salaManager.liveOrders[selectedTarabezaIndex].discount != 0)
            {
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Discount : " + salaManager.liveOrders[selectedTarabezaIndex].discount.ToString() + "\n"));
                //bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes());
                bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Total After Discount : " + salaManager.liveOrders[selectedTarabezaIndex].totalPrice + "\n"));
                //bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes((totalPrice + "\n"));
            }
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Total : " + salaManager.liveOrders[selectedTarabezaIndex].totalPrice + "\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Center());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("-------Thanks for Coming-------\n\n\n\n\n\n"));
            //bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes("Mina w Mahoraaaaa\n"));
            bytesValue = PrintExtensions.AddBytes(bytesValue, tempObj.Alignment.Left());
            bytesValue = PrintExtensions.AddBytes(bytesValue, Encoding.ASCII.GetBytes(CutPage()));
            byte[] openDrawer = new byte[5]
            {
                (byte) 27,
                (byte) 112,
                (byte) 0,
                (byte)25,
                (byte)250
            };
            bytesValue = PrintExtensions.AddBytes(bytesValue, openDrawer);
            // PrinterUtility.PrintExtensions.Print(bytesValue, Cafe_Template.Properties.Settings.Default.PrinterPath);
            try
            {
                PrinterUtility.PrintExtensions.Print(bytesValue, DataManager.printerPath);
            }
            catch
            {
                MessageBox.Show("برجاء فحص الطابعة");
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            if (!checkValideOrder())
            {
                MessageBox.Show("برجاء اختيار الاوردر");
                return;
            }
            reloadOrderData();
            printing();
        }

        private void table14_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "14";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table15_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "15";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table16_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "16";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table17_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "17";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table18_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "18";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table19_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "19";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table20_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "20";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table21_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "21";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table22_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "22";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table23_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "23";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table24_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "24";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table25_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "25";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void table26_Click(object sender, EventArgs e)
        {
            selectedTarabyza = "26";
            reloadOrderData();
            drinksGridView.Rows.Clear();
            categoriesPanel.Show();
        }

        private void voidButton_Click(object sender, EventArgs e)
        {
            if (selectedTarabyza != "")
            {
                if (selectedTarabyza == "1")
                {
                    table1.BackColor = Color.White;
                }
                else if (selectedTarabyza == "2")
                {
                    table2.BackColor = Color.White;
                }
                else if (selectedTarabyza == "3")
                {
                    table3.BackColor = Color.White;
                }
                else if (selectedTarabyza == "4")
                {
                    table4.BackColor = Color.White;
                }
                else if (selectedTarabyza == "5")
                {
                    table5.BackColor = Color.White;
                }
                else if (selectedTarabyza == "6")
                {
                    table6.BackColor = Color.White;
                }
                else if (selectedTarabyza == "7")
                {
                    table7.BackColor = Color.White;
                }
                else if (selectedTarabyza == "8")
                {
                    table8.BackColor = Color.White;
                }
                else if (selectedTarabyza == "9")
                {
                    table9.BackColor = Color.White;
                }
                else if (selectedTarabyza == "10")
                {
                    table10.BackColor = Color.White;
                }
                else if (selectedTarabyza == "11")
                {
                    table11.BackColor = Color.White;
                }
                else if (selectedTarabyza == "12")
                {
                    table12.BackColor = Color.White;
                }
                else if (selectedTarabyza == "13")
                {
                    table13.BackColor = Color.White;
                }
                else if (selectedTarabyza == "14")
                {
                    table14.BackColor = Color.White;
                }
                else if (selectedTarabyza == "15")
                {
                    table15.BackColor = Color.White;
                }
                else if (selectedTarabyza == "16")
                {
                    table16.BackColor = Color.White;
                }
                else if (selectedTarabyza == "17")
                {
                    table17.BackColor = Color.White;
                }
                else if (selectedTarabyza == "18")
                {
                    table18.BackColor = Color.White;
                }
                else if (selectedTarabyza == "19")
                {
                    table19.BackColor = Color.White;
                }
                else if (selectedTarabyza == "20")
                {
                    table20.BackColor = Color.White;
                }
                else if (selectedTarabyza == "21")
                {
                    table21.BackColor = Color.White;
                }
                else if (selectedTarabyza == "22")
                {
                    table22.BackColor = Color.White;
                }
                else if (selectedTarabyza == "23")
                {
                    table23.BackColor = Color.White;
                }
                else if (selectedTarabyza == "24")
                {
                    table24.BackColor = Color.White;
                }
                else if (selectedTarabyza == "25")
                {
                    table25.BackColor = Color.White;
                }
                else if (selectedTarabyza == "26")
                {
                    table26.BackColor = Color.White;
                }
                selectedTarabyza = "";
                Order tempOrder = salaManager.popSelectedOrder(selectedTarabyza);
                DataManager.loadOrdersData();
                clearSelectionButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("برجاء اختيار الطرابيزة اولا");
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cellCollection = orderGridView.SelectedCells;
            if (cellCollection.Count != 1)
            {
                MessageBox.Show("برجاء اختيار صنف واحد لمسحه");
                return;
            }
            var selectedProduct = cellCollection[0].Value.ToString();
            foreach (var order in salaManager.liveOrders)
            {
                if (order.tarabyza == selectedTarabyza)
                {
                    foreach (var item in order.drinks)
                    {
                        if (item.Key == selectedProduct)
                        {
                            Order tempOrder = order;
                            salaManager.liveOrders.Remove(order);
                            tempOrder.drinks.Remove(selectedProduct);
                            salaManager.liveOrders.Add(tempOrder);
                            orderGridView.Rows.Clear();
                            reloadOrderData();
                            return;
                        }
                    }
                }
            }
        }
    }
}
