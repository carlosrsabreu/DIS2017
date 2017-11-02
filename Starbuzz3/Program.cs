//
// STARBUZZ 3
//
using System;

namespace Starbuzz3
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "------------------------" );
            Console.WriteLine( "- STARBUZZ 3 -" );

            Console.WriteLine( "------------------------" );
            Coffee coffee = new Coffee();
            coffee.PrepareRecipe();

            Console.WriteLine( "------------------------" );
            Tea tea = new Tea();
            tea.PrepareRecipe();

            Console.In.ReadLine();
        }
    }
}
