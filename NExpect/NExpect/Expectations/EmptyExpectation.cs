using System.Collections;

namespace NExpect.Expectations
{
    public class EmptyExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public EmptyExpectation(TTargetType target) : base(target)
        {
        }

        public virtual void Empty()
        {
            var collection = CastTargetTo<ICollection>();
            if (collection.Count != 0)
                ThrowExpectationNotMetException("should be", "empty");
        }
    }
}