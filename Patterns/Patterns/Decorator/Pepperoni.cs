namespace Delegates.Patterns.Decorator
{
    public class Pepperoni : ToppingDecorator
    {
        public Pepperoni()
        {
            Description += "Pepperoni,";
            Cost += 0.45m;
        }
        public Pepperoni(IPizza pizza) : base(pizza)
        {
            _pizza.Description += "Pepperoni,";
            _pizza.Cost += 0.45m;
            Description = _pizza.Description;
            Cost = _pizza.Cost;
        }
    }
}