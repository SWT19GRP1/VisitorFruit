using VisitorFruit.Interfaces;
using VisitorFruit.Items;

namespace VisitorFruit.Operations
{
    public class Eat : IOperation
    {
        public string DoOperation(Banana item)
        {
            return "Took a bite of the banana!";
        }

        public string DoOperation(Apple item)
        {
            return "Took a bite of the apple!";
        }
        public string DoOperation(Pear item)
        {
            return "You ate a Pear";
        }
    }
}