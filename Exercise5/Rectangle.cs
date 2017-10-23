using System;
using System.Dynamic;
using System.Linq;

namespace Exercise5
{
    public class Rectangle : Shape
    {
        private readonly Point[] mPoints = new Point[4] ;

        public Rectangle( Point aP1, Point aP2, Point aP3, Point aP4 )
        {
            mPoints[0] = aP1;
            mPoints[1] = aP2;
            mPoints[2] = aP3;
            mPoints[3] = aP4;
        }

        public int X
        {
            get
            {
                int x = mPoints[0].X;
                foreach ( var point in mPoints.Skip( 1 ) )
                {
                    x = Math.Min( x, point.X );
                }
                return x;
            }
        }

        public int Y
        {
            get
            {
                int y = mPoints[0].Y;
                foreach ( var point in mPoints.Skip( 1 ) )
                {
                    y = Math.Min( y, point.Y );
                }
                return y;
            }
        }

        public int Width
        {
            get
            {
                int max = mPoints[0].X;
                foreach ( var point in mPoints.Skip( 1 ) )
                {
                    max = Math.Max( max, point.X );
                }
                return max - X;
            }
        }

        public int Height
        {
            get
            {
                int max = mPoints[0].Y;
                foreach ( var point in mPoints.Skip( 1 ) )
                {
                    max = Math.Max( max, point.Y );
                }
                return max - Y;
            }
        }

        public virtual Point this[int aIndex]
        {
            get
            {
                return mPoints[aIndex];
            }
            set
            {
                if ( aIndex < 0 && aIndex > 3 ) throw new IndexOutOfRangeException();
                mPoints[aIndex] = value;
            }
        }

        public override bool IsValid()
        {
            if ( ( mPoints[0].X != X )         || ( mPoints[0].Y != Y ) ) return false;
            if ( ( mPoints[1].X != X + Width ) || ( mPoints[1].Y != Y ) ) return false;
            if ( ( mPoints[2].X != X + Width ) || ( mPoints[2].Y != Y + Height ) ) return false;
            if ( ( mPoints[3].X != X )         || ( mPoints[3].Y != Y + Height ) ) return false;
            return true;
        }

        public override double ComputeArea()
        {
            return Width * Height;
        }
    }
}
