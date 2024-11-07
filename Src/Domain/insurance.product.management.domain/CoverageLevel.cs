namespace insurance.product.management.domain;

public class CoverageLevel
{
    private CoverageLevel()
    {
    }

    public CoverageLevel(string id, CoverageLevelType type,
        decimal? coverageAmount, decimal? coverageLimitFrom, decimal? coverageLimitThorough,
        decimal? coPayAmount, double? coInsurancePercentage)
    {
        Id = id;
        Type = type;
        CoverageAmount = coverageAmount;
        CoverageLimitFrom = coverageLimitFrom;
        CoverageLimitThorough = coverageLimitThorough;
        CoPayAmount = coPayAmount;
        CoInsurancePercentage = coInsurancePercentage;
    }

    public string Id { get; private set; }
    public CoverageLevelType Type { get; private set; }
    public decimal? CoverageAmount { get; private set; }
    public decimal? CoverageLimitFrom { get; private set; }
    public decimal? CoverageLimitThorough { get; private set; }
    public decimal? CoPayAmount { get; private set; }
    public double? CoInsurancePercentage { get; private set; }
}

public enum CoverageLevelType
{
    CoverageAmount = 0,
    CoverageRange = 1,
    CoPay = 2,
    CoInsurance = 4,
    Deductibility = 8
}