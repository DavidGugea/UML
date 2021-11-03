using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class nary_association_example
    {
    }
    // N-ARY ASSOCIATION EXAMPLE
    class Menu
    {
        public Appetiser appetiser { get; set; }
        public Entree entree { get; set; }
        public Dessert dessert { get; set; }

        public Menu(Appetiser a, Entree e, Dessert d)
        {
            appetiser = a;
            entree = e;
            dessert = d;
        }
    }

    class Entree
    {
        public List<Menu> menus { get; private set; } = new List<Menu>();
    }

    class Dessert
    {
        public List<Menu> menus { get; private set; } = new List<Menu>();
    }

    class Appetiser
    {
        public List<Menu> menus { get; private set; } = new List<Menu>();
    }
}
