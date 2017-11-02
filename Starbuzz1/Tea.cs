//
// STARBUZZ 1
//
using System;

namespace Starbuzz1
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void BoilWater()
        {
            Console.Out.WriteLine( "Boiling water." );
        }

        private void SteepTeaBag()
        {
            Console.Out.WriteLine( "Steeping the tea." );
        }

        private void PourInCup()
        {
            Console.Out.WriteLine( "Pouring into cup." );
        }

        private void AddLemon()
        {
            Console.Out.WriteLine( "Adding Lemon." );
        }
    }
}
