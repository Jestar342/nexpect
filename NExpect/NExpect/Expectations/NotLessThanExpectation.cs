using System;

namespace NExpect.Expectations
{
    public class NotLessThanExpectation<TTargetType> : LessThanExpectation<TTargetType>
    {
        public NotLessThanExpectation(TTargetType target) : base(target)
        {
        }

        public override void Than<TType>(TType @object)
        {
            var casted = CastTargetTo<IComparable>();
            if (casted.CompareTo(@object) < 0)
                ThrowExpectationNotMetException("should not be less than", @object);
        }
    }
}