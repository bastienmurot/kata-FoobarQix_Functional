namespace Functional_FooBarQix.Test
{
    using Xunit;

    public sealed class AppendSpecialStringWhen
    {
        [Fact]
        public void GivenANumberContainingThreeReturnFoo()
        {
            // Arrange
            string number = "13";

            // Act
            string result = string.Empty
                .AppendSpecialStringWhen(() => number.Contains("3"), "Foo");

            // Assert
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void GivenANumberContainingFiveReturnBar()
        {
            // Arrange
            string number = "15";

            // Act
            string result = string.Empty.AppendSpecialStringWhen(() => number.Contains("5"), "Bar");

            // Assert
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void GivenANumberContainingSevenReturnQix()
        {
            // Arrange
            string number = "17";

            // Act
            string result = string.Empty.AppendSpecialStringWhen(() => number.Contains("7"), "Qix");

            // Assert
            Assert.Equal("Qix", result);
        }

        [Fact]
        public void GivenANumberContainingThreeAndFiveReturnFooBar()
        {
            string number = "53";

            // Act
            string result = string.Empty
                .AppendSpecialStringWhen(() => number.Contains("3"), "Foo")
                .AppendSpecialStringWhen(() => number.Contains("5"), "Bar");

            // Assert
            Assert.Equal("FooBar", result);
        }

        [Fact]
        public void GivenANumberNotContainingSpecialNumbersReturnNumber()
        {
            string number = "17";

            // Act
            string result = string.Empty
                .AppendSpecialStringWhen(() => number.Contains("3"), "Foo")
                .AppendSpecialStringWhen(() => number.Contains("5"), "Bar");

            // Assert
            Assert.Equal(string.Empty, result);
        }
    }
}