using VisitorFruit.Items;

namespace VisitorFruit.Interfaces
{
    public interface IOperation
    {
        string DoOperation(Banana item);
        string DoOperation(Apple item);

        string DoOperation(Pear item);
    }
}