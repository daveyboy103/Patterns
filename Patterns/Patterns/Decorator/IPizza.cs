using Delegates.Patterns.Vistor;

namespace Delegates.Patterns.Decorator
{
    public interface IPizza
    {
        string Description { get; set; }
        decimal Cost { get; set; }
        TaxStatus TaxStatus { get; set; }
        void AddTopping(ToppingDecorator topping);
    }
}