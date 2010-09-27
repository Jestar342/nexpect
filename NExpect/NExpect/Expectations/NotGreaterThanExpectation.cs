namespace NExpect.Expectations
{
    public class NotGreaterThanExpectation<TTargetType> : GreaterThanExpectation<TTargetType>
    {
        public NotGreaterThanExpectation(TTargetType target) : base(target)
        {
        }

        public override void Than<TType>(TType @object)
        {
            var casted = CastTargetTo<TType>();
            if (casted.CompareTo(@object) >= 0)
                ThrowExpectationNotMetException("should not be greater than", @object);
        }
    }
}