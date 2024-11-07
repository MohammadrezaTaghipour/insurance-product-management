using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class ProductFeatureTests
{
    [Theory]
    [InlineData("Exclude Flood Damage", ProductFeatureType.CoveredLoss)]
    [InlineData("Exclude Extra Accessories Damage", ProductFeatureType.CoveredLoss)]
    [InlineData("Insurance begins after 30 days after first day of incident", ProductFeatureType.CoverageTypePeriod)]
    [InlineData("8 percents loan", ProductFeatureType.LoanOptions)]
    [InlineData("10 percents loan", ProductFeatureType.LoanOptions)]
    public void productFeature_with_required_fields_gets_created_successfully(string name, ProductFeatureType type)
    {
        //Arrange

        //Act
        var sut = new ProductFeature("1", name, type);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be(name);
        sut.Type.Should().Be(type);
        sut.Description.Should().BeNullOrEmpty();
    }

    [Fact]
    public void productFeature_with_optional_fields_gets_created_successfully()
    {
        //Arrange

        //Act
        var sut = new ProductFeature("1", "Multi-device discount when more than two mobiles",
            ProductFeatureType.Pricing, "Description");

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be("Multi-device discount when more than two mobiles");
        sut.Type.Should().Be(ProductFeatureType.Pricing);
        sut.Description.Should().Be("Description");
    }
}