namespace insurance.product.management.domain;

public class CoverageType
{
    private CoverageType()
    {
    }

    public CoverageType(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public CoverageType(string id, string name, string description)
        : this(id, name)
    {
        Description = description;
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
}