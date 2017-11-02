//
// STARBUZZ 3
//
using System;

namespace Starbuzz3
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine( "Dripping Coffee through filter." );
        }

        protected override void AddCondiments()
        {
            Console.WriteLine( "Adding Sugar and Milk." );
        }
    }
}
