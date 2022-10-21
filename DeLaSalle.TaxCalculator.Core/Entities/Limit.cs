namespace DeLaSalle.TaxCalculator.Core.Entities;

public class Limit
{
    public double LowerLimit { get; set; }
    public double UpperLimit { get; set; }
    public double FixedFee { get; set; }
    public double SurplusPercentage { get; set; }
}