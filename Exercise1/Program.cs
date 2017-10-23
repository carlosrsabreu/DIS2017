using System;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {

            int sum = 0;

            Console.WriteLine( "Introduza 10 inteiros: " );
            for ( int i = 1 ; i <= 10 ; )
            {
                Console.Write( "{0} => ", i );

                int value;
                if ( !int.TryParse( Console.ReadLine(), out value ) )
                {
                    Console.WriteLine( "! Wrong value..." );
                }
                else
                {
                    sum += value;
                    i++;
                }
            }

            Console.WriteLine( "Total : {0}", sum );
            Console.WriteLine( "Average : {0}", sum / 10.0 );
            Console.Write( "Press RETURN to continue..." ); Console.ReadKey();
        }
    }
}
