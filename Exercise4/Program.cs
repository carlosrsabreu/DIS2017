using System;
using System.IO;

namespace Exercise4
{
    class Program
    {
        static void Main( string[] args )
        {
            if ( args.Length < 1 )
            {
                Console.WriteLine( "Usage: Exercise4 <filename>" );
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines( args[0] );
                foreach ( var line in lines )
                {
                    foreach ( var c in line )
                    {
                        if ( char.IsWhiteSpace( c ) ) continue;
                        Console.Write( char.ToUpper( c ) );
                    }
                }

            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception.Message );
            }
            Console.WriteLine();
            Console.Write( "Press RETURN to continue..." ); Console.ReadKey();
        }
    }
}
