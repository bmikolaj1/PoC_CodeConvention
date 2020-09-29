using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dawn;

namespace CodeAnalyzerExample.Examples
{
    public class GuardExample2
    {
        public decimal CalculatePercentage(decimal value, decimal total)
        {
            Guard.Argument(value, nameof(value)).NotNegative().NotZero();

            return value / total;
        }
    }
}
