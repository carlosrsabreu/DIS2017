using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main( string[] args )
        {
            Stack<int> values = new Stack<int>();

            Console.WriteLine( "Enter 10 integers: " );
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
                    values.Push( value );
                    i++;
                }
            }

            Console.WriteLine( "Values" );
            for ( int i = 1 ; values.Count > 0 ; i++ )
            {
                Console.WriteLine( "{0} => {1}", i, values.Pop() );
            }

            Console.Write( "Press RETURN to continue..." ); Console.ReadKey();
        }
    }
}
