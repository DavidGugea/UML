using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class CompositionExample
    {
    }

    class Leaf
    {
        public int leafNr { get; set; }
        public Leaf(int nr)
        {
            leafNr = nr;
        }
    }

    class Tree
    {
        private List<Leaf> leaves { get; set; }
        public Tree()
        {
            leaves = new List<Leaf>();
        }

        public void AddLeaf(int nr)
        {
            leaves.Add(new Leaf(nr));
        }
    }
}
