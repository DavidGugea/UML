using System;
using System.Collections;
using System.Collections.Generic;
using ObjectDiagramProject.RestaurantProject;

namespace ObjectDiagramProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant favorite_restaurant = new Restaurant()
            {
                category = Stars.five_stars,
                name = "My favorite restaurant"
            };

            Guest maren = new Guest();
            Guest klaudia = new Guest();
        }
    }
}
