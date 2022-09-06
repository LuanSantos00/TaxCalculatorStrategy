namespace TaxCalculatorStrategy.Strategies
{
    public class TaxCalculatorIOF : ITaxCalculator
    {
        public string Type => "iof";

        public double TaxCalculator(double value)
        {
            return value * 0.0038;
        }
    }
}
