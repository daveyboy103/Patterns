using Delegates.Patterns.Vistor;

namespace Delegates.Patterns.Decorator
{
    public abstract class ToppingDecorator : IPizza
    {
        protected readonly IPizza _pizza;

        protected ToppingDecorator(){}
        protected ToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public TaxStatus TaxStatus { get; set; }

        public void AddTopping(ToppingDecorator topping)
        {
            _pizza.Description += topping.Description;
            _pizza.Cost += topping.Cost;
        }
    }
}