namespace NExpect
{
    public class NotContainAllExpectation<TTargetType> : ContainAllExpectation<TTargetType>
    {
        public NotContainAllExpectation(TTargetType target) : base(target)
        {
        }

        public override void All<TEnumerableType>(TEnumerableType anEnumerable)
        {
            foreach (var element in anEnumerable)
            {
                Target.Should().Not().Contain(element);
            }
        }
    }
}