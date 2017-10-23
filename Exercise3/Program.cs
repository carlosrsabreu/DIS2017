using System;

namespace Exercise3
{
    class Program
    {
        static void Main( string[] args )
        {
            int x = ReadInt( "Enter the value of x : " );
            int y = ReadInt( "Enter the value of y : " );

            Console.WriteLine( "The greatest common divisor (GCD) between {0} and {1} is {2}", x, y, GreatestCommonDivisor( x, y ) );
            Console.Write( "Press RETURN to continue..." ); Console.ReadKey();
        }

        private static int GreatestCommonDivisor( int m, int n )
        {
            if ( m < n ) return GreatestCommonDivisor( n, m );
            return ( n == 0 ? m : GreatestCommonDivisor( n, m % n ) );
        }

        private static int ReadInt( string aPrompt )
        {
            while ( true )
            {
                Console.Write( aPrompt );

                int value;
                if ( int.TryParse( Console.ReadLine(), out value ) ) return value;

                Console.WriteLine( "Wrong value. Please, try again." );
            }
        }
    }
}
