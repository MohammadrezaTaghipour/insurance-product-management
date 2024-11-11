namespace insurance.product.management.domain;

public class Product
{
    private Product()
    {
    }

    public Product(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public Product(string id, string name, string productCategoryId)
        : this(id, name)
    {
        Id = id;
        Name = name;
        ProductCategoryId = productCategoryId;
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string ProductCategoryId { get; private set; }
    private readonly List<CoverageAvailability> _coverageAvailabilities = new();
    public IReadOnlyList<CoverageAvailability> CoverageAvailabilities => _coverageAvailabilities.AsReadOnly();

    public void AddCoverageAvailability(IEnumerable<CoverageAvailability> coverageAvailabilities)
    {
        foreach (var availability in coverageAvailabilities)
        {
            AddCoverageAvailability(availability);
        }
    }

    public void AddCoverageAvailability(CoverageAvailability coverageAvailability)
    {
        _coverageAvailabilities.Add(coverageAvailability);
    }
}