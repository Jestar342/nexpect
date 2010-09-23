namespace NExpect
{
    public static class ShouldHelper
    {
        public static Should<TTargetType> Should<TTargetType>(this TTargetType target)
        {
            return new Should<TTargetType>(target);
        }
    }
}