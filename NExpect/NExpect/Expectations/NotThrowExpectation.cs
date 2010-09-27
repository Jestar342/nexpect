using System;

namespace NExpect.Expectations
{
    public class NotThrowExpectation<TTargetType, TException> : ThrowExpectation<TTargetType, TException>
        where TException : Exception
    {
        public NotThrowExpectation(TTargetType target)
            : base(target)
        {
        }

        protected override void Perform()
        {
            var action = CastTargetTo<Action>();
            try
            {
                action.Invoke();
            }
            catch (TException)
            {
                ThrowExpectationNotMetException("should not have thrown", typeof (TException));
            }
            catch (Exception e)
            {
                ThrowExpectationNotMetException("threw unexpected exception", e);
            }
        }
    }
}