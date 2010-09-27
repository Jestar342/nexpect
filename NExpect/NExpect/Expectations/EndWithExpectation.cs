using System.Collections;

namespace NExpect.Expectations
{
    public class EndWithExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        protected readonly IEnumerable TargetReversed;

        public EndWithExpectation(TTargetType target)
            : base(target)
        {
            TargetReversed = Reverse(CastTargetTo<IEnumerable>());
        }

        protected static IEnumerable Reverse(IEnumerable enumerable)
        {
            var arrayList = new ArrayList();
            var enumerator = enumerable.GetEnumerator();
            
            while (enumerator.MoveNext())
                arrayList.Add(enumerator.Current);

            arrayList.Reverse();

            return arrayList;
        }

        public virtual void With(IEnumerable enumerable)
        {
            var enumerator = Reverse(enumerable).GetEnumerator();
            var targetEnumerator = TargetReversed.GetEnumerator();
            while(targetEnumerator.MoveNext() && enumerator.MoveNext())
            {
                targetEnumerator.Current.Should().Be.Equal.To(enumerator.Current);
            }

            if (enumerator.MoveNext())
                ThrowExpectationNotMetException("should end with", enumerable);
        }
    }
}