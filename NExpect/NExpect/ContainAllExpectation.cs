using System.Collections;

namespace NExpect
{
    public class ContainAllExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public ContainAllExpectation(TTargetType target)
            : base(target)
        {
        }

        public virtual void All<TEnumerableType>(TEnumerableType anEnumerable)
            where TEnumerableType : IEnumerable
        {
            foreach (var element in anEnumerable)
            {
                Target.Should().Contain(element);
            }
        }
    }
}