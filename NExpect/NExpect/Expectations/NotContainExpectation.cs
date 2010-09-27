using System.Collections;
using System.Linq;

namespace NExpect.Expectations
{
    internal class NotContainExpectation<TTargetType> : ContainExpectation<TTargetType>
    {
        public NotContainExpectation(TTargetType target, object @object)
            : base(target, @object)
        {
        }

        protected override void Perform<TType>(TType @object)
        {
            var collection = CastTargetTo<IEnumerable>();
            if (collection.Cast<object>().Contains(@object))
                ThrowExpectationNotMetException("should not contain", @object);
        }
    }
}