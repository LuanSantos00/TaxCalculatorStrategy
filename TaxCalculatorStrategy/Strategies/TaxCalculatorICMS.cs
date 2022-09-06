namespace TaxCalculatorStrategy.Strategies
{
    public class TaxCalculatorICMS : ITaxCalculator
    {
        public string Type => "icms";

        public double TaxCalculator(double value)
        {
            return value * 0.80;
        }
    }
}
