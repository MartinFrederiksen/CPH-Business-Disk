using System.Collections.Generic;

namespace week8
{
    public class mappedState : IState
    {
        private Dictionary<string, IValueSet> variables = new Dictionary<string, IValueSet>();

        public mappedState()
        {
        }

        public void put(string variableName, IValueSet valueSet)
        {
            throw new System.NotImplementedException();
        }

        public void put(string variableName)
        {
            //all values
            //min/max hjælpe metoder??
        }

        public IValueSet valuesOf(string variableName) 
        {
            return null;
        }
        
        public bool subStateOf(IState other) 
        {
            if(other.GetType().IsInstanceOfType(typeof(mappedState)))
            {
                var mapped = (mappedState)other;
                foreach (var item in mapped.variables.Keys)
                {
                    var thisVariable = variables[item];
                    if(thisVariable == null) return false;
                    var otherVariable = mapped.variables[item];
                    return thisVariable.subsetOf(otherVariable);
                }
            }
            return false;
        }
    }
}