namespace Exercise5
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point( int aX, int aY )
        {
            X = aX;
            Y = aY;
        }

        public static Point Empty { get; } = new Point( int.MinValue, int.MinValue );

        public static Point Parse( string aX, string aY )
        {
            var point = new Point();

            if ( ! int.TryParse( aX, out point.X ) ) return Empty;
            if ( ! int.TryParse( aY, out point.Y ) ) return Empty;

            return point;
        }

        public static bool TryParse( string aX, string aY, out Point aPoint )
        {
            aPoint.X = aPoint.Y = -1; 
            if ( ! int.TryParse( aX, out aPoint.X ) ) return false;
            if ( ! int.TryParse( aY, out aPoint.Y ) ) return false;

            return true;
        }

        public bool Equals( Point aPoint )
        {
            return X == aPoint.X && Y == aPoint.Y;
        }

        public override bool Equals( object obj )
        {
            if ( ReferenceEquals( null, obj ) ) return false;
            return obj is Point && Equals( (Point) obj );
        }

        public static bool operator == ( Point aP1, Point aP2 )
        {
            return aP1.Equals( aP2 );
        }

        public static bool operator != ( Point aP1, Point aP2 )
        {
            return ! aP1.Equals( aP2 );
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ( X * 397 ) ^ Y;
            }
        }
    }
}
