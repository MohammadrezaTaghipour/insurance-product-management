namespace insurance.product.management.domain;

public class ProductCategory
{
    private ProductCategory()
    {
    }

    public ProductCategory(string id, string name)
    {
        Id = id;
        Name = name;
    }

    public ProductCategory(string id, string name, string? parentId)
        : this(id, name)
    {
        ParentId = parentId;
    }

    public string Id { get; private set; }
    public string Name { get; private set; }
    public string? ParentId { get; private set; }
}