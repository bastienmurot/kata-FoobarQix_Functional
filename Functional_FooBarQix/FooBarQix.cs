namespace Functional_FooBarQix
{
    using System.Collections.Generic;

    public sealed class FooBarQix
    {
        private readonly IDictionary<string, string> _rules;

        public FooBarQix()
        {
            _rules = new Dictionary<string, string> {
                { "3", "Foo" },
                { "5", "Bar" },
                { "7", "Qix" }
            };
        }

        public string Compute(string number)
        {
            string result = int.Parse(number).ComputeBelongingToDivisibleRules(_rules)
                            + number.ComputeBelongingToContainsRules(_rules);

            return string.IsNullOrEmpty(result) ? number : result;
        }
    }
}