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
        var product = new InsuranceProduct("1", "Premium Auto Coverage");

        //Act
        var sut = new ProductRule("1", product.Id, name);

        //Assert
        sut.Id.Should().Be("1");
        sut.ProductId.Should().Be(product.Id);
        sut.Name.Should().Be(name);
    }

    [Fact]
    public void productRule_for_coverageType_gets_created_successfully()
    {
        //Arrange

        //Act
        var sut = new ProductRule("1", "product.Id", "name","value", "coverageTypeId");


        //Assert
    }
}