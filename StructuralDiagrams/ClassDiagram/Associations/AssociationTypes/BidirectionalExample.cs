using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class BidirectionalExample
    {
    }
    class Guest
    {
        public Restaurant host { get; set; }
        public Guest(Restaurant r)
        {
            host = r;
        }
    }
    class Restaurant
    {
        public Guest[] clients { get; set; }
        public Restaurant()
        {
            clients = new Guest[50];
        }
    }
}
