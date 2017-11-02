//
// STARBUZZ 1
//
using System;

namespace Starbuzz1
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeGrings();
            PourInCup();
            AddSugarAndMilk();
        }

        private void BoilWater()
        {
            Console.Out.WriteLine( "Boiling water." );
        }

        private void BrewCoffeGrings()
        {
            Console.Out.WriteLine( "Dripping Coffee through filter." );
        }

        private void PourInCup()
        {
            Console.Out.WriteLine( "Pouring into cup." );
        }

        private void AddSugarAndMilk()
        {
            Console.Out.WriteLine( "Adding Sugar and Milk." );
        }
    }
}
