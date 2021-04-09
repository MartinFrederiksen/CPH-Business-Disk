namespace week8
{
    public class rangeValueSet : IValueSet
    {
        private bool mightBeUndefined;
        private int floor;
        private int roof;

        public rangeValueSet(bool mightBeUndefined, int floor, int roof)
        {
            this.mightBeUndefined = mightBeUndefined;
            this.floor = floor;
            this.roof = roof;
        }
        public bool canBeUndefined()
        {
            return mightBeUndefined;
        }

        public bool contains(int value)
        {
            return floor <= value && value < roof;
        }

        /*
            this: 10 ... 20
            other: 0 ... 100
        */

        public bool subsetOf(IValueSet valueSet)
        {
            if(valueSet.GetType().IsInstanceOfType(typeof(rangeValueSet)))
            {
                var other = (rangeValueSet)valueSet;
                if(this.mightBeUndefined && !other.mightBeUndefined) return false;
                if(other.floor <= this.floor && this.roof <= other.roof) return true;
            }
            return false;
        }
    }
}