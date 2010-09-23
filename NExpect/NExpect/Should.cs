using System;

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

        public ContainAllExpectation<TTargetType> Contain()
        {
            return new ContainAllExpectation<TTargetType>(Target);
        }
    }
}