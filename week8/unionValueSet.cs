namespace week8
{
    public class unionValueSet : IValueSet
    {
        private IValueSet left;
        private IValueSet right;

        public unionValueSet(IValueSet left, IValueSet right)
        {
            this.left = left;
            this.right = right;
        }

        public bool canBeUndefined()
        {
            return left.canBeUndefined() || right.canBeUndefined();
        }

        public bool contains(int value)
        {
            return left.contains(value) || right.contains(value);
        }
    }
}