using System.Buffers;
using System.Reflection;
using System.Runtime.Versioning;

namespace Delegates.Patterns.Vistor
{
    public interface IVisitor
    {
        double Visit(IVisitable target);
    }

    public interface IVisitable
    {
        double Accept(IVisitor visitor);
        double Value { get; set; }
        public double Duty { get; set; }
    }

    public class FxTrade : IVisitable
    {
        public double Accept(IVisitor visitor)
        {
            // throw new System.NotImplementedException();
            return visitor.Visit(this);
        }

        public double Value { get; set; }
        public double Duty { get; set; }
    }
    
    public class EquityTrade : IVisitable
    {
        public double Accept(IVisitor visitor)
        {
            // throw new System.NotImplementedException();
            return visitor.Visit(this);
        }

        public double Value { get; set; }
        public double Duty { get; set; }
    }

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