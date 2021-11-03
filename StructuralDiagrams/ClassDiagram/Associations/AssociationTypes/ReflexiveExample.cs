using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class ReflexiveExample
    {
    }
    // REFLEXIVE EXAMPLE
    class Worker
    {
        public Worker Superior { get; set; }
        public Worker[] Subordinates { get; set; }

        public Worker()
        {
            this.Subordinates = new Worker[10];
        }
    }
}
