
using DeLaSalle.TaxCalculator.App.Taxes;
using DeLaSalle.TaxCalculator.Core.Entities;
using static System.Double;

Console.WriteLine("Please type your salary: ");
#pragma warning disable CA1806
TryParse(Console.ReadLine(), out var amount);
#pragma warning restore CA1806

var salary = new Salary{ Amount = amount};
var isrCalculatorService = new IsrCalculatorService();
var isr = isrCalculatorService.GetIsr(salary);

Console.WriteLine($" ISR : {isr} ");