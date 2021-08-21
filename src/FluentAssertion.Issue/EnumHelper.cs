namespace FluentAssertion.Issue
{
    public static class EnumHelper
    {
        public static TestEnum GetEnum()
        {
            return TestEnum.FirstValue;
        }
    }

    public enum TestEnum
    {
        FirstValue,
        SecondValue
    }
}
