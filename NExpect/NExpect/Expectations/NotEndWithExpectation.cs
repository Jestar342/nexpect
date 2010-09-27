using System.Collections;

namespace NExpect.Expectations
{
    public class NotEndWithExpectation<TTargetType> : EndWithExpectation<TTargetType>
    {
        public NotEndWithExpectation(TTargetType target) : base(target)
        {
        }

        public override void EndWith(IEnumerable enumerable)
        {
            var enumerator = Reverse(enumerable).GetEnumerator();
            var targetEnumerator = TargetReversed.GetEnumerator();
            while (targetEnumerator.MoveNext() && enumerator.MoveNext())
            {
                if (!targetEnumerator.Current.Equals(enumerator.Current))
                    return;
            }

            if (!enumerator.MoveNext())
                ThrowExpectationNotMetException("should not end with", enumerable);
        }
    }
}