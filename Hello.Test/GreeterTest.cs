using System;
using FluentAssertions;
using Xunit;

namespace Hello.Test
{
    public class GreeterTest
    {
        [Fact]
        public void HelloWord()
        {
            // arrange

            // act
            var actual = Greeter.HelloWorld();

            // assert
            actual.Should().Be("hello world");
        }
    }
}