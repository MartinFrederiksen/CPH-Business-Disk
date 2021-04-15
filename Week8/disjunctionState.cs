namespace week8
{
    public class disjunctionState : IState
    {
        private IState left;
        private IState right;

        public disjunctionState(IState left, IState right) {
            this.left = left;
            this.right = right;
        }

        public IValueSet valuesOf(string variableName)
        {
            throw new System.NotImplementedException();
        }

        public bool subStateOf(IState other)
        {
            throw new System.NotImplementedException();
        }
    }
}