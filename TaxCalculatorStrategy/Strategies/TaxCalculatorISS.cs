namespace TaxCalculatorStrategy.Strategies
{
    public class TaxCalculatorISS : ITaxCalculator
    {
        public string Type => "iss";

        public double TaxCalculator(double value)
        {
            return value * 0.02;
        }
    }
}
