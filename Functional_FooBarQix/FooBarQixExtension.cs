namespace Functional_FooBarQix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class FooBarQixExtension
    {
        public static string ComputeBelongingToDivisibleRules(
            this int number,
            IDictionary<string, string> rules) =>
                string.Empty.
                    AppendSpecialNumbersBelongingToRule(
                        rules,
                        (s, rule) => s.AppendSpecialStringWhen(
                            () => number % int.Parse(rule.Key) == 0,
                            rule.Value));

        public static string ComputeBelongingToContainsRules(
            this string number,
            IDictionary<string, string> rules) =>
                string.Empty
                    .AppendSpecialNumbersBelongingToRule(
                        rules,
                        (s, rule) => s.AppendSpecialStringWhen(
                            () => number.Contains(rule.Key),
                            rule.Value));

        public static string AppendSpecialNumbersBelongingToRule<T>(
            this string @this,
            IEnumerable<T> rules,
            Func<string, T, string> fn) =>
                rules.Aggregate(@this, fn);

        public static string AppendSpecialStringWhen(
            this string @this,
            Func<bool> predicate,
            string specialOutput) =>
                predicate() ? @this += specialOutput : @this;
    }
}