﻿using System.Collections;
using NExpect.Expectations;

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

        public override void Null()
        {
            new NotNullExpectation<TTargetType>(Target).Null();
        }

        public override void Empty()
        {
            new NotEmptyExpectation<TTargetType>(Target).Empty();
        }

        public override void StartWith(IEnumerable enumerable)
        {
            new NotStartWithExpectation<TTargetType>(Target).StartWith(enumerable);
        }

        public override void EndWith(IEnumerable enumerable)
        {
            new NotEndWithExpectation<TTargetType>(Target).EndWith(enumerable);
        }
    }
}