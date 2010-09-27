using System;

namespace NExpect.Expectations
{
    public class NullExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public NullExpectation(TTargetType target) : base(target)
        {
        }

        public virtual void Null()
        {
            if (Target != null)
                ThrowExpectationNotMetException("should be", "null");
        }
    }
}