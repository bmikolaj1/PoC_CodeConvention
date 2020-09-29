using Ardalis.GuardClauses;

namespace CodeAnalyzerExample.Examples
{
    public class GuardExample1
    {
        public decimal CalculatePercentage(decimal value, decimal total)
        {
            Guard.Against.NegativeOrZero(value, nameof(value));

            return value / total;
        }
    }
}
