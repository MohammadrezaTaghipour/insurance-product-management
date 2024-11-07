using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class ProductCategoryTests
{
    private ProductCategory _sut;

    [Theory]
    [InlineData("Property insurance")]
    [InlineData("Casualty insurance")]
    [InlineData("Life insurance")]
    [InlineData("Health insurance")]
    public void product_category_with_required_fields_gets_created_successfully(string name)
    {
        //Arrange

        //Act
        _sut = new ProductCategory("1", name);

        //Assert
        _sut.Id.Should().Be("1");
        _sut.Name.Should().Be(name);
        _sut.ParentId.Should().BeNullOrEmpty();
    }

    [Theory]
    [InlineData("Health insurance", "Individual insurance")]
    [InlineData("Health insurance", "Organization insurance")]
    public void hierarchical_product_category_gets_created_successfully(string parentName, string childName)
    {
        //Arrange
        product_category_with_required_fields_gets_created_successfully(parentName);

        //Act
        var childSut = new ProductCategory("2", childName, _sut.Id);

        //Assert
        childSut.Id.Should().Be("2");
        childSut.Name.Should().Be(childName);
        childSut.ParentId.Should().Be(_sut.Id);
    }
}