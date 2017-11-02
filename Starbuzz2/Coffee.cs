//
// STARBUZZ 2
//
using System;

namespace Starbuzz2
{
    public class Coffee : Beverage
    {
        public override void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeGrings();
            PourInCup();
            AddSugarAndMilk();
        }


        private void BrewCoffeGrings()
        {
            Console.Out.WriteLine( "Dripping Coffee through filter." );
        }


        private void AddSugarAndMilk()
        {
            Console.Out.WriteLine( "Adding Sugar and Milk." );
        }
    }
}
