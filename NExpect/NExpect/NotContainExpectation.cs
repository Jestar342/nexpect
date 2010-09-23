using System.Collections.Generic;

namespace NExpect
{
    internal class NotContainExpectation<TTargetType> : ContainExpectation<TTargetType>
    {
        public NotContainExpectation(TTargetType target)
            : base(target)
        {
        }

        public override void Contain<TType>(TType @object)
        {
            var collection = CastTargetTo<ICollection<TType>>();
            if (collection.Contains(@object))
                ThrowExpectationNotMetException("should not contain", @object);
        }
    }
}