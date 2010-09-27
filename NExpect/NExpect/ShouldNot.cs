using NExpect.Expectations;

namespace NExpect
{
    public class ShouldNot<TTargetType> : Should<TTargetType>
    {
        public ShouldNot(TTargetType target)
            : base(target)
        {
        }

        public override EqualExpectation<TTargetType> Equal
        {
            get { return new NotEqualExpectation<TTargetType>(Target); }
        }

        public override InstanceExpectation<TTargetType> Instance
        {
            get { return new NotInstanceExpectation<TTargetType>(Target); }
        }

        public override void Contain<TElementType>(TElementType @object)
        {
            new NotContainExpectation<TTargetType>(Target, @object);
        }

        public override void Throw<TException>()
        {
            new NotThrowExpectation<TTargetType, TException>(Target);
        }

        public override ContainAllExpectation<TTargetType> Contain()
        {
            return new NotContainAllExpectation<TTargetType>(Target);
        }

        public override void Null()
        {
            new NotNullExpectation<TTargetType>(Target).Null();
        }

        public override void Empty()
        {
            new NotEmptyExpectation<TTargetType>(Target).Empty();
        }

        public override StartWithExpectation<TTargetType> Start
        {
            get { return new NotStartWithExpectation<TTargetType>(Target); }
        }

        public override EndWithExpectation<TTargetType> End
        {
            get { return new NotEndWithExpectation<TTargetType>(Target); }
        }

        public override LessThanExpectation<TTargetType> Less
        {
            get { return new NotLessThanExpectation<TTargetType>(Target); }
        }

        public override GreaterThanExpectation<TTargetType> Greater
        {
            get { return new NotGreaterThanExpectation<TTargetType>(Target); }
        }
    }
}