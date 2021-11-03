using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDiagramProject.RestaurantProject
{
    public class Guest
    {
        public static string status = "King";
        private int money { get; set; }
        protected Boolean hunger = true;

        public string order(string menu_name)
        {
            return Restaurant.menu[menu_name];
        }
        public void pay(int price)
        {
            Console.WriteLine(String.Format("The guest has payed {0} for his orders", price));
        }
    }
}
