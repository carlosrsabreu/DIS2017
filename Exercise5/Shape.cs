namespace Exercise5
{
    public abstract class Shape : IShape
    {
        public virtual bool IsValid()
        {
            return false;
        }

        public abstract double ComputeArea();
    }
}
