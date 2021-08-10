using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class AggregationExample
    {
    }

    class Chair
    {
        public int chairNr { get; set; }
        public Chair(int nr)
        {
            this.chairNr = chairNr;
        }
    }

    class Restaurant
    {
        public List<Chair> chairs;

        public Restaurant()
        {
            chairs = new List<Chair>();
        }

        public void addChair(Chair s)
        {
            chairs.Add(s);
        }

        public Chair removeChair()
        {
            Chair returnChair = chairs[chairs.Count-1];
            chairs.RemoveAt(chairs.Count - 1);
            return returnChair;
        }
    }
}
