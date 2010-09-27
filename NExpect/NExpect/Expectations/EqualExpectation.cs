namespace NExpect.Expectations
{
    public class EqualExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public EqualExpectation(TTargetType target)
            : base(target)
        {
        }

        public virtual void To(object @object)
        {
            if (!Target.Equals(@object))
            {
                ThrowExpectationNotMetException("should equal", @object);
            }
        }
    }
}