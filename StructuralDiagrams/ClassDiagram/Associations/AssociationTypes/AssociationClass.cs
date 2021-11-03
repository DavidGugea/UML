using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class AssociationClass
    {
    }

    class Waiter
    {
         public List<Order> orders { get; set; }   
    }


    class Chef
    {
        public List<Order> orders { get; set; }
    }
    class Order
    {
        public Waiter waiter { get; set; }
        public Chef chef { get; set; }
    }
}
