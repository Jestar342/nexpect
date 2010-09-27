using System.Collections;

namespace NExpect.Expectations
{
    public class NotStartWithExpectation<TTargetType> : StartWithExpectation<TTargetType>
    {
        public NotStartWithExpectation(TTargetType target) : base(target)
        {
        }

        public override void StartWith(IEnumerable enumerable)
        {
            SequenceEnum = enumerable.GetEnumerator();

            while (SequenceEnum.MoveNext() && CollectionEnum.MoveNext())
            {
                if (SequenceEnum.Current != null)
                    if (!SequenceEnum.Current.Equals(CollectionEnum.Current))
                        return;
            }

            ThrowExpectationNotMetException("should not start with", enumerable);
        }
    }
}