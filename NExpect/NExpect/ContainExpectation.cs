using System.Collections;
using System.Linq;

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
            var collection = CastTargetTo<IEnumerable>();
            if (!collection.Cast<object>().Contains(@object))
                ThrowExpectationNotMetException("should contain", @object);
        }
    }
}