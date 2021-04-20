using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Template.Models
{
    public class Order
    {
        public DateTime date ;
        public string tarabyza = "";
        public double price = 0.0;
        public double discount = 0.0;
        public double totalPrice = 0.0;
        public double tax = 0.14;
        public double service = 0.12;
        public double taxPrice;
        public double servicePrice;
        public bool takeAwy = false;
        public Dictionary<string, Drink> drinks = new Dictionary<string, Drink>();
    }
}
