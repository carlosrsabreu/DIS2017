//
// STARBUZZ 2
//
using System;

namespace Starbuzz2
{
    public abstract class Beverage
    {
        public abstract void PrepareRecipe();

        protected void BoilWater()
        {
            Console.Out.WriteLine( "Boiling water." );
        }

        protected void PourInCup()
        {
            Console.Out.WriteLine( "Pouring into cup." );
        }
    }
}
