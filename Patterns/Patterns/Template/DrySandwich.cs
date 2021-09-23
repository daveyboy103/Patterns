using System;

namespace Delegates.Patterns.Template
{
    public class DrySandwich : Sandwich
    {
        protected override void ButterBread()
        {
            Console.WriteLine("No butter for me!");
        }
    }
}