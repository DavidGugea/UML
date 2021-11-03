using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace ObjectDiagramProject.RestaurantProject
{
    public enum Stars : int
    {
        one_star = 1,
        two_stars = 2,
        three_stars = 3,
        four_stars = 4,
        five_stars = 5,
    }

    public class Restaurant
    {
        public static Dictionary<string, string> menu = new Dictionary<string, string>()
        {
            { "Menu1", "Something" },
            { "Menu2", "Something else" },
        };

        public Stars category { get; set; }
        public string name { get; set; }
        
        public Dictionary<int, Worker> workers = new Dictionary<int, Worker>();
        public Guest[] guests = new Guest[50];
    }
}
