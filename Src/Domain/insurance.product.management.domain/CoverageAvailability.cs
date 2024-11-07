namespace insurance.product.management.domain;

public class CoverageAvailability
{
    public CoverageAvailability(string id, string productId, string coverageTypeId, CoverageLevel coverageLevel)
    {
        Id = id;
        ProductId = productId;
        CoverageTypeId = coverageTypeId;
        CoverageLevel = coverageLevel;
    }

    public string Id { get; private set; }
    public string ProductId { get; private set; }
    public string CoverageTypeId { get; private set; }
    public CoverageLevel CoverageLevel { get; private set; }
}