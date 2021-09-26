using Delegates.Patterns.Decorator;

namespace Delegates.Patterns.Vistor
{
    public static class PizzaExtensions
    {
        public static bool TakeFromInventory(this IPizza pizz , int quaniity)
        {
            return true;
        }
        
        public static bool SetTaxStatus(this IPizza pizza, TaxStatus status)
        {
            bool ret = pizza.TaxStatus == status;
            pizza.TaxStatus = status;

            return ret;
        }
    }
}