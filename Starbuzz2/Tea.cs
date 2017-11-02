//
// STARBUZZ 2
//
using System;

namespace Starbuzz2
{
    public class Tea : Beverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void SteepTeaBag()
        {
            Console.Out.WriteLine( "Steeping the tea." );
        }

        private void AddLemon()
        {
            Console.Out.WriteLine( "Adding Lemon." );
        }
    }
}
