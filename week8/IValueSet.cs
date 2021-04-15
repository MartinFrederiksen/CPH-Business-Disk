namespace week8
{
    public interface IValueSet
    {
        bool canBeUndefined();
        bool contains(int value);
        bool subsetOf(IValueSet other)
        {
            return false;
        }
        IValueSet union(IValueSet other) 
        {
            return new unionValueSet(this, other);
        }
        IValueSet intersection(IValueSet other)
        {
            return new intersectionValueSet(this, other);
        }
    }
}