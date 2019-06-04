namespace Functional_FooBarQix.Test
{
    using System.Collections.Generic;

    using Xunit;

    public sealed class AppendSpecialNumbersBelongingToRules
    {
        private readonly IDictionary<string, string> _rules;

        public AppendSpecialNumbersBelongingToRules()
        {
            _rules = new Dictionary<string, string> {
                { "3", "Foo" },
                { "5", "Bar" },
                { "7", "Qix" } };
        }

        [Fact(Skip = "Used to initiate TDD")]
        public void ItExists()
        {
            // Arrange
            string number = "12";
            IDictionary<string, string> rules = new Dictionary<string, string> { { "3", "Foo" }, { "5", "Bar" } };

            // Act && Assert
            string result = string.Empty
                .AppendSpecialNumbersBelongingToRule(
                    rules,
                    (s, rule) => s.AppendSpecialStringWhen(
                        () => number.Contains(rule.Key),
                        rule.Value));
        }

        [Fact]
        public void GivenRuleForFooShouldReturnFoo()
        {
            // Arrange
            string number = "13";

            // Act
            string result = string.Empty
                .AppendSpecialNumbersBelongingToRule(
                    _rules,
                    (s, rule) => s.AppendSpecialStringWhen(
                        () => number.Contains(rule.Key),
                        rule.Value));

            // Assert
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void GivenRuleForBarShouldReturnBar()
        {
            // Arrange
            string number = "15";

            // Act
            string result = string.Empty
                .AppendSpecialNumbersBelongingToRule(
                    _rules,
                    (s, rule) => s.AppendSpecialStringWhen(
                        () => number.Contains(rule.Key),
                        rule.Value));

            // Assert
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void GivenRuleForQixShouldReturnQix()
        {
            // Arrange
            string number = "17";

            // Act
            string result = string.Empty
                .AppendSpecialNumbersBelongingToRule(
                    _rules,
                    (s, rule) => s.AppendSpecialStringWhen(
                        () => number.Contains(rule.Key),
                        rule.Value));

            // Assert
            Assert.Equal("Qix", result);
        }
    }
}