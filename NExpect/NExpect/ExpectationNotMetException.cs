using System;

namespace NExpect
{
    public class ExpectationNotMetException : Exception
    {
        public ExpectationNotMetException(string message)
            : base(message)
        {
        }

        public ExpectationNotMetException(string message, object target, object @object)
            : base(string.Format("{0} {1} {2}", target, message, @object))
        {
        }
    }
}