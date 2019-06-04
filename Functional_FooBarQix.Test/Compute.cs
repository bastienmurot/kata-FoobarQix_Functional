namespace Functional_FooBarQix.Test
{
    using Xunit;

    public sealed class Compute
    {
        private readonly FooBarQix _fooBarQix;

        public Compute()
        {
            _fooBarQix = new FooBarQix();
        }

        [Fact(Skip = "Used to initiate TDD")]
        public void ItExists()
        {
            // Arrange
            var fooBarQix = new FooBarQix();

            // Act & Assert
            string result = fooBarQix.Compute("1");
        }

        [Fact]
        public void GivenANumberDivisibleByThreeShouldReturnFoo()
        {
            // Act
            string result = _fooBarQix.Compute("9");

            // Assert
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void GivenANumberDivisibleByFiveShouldReturnBar()
        {

            // Act
            string result = _fooBarQix.Compute("20");

            // Assert
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void GivenANumberDivisibleBySevenShouldReturnQix()
        {
            // Act
            string result = _fooBarQix.Compute("14");

            // Assert
            Assert.Equal("Qix", result);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("8")]
        public void GivenANonDivisibleNumberShouldReturnNumber(string number)
        {
            // Act
            string result = _fooBarQix.Compute(number);

            // Assert
            Assert.Equal(number, result);
        }

        [Fact(Skip = "No more true with contains")]
        public void GivenANumberDivisibleByThreeAndFiveShouldReturnFooBar()
        {
            // Act
            string result = _fooBarQix.Compute("15");

            // Assert
            Assert.Equal("FooBar", result);
        }

        [Fact(Skip = "No more true with contains")]
        public void GivenANumberDivisibleByFiveAndSevenShouldReturnFooBar()
        {
            // Act
            string result = _fooBarQix.Compute("35");

            // Assert
            Assert.Equal("BarQix", result);
        }

        [Fact]
        public void GivenANumberDivisibleByThreeAndSevenShouldReturnFooQix()
        {
            // Act
            string result = _fooBarQix.Compute("21");

            // Assert
            Assert.Equal("FooQix", result);
        }

        [Fact]
        public void GivenANumberThatContainsNumberThreeShouldReturnFoo()
        {
            // Act
            string result = _fooBarQix.Compute("13");

            // Assert
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void GivenANumberThatContainsNumberFiveShouldReturnBarBar()
        {
            // Act
            string result = _fooBarQix.Compute("5");

            // Assert
            Assert.Equal("BarBar", result);
        }

        [Fact]
        public void GivenANumberThatContainsNumberSevenShouldReturnQix()
        {
            // Act
            string result = _fooBarQix.Compute("17");

            // Assert
            Assert.Equal("Qix", result);
        }

        [Fact]
        public void GivenANumberThatContainsAndDivisibleByNumberThreeShouldReturnFooFoo()
        {
            // Act
            string result = _fooBarQix.Compute("3");

            // Assert
            Assert.Equal("FooFoo", result);
        }

        [Fact]
        public void GivenANumberThatContainsAndDivisibleByNumberFiveShouldReturnBarBar()
        {
            // Act
            string result = _fooBarQix.Compute("5");

            // Assert
            Assert.Equal("BarBar", result);
        }

        [Fact]
        public void GivenANumberThatContainsAndDivisibleByNumberSevenShouldReturnQixQix()
        {
            // Act
            string result = _fooBarQix.Compute("7");

            // Assert
            Assert.Equal("QixQix", result);
        }

        [Theory]
        [InlineData("15", "FooBarBar")]
        public void GivenANumberDivisibleAndContainsSpecialNumberShouldReturnSpecialOutput(string number, string expected)
        {
            // Act
            string result = _fooBarQix.Compute(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}