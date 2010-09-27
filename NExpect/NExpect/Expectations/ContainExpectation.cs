using System.Collections;
using System.Linq;

namespace NExpect.Expectations
{
    public class ContainExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public ContainExpectation(TTargetType target, object @object)
            : base(target)
        {
            Perform(@object);
        }

        protected virtual void Perform<TType>(TType @object)
        {
            var collection = CastTargetTo<IEnumerable>();
            if (!collection.Cast<object>().Contains(@object))
                ThrowExpectationNotMetException("should contain", @object);
        }
    }
}