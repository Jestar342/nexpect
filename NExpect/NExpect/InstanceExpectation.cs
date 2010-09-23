namespace NExpect
{
    public class InstanceExpectation<TTargetType> : ExpectationBase<TTargetType>
    {
        public InstanceExpectation(TTargetType target)
            : base(target)
        {
        }

        public virtual void Of<TType>()
        {
            if (Target.GetType() != typeof(TType))
                ThrowExpectationNotMetException("should be instance of", typeof(TType));
        }
    }
}