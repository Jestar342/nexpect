namespace NExpect
{
    public class NotInstanceExpectation<TTargetType> : InstanceExpectation<TTargetType>
    {
        public NotInstanceExpectation(TTargetType target)
            : base(target)
        {
        }

        public override void Of<TType>()
        {
            if (Target.GetType() == typeof(TType))
                ThrowExpectationNotMetException("should not be instance of", typeof (TType));
        }
    }
}