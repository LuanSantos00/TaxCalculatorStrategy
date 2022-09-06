using TaxCalculatorStrategy.Strategies;

namespace TaxCalculatorStrategy
{
    public class Context
    {
        private readonly IEnumerable<ITaxCalculator> _taxCalculator;
        public Context(IEnumerable<ITaxCalculator> taxCalculators)
            => _taxCalculator = taxCalculators;
           
        public void Execute(string type, double value)
        {
           
            var result = _taxCalculator.FirstOrDefault(c => c.Type == type)
                .TaxCalculator(value);

            Console.WriteLine(result);
        }
    }
}
