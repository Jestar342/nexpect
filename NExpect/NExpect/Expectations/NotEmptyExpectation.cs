using System.Collections;

namespace NExpect.Expectations
{
    public class NotEmptyExpectation<TTargetType> : EmptyExpectation<TTargetType>
    {
        public NotEmptyExpectation(TTargetType target) : base(target)
        {
        }

        public override void Empty()
        {
            var collection = CastTargetTo<ICollection>();
            if (collection.Count == 0)
                ThrowExpectationNotMetException("should not be", "empty");
        }
    }
}