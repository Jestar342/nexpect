using System;

namespace NExpect
{
    public class ExpectationBase<TTargetType>
    {
        protected TTargetType Target;

        public ExpectationBase(TTargetType target)
        {
            Target = target;
        }

        protected void ThrowExpectationNotMetException(string message, object @object)
        {
            throw new ExpectationNotMetException(message, Target, @object);
        }

        protected TType CastTargetTo<TType>()
            where TType : class
        {
            object tempObject = Target;
            var casted = default(TType);
            try
            {
                casted = (TType)tempObject;
            }
            catch (InvalidCastException)
            {
                ThrowExpectationNotMetException("cannot be cast to", typeof(TType));
            }
            return casted;
        }
    }
}