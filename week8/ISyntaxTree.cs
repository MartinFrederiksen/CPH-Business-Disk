namespace week8
{
    public interface ISyntaxTree
    {
        IState analyse(IState condition);
    }
}