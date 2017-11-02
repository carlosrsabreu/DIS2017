//
// STARBUZZ 2
//
using System;

namespace Starbuzz2
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.Out.WriteLine( "------------------------" );
            Console.Out.WriteLine( "- STARBUZZ 2 -" );

            Console.Out.WriteLine( "------------------------" );
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.Out.WriteLine( "------------------------" );
            Tea tea = new Tea();
            tea.PrepareRecipe();

            Console.In.ReadLine();
        }
    }
}
