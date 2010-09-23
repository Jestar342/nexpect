using System;

namespace NExpect
{
    public class ThrowExpectation<TTargetType, TException> : ExpectationBase<TTargetType> where TException : Exception
    {
        public ThrowExpectation(TTargetType target)
            : base(target)
        {
            Perform();
        }

        protected virtual void Perform()
        {
            var action = CastTargetTo<Action>();
            try
            {
                action.Invoke();
            }
            catch (TException)
            {
                return;
            }
            catch (Exception e)
            {
                throw new ExpectationNotMetException(string.Format("{0} should have thrown {1} but threw {2} instead",
                                                                   Target, typeof (TException), e));
            }

            ThrowExpectationNotMetException("should have thrown", typeof (TException));
        }
    }
}