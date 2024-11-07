namespace insurance.product.management.domain;

public class ProductFeatureCoverage
{
    private ProductFeatureCoverage()
    {
    }

    public ProductFeatureCoverage(string id, string name, List<ProductFeatureCoverageItem> productFeatureCoverageItems)
    {
        Id = id;
        Name = name;
        _productFeatureCoverageItems = productFeatureCoverageItems;
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    private readonly List<ProductFeatureCoverageItem> _productFeatureCoverageItems = new();

    public IReadOnlyList<ProductFeatureCoverageItem> ProductFeatureCoverageItems =>
        _productFeatureCoverageItems.AsReadOnly();
}

public class ProductFeatureCoverageItem
{
    private ProductFeatureCoverageItem()
    {
    }

    public ProductFeatureCoverageItem(string productId)
    {
        ProductId = productId;
    }

    public ProductFeatureCoverageItem(string productId, string productTypeId)
        : this(productId)
    {
        ProductTypeId = productTypeId;
    }

    public string ProductId { get; private set; }
    public string? ProductTypeId { get; private set; }
}