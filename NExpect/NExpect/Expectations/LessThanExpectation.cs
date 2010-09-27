using System;

namespace NExpect.Expectations
{
    public class LessThanExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public LessThanExpectation(TTargetType target) : base(target)
        {
        }

        public virtual void Than<TType>(TType @object)
            where TType : IComparable
        {
            var casted = CastTargetTo<TType>();
            if (casted.CompareTo(@object) >= 0)
                ThrowExpectationNotMetException("should be less than", @object);
        }
    }
}