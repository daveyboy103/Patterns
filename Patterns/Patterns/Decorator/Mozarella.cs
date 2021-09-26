namespace Delegates.Patterns.Decorator
{
    public class Mozarella : ToppingDecorator
    {
        public Mozarella() : base()
        {
            Description += "Mozarella,";
            Cost += 1.24m;
        }
        public Mozarella(IPizza pizza) : base(pizza)
        {
            _pizza.Description += "Mozarella,";
            _pizza.Cost += 1.24m;
            Description = _pizza.Description;
            Cost = _pizza.Cost;
        }
    }
}