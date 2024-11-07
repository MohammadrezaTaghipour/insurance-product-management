namespace insurance.product.management.domain;

public class ProductFeature
{
    public ProductFeature(string id, string name, ProductFeatureType type)
    {
        Id = id;
        Name = name;
        Type = type;
    }

    public ProductFeature(string id, string name, ProductFeatureType type, string description)
        : this(id, name, type)
    {
        Description = description;
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ProductFeatureType Type { get; private set; }
}

public enum ProductFeatureType
{
    CoveredLoss = 0,
    CoverageTypePeriod = 1,
    LoanOptions = 2,
    Pricing = 4,
    RenewalPeriod = 8
}