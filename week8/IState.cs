namespace week8
{
    public interface IState
    {
        IValueSet valuesOf(string variableName);
        bool subStateOf(IState other);
        IState conjunction(IState other) { // and
            return new conjunctionState(this, other);
        }
        // IState disjunction(IState other) { // or
        //     return new disjunction(this, other);
        // }
    }
}