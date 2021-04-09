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
        // ValueSet intersection(ValueSet other)
        // {
        //     return new unionValueSet(this, other);
        // }
    }
}