using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class ProductFeatureCoverageTests
{
    [Fact]
    public void productFeatureCoverage_with_required_fields_gets_created_successfully()
    {
        //Arrange
        var product = new InsuranceProduct("1", "Premium Auto Coverage");
        var productFeatureCoverageItems = new List<ProductFeatureCoverageItem>
        {
            new(product.Id)
        };

        //Act
        var sut = new ProductFeatureCoverage("1", "Vehicle Product Feature", productFeatureCoverageItems);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be("Vehicle Product Feature");
        sut.ProductFeatureCoverageItems.Should().Contain(productFeatureCoverageItems);
    }

    [Fact]
    public void productFeatureCoverage_with_optional_fields_gets_created_successfully()
    {
        //Arrange
        var product = new InsuranceProduct("1", "Premium Auto Coverage");
        var coverageType = new CoverageType("1", "Bodily injury");
        var productFeatureCoverageItems = new List<ProductFeatureCoverageItem>
        {
            new(product.Id, coverageType.Id)
        };

        //Act
        var sut = new ProductFeatureCoverage("1", "Digital Equipment Product Feature", productFeatureCoverageItems);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be("Digital Equipment Product Feature");
        sut.ProductFeatureCoverageItems.Should().Contain(productFeatureCoverageItems);
    }
}