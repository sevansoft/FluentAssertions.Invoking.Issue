using FluentAssertions;
using Xunit;

namespace FluentAssertion.Issue._6._0._0
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

            //EnumHelper
            //    .GetEnum()
            //    .Should()
            //    .Be(TestEnum.FirstValue);
        }
    }
}
