using TaxCalculatorStrategy;
using TaxCalculatorStrategy.Strategies;

var context = new Context(new List<ITaxCalculator>() { new TaxCalculatorIOF(), new TaxCalculatorICMS(), new TaxCalculatorISS() });

context.Execute("iof", 10);

