using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class CoverageAvailabilityTests
{
    [Fact]
    public void coverageAvailability_with_required_fields_gets_created_successfully()
    {
        //Arrange
        var insuranceProduct = new InsuranceProduct("1", "Premium Auto Coverage");
        var coverageType = new CoverageType("1", "Bodily injury");
        var coverageLevel = new CoverageLevel("1", CoverageLevelType.CoInsurance, null, 100000, 300000, null, null);

        //Act
        var sut = new CoverageAvailability("1", insuranceProduct.Id, coverageType.Id, coverageLevel);

        //Assert
        sut.Id.Should().Be("1");
        sut.ProductId.Should().Be(insuranceProduct.Id);
        sut.CoverageTypeId.Should().Be(coverageType.Id);
        sut.CoverageLevel.Should().BeEquivalentTo(coverageLevel);
    }
}