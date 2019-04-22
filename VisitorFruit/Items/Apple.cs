using VisitorFruit.Interfaces;

namespace VisitorFruit.Items
{
    public class Apple : IItem
    {
        public string AcceptOperation(IOperation operation)
        {
            return operation.DoOperation(this);
        }
    }
}