using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace FluentAssertion.Issue._6._0._0
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void ExtensionMethod_Should_Throw_ArgumentNullException_When_ServiceCollection_Is_Null()
        {
            // arrange
            IServiceCollection serviceCollection = null;

            // act
            // assert
            // ReSharper disable once ExpressionIsAlwaysNull
            serviceCollection.Invoking(sut => sut.Register())
                .Should()
                .Throw<ArgumentNullException>()
                .WithMessage("Value cannot be null. (Parameter 'serviceCollection')");
        }
        
        [Fact]
        public void ExtensionMethod_Should_Throw_ArgumentNullException_When_ServiceCollection_Is_Null_V2()
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
