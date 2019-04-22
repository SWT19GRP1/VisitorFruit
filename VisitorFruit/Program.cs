using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorFruit.Interfaces;
using VisitorFruit.Items;
using VisitorFruit.Operations;

namespace VisitorFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem banana = new Banana();
            IItem apple = new Apple();
            IItem pear = new Pear();

            IOperation operation = new Eat();

            Console.WriteLine(banana.AcceptOperation(operation));
            Console.WriteLine(apple.AcceptOperation(operation));
            Console.WriteLine(pear.AcceptOperation(operation));

            operation = new Throw();

            Console.WriteLine(banana.AcceptOperation(operation));
            Console.WriteLine(apple.AcceptOperation(operation));
            Console.WriteLine(pear.AcceptOperation(operation));
        }
    }
}
