using VisitorFruit.Interfaces;

namespace VisitorFruit.Items
{
    public class Pear : IItem
    {
        public string AcceptOperation(IOperation operation)
        {
            return operation.DoOperation(this);
        }
    }
}