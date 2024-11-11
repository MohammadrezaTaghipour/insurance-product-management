using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class ProductRuleTests
{
    [Theory]
    [InlineData("Renews Annually")]
    [InlineData("Policy will not extend automatically")]
    [InlineData("Incidents must be managed and approved by case management")]
    public void productRule_with_required_fields_gets_created_successfully(string name)
    {
        //Arrange
        var product = new Product("1", "Premium Auto Coverage");

        //Act
        var sut = new ProductRule("1", product.Id, name);

        //Assert
        sut.Id.Should().Be("1");
        sut.ProductId.Should().Be(product.Id);
        sut.Name.Should().Be(name);
        sut.Value.Should().BeNullOrEmpty();
        sut.CoverageTypeId.Should().BeNullOrEmpty();
        sut.ProductFeatureId.Should().BeNullOrEmpty();
    }

    [Fact]
    public void productRule_with_optional_fields_gets_created_successfully()
    {
        //Arrange
        var product = new Product("1", "Premium Auto Coverage");
        var coverageType = new CoverageType("1", "Bodily injury");
        var productFeature = new ProductFeature("1", "Exclude Extra Accessories Damage",
            ProductFeatureType.CoveredLoss);

        //Act
        var sut = new ProductRule("1", product.Id, "Incidents must be managed and approved by case management",
            string.Empty, coverageType.Id, productFeature.Id);

        //Assert
        sut.Id.Should().Be("1");
        sut.ProductId.Should().Be(product.Id);
        sut.Name.Should().Be("Incidents must be managed and approved by case management");
        sut.Value.Should().BeNullOrEmpty();
        sut.CoverageTypeId.Should().Be(coverageType.Id);
        sut.ProductFeatureId.Should().Be(productFeature.Id);
    }
}