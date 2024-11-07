using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class CoverageTypeTests
{
    [Theory]
    [InlineData("Bodily injury")]
    [InlineData("Comprehensive")]
    [InlineData("Collision")]
    public void coverage_type_with_required_fields_gets_created_successfully(string name)
    {
        //Arrange

        //Act
        var sut = new CoverageType("1", name, "description");

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be(name);
        sut.Description.Should().Be("description"); 
    }
}