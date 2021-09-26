using Delegates.Patterns.Vistor;

namespace Delegates.Patterns.Decorator
{
    public class PlainPizza : IPizza
    {
        public string Description { get; set; } = "Plain Dough & Tomato,";
        public decimal Cost { get; set; } = 4.0m;
        public TaxStatus TaxStatus { get; set; } = TaxStatus.Taxable;

        public void AddTopping(ToppingDecorator topping)
        {
            Description += topping.Description;
            Cost += topping.Cost;
        }
    }
}