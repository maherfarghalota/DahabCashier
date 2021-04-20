using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Cafe_Template.Models
{
    public class DataManager
    {
        public static Dictionary<string, List<Order>> orders = new Dictionary<string, List<Order>>();
        public static Dictionary<string, List<Drink>> menu = new Dictionary<string, List<Drink>>();
        public static List<User> users = new List<User>();
        public static List<string> products = new List<string>();
        public static Dictionary<string, List<string>> productsExport = new Dictionary<string, List<string>>();
        public static string printerPath = "";

        public static void loadMenuData()
        {
            menu.Clear();
            Drink drink = new Drink();
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "drinks.txt");

            var arrayOfDrinksData = File.ReadAllLines(filePath);
            for (int i = 0; i < arrayOfDrinksData.Count(); i++)
            {
                var originalData = CryptManager.decryptText(arrayOfDrinksData[i]);
                var splittedData = originalData.Split('*');
                List<Drink> listOfDrinks = new List<Drink>();

                int count = 1;
                for (int j = 0; j < ((splittedData.Count() - 1) / 2); j++)
                {
                    drink = new Drink();
                    drink.name = splittedData[count];
                    count++;
                    drink.price = splittedData[count];
                    count++;
                    listOfDrinks.Add(drink);
                }
                menu.Add(splittedData[0], listOfDrinks);
            }
        }
        public static void loadUsersData()
        {

            users.Clear();
            string[] usersDataList;
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "loginData.txt");
            usersDataList = File.ReadAllLines(filePath);
            for (int i = 0; i < usersDataList.Count(); i++)
                usersDataList[i] = CryptManager.decryptText(usersDataList[i]);

            User user;
            for (int i = 0; i < usersDataList.Count(); i++)
            {
                user = new User();
                var userData = usersDataList[i].Split('*');
                user.userName = userData[0];
                user.password = userData[1];
                user.name = userData[2];
                if (i != 0)
                    user.adminAccess = false;
                users.Add(user);
            }
        }
        public static void loadOrdersData()
        {
            orders.Clear();
            string[] ordersDataList;
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ordersData.txt");
            ordersDataList = File.ReadAllLines(filePath);
            Order order;
            for (int i = 0; i < ordersDataList.Count(); i++)
            {
                if (i % 2 != 0)
                    continue;

                ordersDataList[i] = CryptManager.decryptText(ordersDataList[i]);
                ordersDataList[i + 1] = CryptManager.decryptText(ordersDataList[i + 1]);
                var orderHeaderData = ordersDataList[i].Split('*');
                var orderDrinks = ordersDataList[i + 1].Split('*');
                order = new Order();
                order.date = DateTime.Parse(orderHeaderData[0]);
                order.tarabyza = orderHeaderData[1];
                order.price = double.Parse(orderHeaderData[2]);
                order.discount = double.Parse(orderHeaderData[3]);
                order.taxPrice = double.Parse(orderHeaderData[4]);
                order.servicePrice = double.Parse(orderHeaderData[5]);
                order.totalPrice = double.Parse(orderHeaderData[6]);
                Drink drink;
                for (int j = 0; j < orderDrinks.Count(); j++)
                {
                    drink = new Drink();
                    drink.name = orderDrinks[j];
                    j++;
                    drink.price = orderDrinks[j];
                    j++;
                    drink.amount = int.Parse(orderDrinks[j]);
                    order.drinks.Add(drink.name, drink);
                }

                if (orders.ContainsKey(order.date.ToString("dd/MM/yyyy")))
                    orders[order.date.ToString("dd/MM/yyyy")].Add(order);
                else
                {
                    List<Order> listOfOrders = new List<Order>();
                    listOfOrders.Add(order);
                    orders.Add(order.date.ToString("dd/MM/yyyy"), listOfOrders);
                }
            }
        }
        public static void loadProductsData()
        {
            products.Clear();
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "product.txt");
            var arrayOfProductsData = File.ReadAllLines(filePath);
            for (int i = 0; i < arrayOfProductsData.Count(); i++)
            {
                var originalData = CryptManager.decryptText(arrayOfProductsData[i]);
                products.Add(originalData);
            }
        }
        public static void loadProductsExportData()
        {
            productsExport.Clear();
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "exportsDatabase.txt");
            var arrayOfProductsData = File.ReadAllLines(filePath);
            for (int i = 0; i < arrayOfProductsData.Count(); i++)
            {
                var splittedData = arrayOfProductsData[i].Split('*');
                if (productsExport.Keys.Contains(splittedData[2]))
                {
                    productsExport[splittedData[2]].Add(splittedData[0] + "*" + splittedData[1]);
                }
                else
                {
                    var list = new List<string>();
                    list.Add(splittedData[0] + "*" + splittedData[1]);
                    productsExport.Add(splittedData[2], list);
                }
            }
        }
        public static void loadPrinterPath()
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DefultPrinterPath.txt");
            var data = File.ReadAllLines(filePath);
            printerPath = data[0];


        }
        public static void updateUserData()
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "loginData.txt");
            File.WriteAllText(filePath, String.Empty);
            for (int i = 0; i < users.Count(); i++)
            {
                string userData = "";
                userData += users[i].userName + "*";
                userData += users[i].password + "*";
                userData += users[i].name + "*";
                userData += users[i].adminAccess.ToString();
                userData = CryptManager.encryptText(userData);
                using (StreamWriter outputFile = new StreamWriter(filePath, true))
                {
                    outputFile.WriteLine(userData);
                }
            }

            loadUsersData();

        }
        public static void updateMenuData()
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "drinks.txt");
            File.WriteAllText(filePath, String.Empty);



            foreach (var item in menu)
            {
                string userData = item.Key + "*";
                foreach (var drink in item.Value)
                {
                    userData += drink.name + "*";
                    userData += drink.price + "*";
                }
                userData = userData.Remove(userData.Length - 1, 1);
                userData = CryptManager.encryptText(userData);
                using (StreamWriter outputFile = new StreamWriter(filePath, true))
                {
                    outputFile.WriteLine(userData);
                }
            }
        }
        public static void updateProductsData()
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "product.txt");
            File.WriteAllText(filePath, String.Empty);
            foreach (var item in products)
            {

                var cipherText = CryptManager.encryptText(item);
                using (StreamWriter outputFile = new StreamWriter(filePath, true))
                {
                    outputFile.WriteLine(cipherText);
                }
            }
        }
        public static void saveOrder(Order order)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ordersData.txt");
            //order.taxPrice = (order.totalPrice * order.tax);
            //order.servicePrice = (order.totalPrice + order.taxPrice) * order.service;
            string orderHeader = order.date.ToString() + "*" + order.tarabyza + "*" + order.price.ToString() + "*" + order.discount.ToString() + "*" + order.taxPrice + "*" + order.servicePrice + "*" + order.totalPrice.ToString();
            string orderDrinks = "";
            foreach (var drink in order.drinks.Values)
            {
                orderDrinks += drink.name + "*" + drink.price + "*" + drink.amount.ToString() + "*";
            }
            orderDrinks = orderDrinks.Remove(orderDrinks.Length - 1, 1);
            orderDrinks = CryptManager.encryptText(orderDrinks);
            orderHeader = CryptManager.encryptText(orderHeader);
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(orderHeader);
                outputFile.WriteLine(orderDrinks);
            }
        }
        public static void saveProductExport(string productName, string productPrice, string date)
        {
            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "exportsDatabase.txt");
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(productName + "*" + productPrice + "*" + date);
            }
        }

    }
}
