//
// STARBUZZ 3
//
using System;

namespace Starbuzz3
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        { 
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine( "Boiling water." );
        }

        protected void PourInCup()
        {
            Console.WriteLine( "Pouring into cup." );
        }
    }
}
