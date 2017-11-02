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

        protected virtual void BoilWater()
        {
            Console.WriteLine( "Boiling water." );
        }

        protected virtual void PourInCup()
        {
            Console.WriteLine( "Pouring into cup." );
        }
    }
}
