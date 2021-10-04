namespace Delegates.Patterns.Vistor
{
    public class StampDutyVisitor : IVisitor
    {
        public double Visit(IVisitable target)
        {
            if (target is FxTrade) target.Duty = target.Value * 0.12;

            if (target is EquityTrade) target.Duty = target.Value * 0.156;
            
            return target.Value + target.Duty;
        }
    }
}