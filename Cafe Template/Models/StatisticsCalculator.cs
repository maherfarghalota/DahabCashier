using System.Collections.Generic;
using System.Linq;

namespace Cafe_Template.Models
{
    class StatisticsCalculator
    {

        public static Dictionary<string, int> drinksCalculation(string date)
        {
            Dictionary<string, int> drinksCounter = new Dictionary<string, int>();
            DataManager.loadOrdersData();
            drinksCounter.Clear();



            var orders = DataManager.orders.Where(item => item.Key == date).Select(i => i.Value);
            if (orders.Count() == 0)
            {
                //nothing order in this day to view
                return drinksCounter;
            }

            foreach (var dayOrders in orders)
            {
                foreach (var order in dayOrders)
                {
                    foreach (var drink in order.drinks)
                    {
                        if (drinksCounter.Keys.Contains(drink.Key))
                        {
                            drinksCounter[drink.Key] += drink.Value.amount;
                        }
                        else
                        {
                            drinksCounter.Add(drink.Key, drink.Value.amount);
                        }
                    }
                }

            }

            return drinksCounter;
        }
    }
}
