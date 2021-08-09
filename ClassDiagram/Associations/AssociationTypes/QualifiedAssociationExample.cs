using System;
using System.Collections.Generic;
using System.Text;

namespace AssociationTypes
{
    class QualifiedAssociationExample
    {
    }

    class Worker
    {
        protected int WorkerID { get; protected set; }
    }
    class Restaurant
    {
        protected List<Worker> Worker;
    }
}
