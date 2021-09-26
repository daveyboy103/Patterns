namespace Delegates.Patterns.Decorator
{
    public class Mushroom : ToppingDecorator
    {
        public Mushroom()
        {
            Description += "Mushroom,";
            Cost += 0.12m;
        }
        public Mushroom(IPizza pizza) : base(pizza)
        {
            _pizza.Description += "Mushroom,";
            _pizza.Cost += 0.12m;
            Description = _pizza.Description;
            Cost = _pizza.Cost;
        }
    }
}