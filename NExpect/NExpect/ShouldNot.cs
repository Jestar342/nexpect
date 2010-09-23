using System;

namespace NExpect
{
    public class ShouldNot<TTargetType> : Should<TTargetType>
    {
        public ShouldNot(TTargetType target)
            : base(target)
        {
        }

        public override EqualExpectation<TTargetType> Equal()
        {
            return new NotEqualExpectation<TTargetType>(Target);
        }

        public override InstanceExpectation<TTargetType> Instance()
        {
            return new NotInstanceExpectation<TTargetType>(Target);
        }

        public override void Contain<TElementType>(TElementType @object)
        {
            new NotContainExpectation<TTargetType>(Target).Contain(@object);
        }

        public override void Throw<TException>()
        {
            new NotThrowExpectation<TTargetType, TException>(Target);
        }

        public override ContainAllExpectation<TTargetType> Contain()
        {
            return new NotContainAllExpectation<TTargetType>(Target);
        }
    }
}