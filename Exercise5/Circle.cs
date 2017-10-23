using System;

namespace Exercise5
{
    public class Circle : Shape
    {
        public Circle( Point aCenter, double aRadius )
        {
            Center = aCenter;
            Radius = aRadius;
        }

        public Point Center { get; set; }

        public double Radius { get; set; }

        public override bool IsValid()
        {
            return true;
        }

        public override double ComputeArea()
        {
            return Math.PI * Math.Pow( Radius, 2 );
        }
    }
}
