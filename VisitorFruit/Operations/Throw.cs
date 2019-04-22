using VisitorFruit.Interfaces;
using VisitorFruit.Items;

namespace VisitorFruit.Operations
{
    public class Throw : IOperation
    {
        public string DoOperation(Banana item)
        {
            return "You threw the banana, it came back";
        }

        public string DoOperation(Apple item)
        {
            return "You threw the apple, and hit someone in the head";
        }

        public string DoOperation(Pear item)
        {
            return "You threw a Pear";
        }
    }
}