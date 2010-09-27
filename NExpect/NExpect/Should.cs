using System;
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

        public ShouldNot<TTargetType> Not
        {
            get { return new ShouldNot<TTargetType>(Target); }
        }

        public Should<TTargetType> Be
        {
            get { return this; }
        }

        public virtual void Contain<TType>(TType @object)
        {
            new ContainExpectation<TTargetType>(Target, @object);
        }

        public virtual ContainAllExpectation<TTargetType> Contain()
        {
            return new ContainAllExpectation<TTargetType>(Target);
        }

        public virtual void Empty()
        {
            new EmptyExpectation<TTargetType>(Target).Empty();
        }

        public virtual EndWithExpectation<TTargetType> End
        {
            get { return new EndWithExpectation<TTargetType>(Target); }
        }

        public virtual EqualExpectation<TTargetType> Equal
        {
            get { return new EqualExpectation<TTargetType>(Target); }
        }

        public virtual GreaterThanExpectation<TTargetType> Greater
        {
            get { return new GreaterThanExpectation<TTargetType>(Target); }
        }

        public virtual InstanceExpectation<TTargetType> Instance
        {
            get { return new InstanceExpectation<TTargetType>(Target); }
        }

        public virtual LessThanExpectation<TTargetType> Less
        {
            get { return new LessThanExpectation<TTargetType>(Target); }
        }

        public virtual void Null()
        {
            new NullExpectation<TTargetType>(Target).Null();
        }

        public virtual StartWithExpectation<TTargetType> Start
        {
            get { return new StartWithExpectation<TTargetType>(Target); }
        }

        public virtual void Throw<TException>() where TException : Exception
        {
            new ThrowExpectation<TTargetType, TException>(Target);
        }
    }
}