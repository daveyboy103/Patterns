using System;
using System.Runtime.InteropServices;

namespace Delegates.Patterns.Template
{
    public abstract class Sandwich
    {
        public void MakeSandwich()
        {
            CutBread();
            ButterBread();
            AddCondiments();
            SliceBread();
            Wrap();
        }

        protected virtual void CutBread()
        {
            Console.WriteLine("Base cut");
        } 
        
        protected virtual void ButterBread()
        {
            Console.WriteLine("Base butter");
        } 
        protected virtual void AddCondiments()
        {
            Console.WriteLine("Base condiments");
        } 
        protected virtual void SliceBread()
        {
            Console.WriteLine("Base slice");
        }
        
        protected virtual void Wrap()
        {
            Console.WriteLine("Base wrap");
        } 
    }
    
    public class StandardSandwich: Sandwich {}

    public class DrySandwich : Sandwich
    {
        protected override void ButterBread()
        {
            Console.WriteLine("No butter for me!");
        }
    }
}