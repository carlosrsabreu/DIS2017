//
// STARBUZZ 3
//
using System;

namespace Starbuzz3
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine( "Steeping the tea." );
        }

        protected override void AddCondiments()
        {
            Console.WriteLine( "Adding Lemon." );
        }
    }
}
