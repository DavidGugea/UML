using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectDiagramProject.RestaurantProject
{
    public class Waiter : Worker
    {
        public Guest[] guests = new Guest[5];

        public void serve(Guest guest_to_serve)
        {
            Console.WriteLine(String.Format("Serving {0}", guest_to_serve));
        }

        public void get_check(int money)
        {
            Console.WriteLine(String.Format("Getting {0} money from the last guest.", money));
        }
    }
}
