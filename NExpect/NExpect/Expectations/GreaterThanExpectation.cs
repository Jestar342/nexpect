using System;

namespace NExpect.Expectations
{
    public class GreaterThanExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public GreaterThanExpectation(TTargetType target) : base(target)
        {
        }

        public virtual void Than<TType>(TType @object)
            where TType : IComparable
        {
            var casted = CastTargetTo<TType>();
            if (casted.CompareTo(@object) <= 0)
                ThrowExpectationNotMetException("should be greater than", @object);
        }
    }
}