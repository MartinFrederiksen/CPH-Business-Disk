using System;

namespace Week4.Utils
{
    public class ComparableTest : IComparable
    {
        public string s;

        public ComparableTest(string s)
        {
            this.s = s;
        }

        public int CompareTo(object obj)
        {
            if(obj == null) return 1;

            if(s.Length > ((ComparableTest)obj).s.Length)
                return 1;
            else if(s.Length < ((ComparableTest)obj).s.Length)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return s;
        }
    }
}