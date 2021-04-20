using Cafe_Template.Models;
using System;
using System.Windows.Forms;

namespace Cafe_Template
{
    public partial class EditDrinks : Form
    {
        string typeOfDrinks = "";

        public EditDrinks()
        {
            InitializeComponent();
            DataManager.loadMenuData();

            drinksGridView.ColumnCount = 2;
            drinksGridView.Columns[0].Name = "المشروب";
            drinksGridView.Columns[1].Name = "السعر";
        }


        void loadDrinks()
        {
            drinksGridView.Rows.Clear();
            int n = -1;
            foreach (var drink in DataManager.menu[typeOfDrinks])
            {
                n = drinksGridView.Rows.Add();
                drinksGridView.Rows[n].Cells[0].Value = drink.name;
                drinksGridView.Rows[n].Cells[0].ReadOnly = true;
                drinksGridView.Rows[n].Cells[1].Value = drink.price.ToString();
            }
        }

        void updateMenu()
        {
            int indexCounter = 0;
            foreach (var drink in DataManager.menu[typeOfDrinks])
            {
                drink.price = drinksGridView.Rows[indexCounter].Cells["السعر"].Value.ToString();
                indexCounter++;
            }
            DataManager.updateMenuData();
        }

        bool checkConstrain()
        {
            for (int i = 0; i < drinksGridView.Rows.Count - 1; i++)
            {
                try
                {
                    var value = double.Parse(drinksGridView.Rows[i].Cells["السعر"].Value.ToString());
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }



        private void button7_Click(object sender, EventArgs e)
        {
            typeOfDrinks = "مشروبات ساخنه";
            loadDrinks();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            typeOfDrinks = "مشروبات بارده";
            loadDrinks();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditDrinks_Load(object sender, EventArgs e)
        {

        }

        private void SaveGhanges_Click(object sender, EventArgs e)
        {
            if (checkConstrain())
            {
                updateMenu();
            }
            else
            {
                MessageBox.Show("يجب ادخال سعر للمشروبات صحيح");
            }
        }
    }
}
