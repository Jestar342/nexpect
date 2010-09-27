using System;
using System.Collections;
using NExpect.Expectations;

namespace NExpect
{
    public class Should<TTargetType>
    {
        protected readonly TTargetType Target;

        public Should(TTargetType target)
        {
            Target = target;
        }

        public ShouldNot<TTargetType> Not()
        {
            return new ShouldNot<TTargetType>(Target);
        }

        public Should<TTargetType> Be()
        {
            return this;
        }

        public virtual EqualExpectation<TTargetType> Equal()
        {
            return new EqualExpectation<TTargetType>(Target);
        }

        public virtual InstanceExpectation<TTargetType> Instance()
        {
            return new InstanceExpectation<TTargetType>(Target);
        }

        public virtual void Contain<TType>(TType @object)
        {
            new ContainExpectation<TTargetType>(Target).Contain(@object);
        }

        public virtual void Throw<TException>()
            where TException : Exception
        {
            new ThrowExpectation<TTargetType, TException>(Target);
        }

        public virtual ContainAllExpectation<TTargetType> Contain()
        {
            return new ContainAllExpectation<TTargetType>(Target);
        }

        public virtual void Null()
        {
            new NullExpectation<TTargetType>(Target).Null();
        }

        public virtual void Empty()
        {
            new EmptyExpectation<TTargetType>(Target).Empty();
        }

        public virtual void StartWith(IEnumerable enumerable)
        {
            new StartWithExpectation<TTargetType>(Target).StartWith(enumerable);
        }

        public virtual void EndWith(IEnumerable enumerable)
        {
            new EndWithExpectation<TTargetType>(Target).EndWith(enumerable);
        }
    }
}