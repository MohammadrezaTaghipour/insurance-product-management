namespace insurance.product.management.domain;

public class ProductRule
{
    private ProductRule()
    {
    }

    public ProductRule(string id, string productId, string name)
    {
        Id = id;
        ProductId = productId;
        Name = name;
    }

    public ProductRule(string id, string productId, string name, string value)
        : this(id, productId, name)
    {
        Value = value;
    }

    public ProductRule(string id, string productId, string name, string value, string coverageTypeId)
        : this(id, productId, name, value)
    {
        CoverageTypeId = coverageTypeId;
    }

    public ProductRule(string id, string productId, string name, string value, string coverageTypeId,
        string productFeatureId)
        : this(id, productId, name, value, coverageTypeId)
    {
        ProductFeatureId = productFeatureId;
    }

    public string Id { get; private set; }
    public string ProductId { get; private set; }
    public string Name { get; private set; }
    public string? Value { get; private set; }
    public string? CoverageTypeId { get; private set; }
    public string? ProductFeatureId { get; private set; }
}