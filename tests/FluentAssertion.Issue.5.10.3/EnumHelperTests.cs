using FluentAssertions;
using Xunit;

namespace FluentAssertion.Issue._5._10._3
{
    public class EnumHelperTests
    {
        [Fact]
        public void EnumValue_Should_Be_FirstValue()
        {
            // arrange
            // act
            // assert
            EnumHelper
                .GetEnum()
                .Should()
                .BeEquivalentTo(TestEnum.FirstValue);
        }
    }
}
