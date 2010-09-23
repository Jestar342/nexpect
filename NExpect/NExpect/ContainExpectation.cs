using System.Collections.Generic;

namespace NExpect
{
    public class ContainExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public ContainExpectation(TTargetType target)
            : base(target)
        {
        }

        public virtual void Contain<TType>(TType @object)
        {
            var collection = CastTargetTo<ICollection<TType>>();
            if (!collection.Contains(@object))
                ThrowExpectationNotMetException("does not contain", @object);
        }
    }
}