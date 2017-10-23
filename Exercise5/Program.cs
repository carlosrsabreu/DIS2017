using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Exercise5
{
    class Program
    {
        static void Main( string[] args )
        {
            var shapes = LoadShapes( args[0] );

            double area = 0.0;
            foreach ( var shape in shapes )
            {
                if ( ! shape.IsValid() ) continue;
                area += shape.ComputeArea();
            }
            Console.WriteLine( $"Total Area: { area }");
            Console.ReadKey();
        }

        static List<Shape> LoadShapes( string aFilename )
        {
            var shapes = new List<Shape>();
            try
            {
                StreamReader file = new StreamReader( aFilename );
                for ( var line = file.ReadLine() ; line != null ; line = file.ReadLine() )
                {
                    if ( string.IsNullOrEmpty( line ) || line[0] == '!' ) continue;

                    var values = line.Split( ',' );

                    Shape shape = null;
                    switch ( values.Length )
                    {
                        case 8: shape = ReadRectangle( values );
                            break;
                        case 6: shape = ReadTriangle( values );
                            break;
                        case 4: shape = ReadSquare( values );
                            break;
                        case 3: shape = ReadCircle( values );
                            break;
                    }
                    if ( shape != null ) shapes.Add( shape );
                }
                file.Close();
            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception.Message );
            }
            return shapes;
        }

        private static Shape ReadCircle( string[] values )
        {
            Debug.Assert( values.Length == 3 );
            Console.WriteLine( ".. Reading a Circle" );

            Point center;
            if ( ! Point.TryParse( values[0], values[1], out center ) ) return null;

            int r;
            if ( ! int.TryParse( values[2], out r ) ) return null;

            return new Circle( center, r );
        }

        private static Shape ReadSquare( string[] values )
        {
            Console.WriteLine( ".. Reading a Square" );
            return null;
        }

        private static Shape ReadTriangle( string[] values )
        {
            Debug.Assert( values.Length == 6 );
            Console.WriteLine( ".. Reading a Triangle" );

            Point p1;
            if ( ! Point.TryParse( values[0], values[1], out p1 ) ) return null;

            Point p2;
            if ( ! Point.TryParse( values[2], values[3], out p2 ) ) return null;

            Point p3;
            if ( ! Point.TryParse( values[4], values[5], out p3 ) ) return null;

            return new Triangle( p1, p2, p3  );
        }

        private static Shape ReadRectangle( string[] values )
        {
            Debug.Assert( values.Length == 8 );
            Console.WriteLine( ".. Reading a Rectangle" );

            Point p1;
            if ( ! Point.TryParse( values[0], values[1], out p1 ) ) return null;

            Point p2;
            if ( ! Point.TryParse( values[2], values[3], out p2 ) ) return null;

            Point p3;
            if ( ! Point.TryParse( values[4], values[5], out p3 ) ) return null;

            Point p4;
            if ( ! Point.TryParse( values[6], values[7], out p4 ) ) return null;

            return new Rectangle( p1, p2, p3, p4  );
        }
    }
}
