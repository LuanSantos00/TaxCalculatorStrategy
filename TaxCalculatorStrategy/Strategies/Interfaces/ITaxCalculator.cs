namespace TaxCalculatorStrategy.Strategies
{
    public interface ITaxCalculator
    {
        string Type { get; }
        double TaxCalculator(double value);
    }
}
