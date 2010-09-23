namespace NExpect
{
    public class NotEqualExpectation<TTargetType> : EqualExpectation<TTargetType>
    {
        public NotEqualExpectation(TTargetType target)
            : base(target)
        {
        }

        public override void To(object @object)
        {
            if (Target.Equals(@object))
                ThrowExpectationNotMetException("should not equal", @object);
        }
    }
}