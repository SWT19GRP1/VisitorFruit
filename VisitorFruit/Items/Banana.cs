using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorFruit.Interfaces;

namespace VisitorFruit.Items
{
    public class Banana : IItem
    {     
        public string AcceptOperation(IOperation operation)
        {
           return operation.DoOperation(this);
        }
    }
}
