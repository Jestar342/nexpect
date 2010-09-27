namespace NExpect.Expectations
{
    public class NotNullExpectation<TTargetType> : NullExpectation<TTargetType>
    {
        public NotNullExpectation(TTargetType target) : base(target)
        {
        }

        public override void Null()
        {
            if (Target == null)
                ThrowExpectationNotMetException("should not be", "null");
        }
    }
}