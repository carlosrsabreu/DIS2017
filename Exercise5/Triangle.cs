using System.Collections.Generic;

namespace Exercise5
{
    public class Triangle : Shape
    {
        private readonly Point[] mPoints = new Point[3] ;

        public Triangle( Point aP1, Point aP2, Point aP3 )
        {
            mPoints[0] = aP1;
            mPoints[1] = aP2;
            mPoints[2] = aP3;
        }

        public IEnumerable<Point> Points => mPoints;

        public int Width => mPoints[1].X - mPoints[0].X;

        public int Height => mPoints[0].Y - mPoints[2].Y;

        public override bool IsValid()
        {
            if ( mPoints[0].Y != mPoints[1].Y ) return false;
            if ( mPoints[0].Y <  mPoints[2].Y ) return false;
            return true;
        }

        public override double ComputeArea()
        {
            return Width * Height / 2.0;
        }
    }
}
