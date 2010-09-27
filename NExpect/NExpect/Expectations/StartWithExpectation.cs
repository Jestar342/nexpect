using System.Collections;

namespace NExpect.Expectations
{
    public class StartWithExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        protected IEnumerable Collection;
        protected IEnumerator CollectionEnum;
        protected IEnumerator SequenceEnum;

        public StartWithExpectation(TTargetType target) : base(target)
        {
            Collection = CastTargetTo<IEnumerable>();
            CollectionEnum = Collection.GetEnumerator();
        }

        public virtual void With(IEnumerable enumerable)
        {
            SequenceEnum = enumerable.GetEnumerator();
            while (CollectionEnum.MoveNext() && SequenceEnum.MoveNext())
            {
                CollectionEnum.Current.Should().Be.Equal.To(SequenceEnum.Current);
            }

            if (SequenceEnum.MoveNext())
                ThrowExpectationNotMetException("should start with", enumerable);
        }
    }
}