using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace FluentAssertion.Issue._6._0._0
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact(Skip = "Test fails on <6.0.0")]
        public void ExtensionMethod_Should_Throw_ArgumentNullException_When_ServiceCollection_Is_Null_Previous()
        {
            // arrange
            IServiceCollection serviceCollection = null;

            // act
            // assert
            // ReSharper disable once ExpressionIsAlwaysNull
            serviceCollection.Invoking(sut => sut.Register())
                .Should()
                .Throw<ArgumentNullException>()
                .WithMessage("Value cannot be null. (Parameter 'subject')"); //wrong parameter, relates to sut being null
        }

        [Fact]
        public void ExtensionMethod_Should_Throw_ArgumentNullException_When_ServiceCollection_Is_Null_Now()
        {
            // arrange
            IServiceCollection serviceCollection = null;

            // act
            // ReSharper disable once ExpressionIsAlwaysNull
            Action method = () => serviceCollection.Register();

            // assert
            method
                .Should()
                .Throw<ArgumentNullException>()
                .WithMessage("Value cannot be null. (Parameter 'serviceCollection')");
        }
    }
}
