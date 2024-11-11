using FluentAssertions;
using Xunit;

namespace insurance.product.management.domain.units.tests;

public class ProductTests
{
    [Theory]
    [InlineData("health care insurance")]
    [InlineData("digital equipments insurance")]
    public void insurance_product_with_required_fields_gets_created_successfully(string name)
    {
        //Arrange

        //Act
        var sut = new Product("1", name);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be(name);
    }

    [Theory]
    [InlineData("Property insurance", "Digital Equipments insurance")]
    [InlineData("Property insurance", "Vehicle insurance")]
    public void insurance_product_with_category_gets_created_successfully(string categoryName, string productName)
    {
        //Arrange
        var category = new ProductCategory("1", categoryName);

        //Act
        var sut = new Product("1", productName, category.Id);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be(productName);
        sut.ProductCategoryId.Should().Be(category.Id);
    }

    [Theory]
    [InlineData("Property insurance", "Digital Equipments insurance", "Mobile insurance")]
    [InlineData("Property insurance", "Digital Equipments insurance", "Tablet insurance")]
    [InlineData("Property insurance", "Digital Equipments insurance", "Laptop insurance")]
    [InlineData("Property insurance", "Digital Equipments insurance", "Game-console insurance")]
    [InlineData("Property insurance", "Digital Equipments insurance", "DIP Plan A")]
    [InlineData("Property insurance", "Digital Equipments insurance", "DIP Plan B")]
    public void insurance_product_with_category_gets_created_successfully_v2(string parentCategoryName,
        string childCategoryName, string productName)
    {
        //Arrange
        var parentCategory = new ProductCategory("1", parentCategoryName);
        var childCategory = new ProductCategory("2", childCategoryName, parentCategory.Id);

        //Act
        var sut = new Product("1", productName, childCategory.Id);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be(productName);
        sut.ProductCategoryId.Should().Be(childCategory.Id);
    }

    [Theory]
    [InlineData("Health insurance", "Group Health insurance", "Organization insurance", "PPO Plan Deluxe")]
    [InlineData("Health insurance", "Group Health insurance", "Organization insurance", "HMP Plan A")]
    [InlineData("Health insurance", "Group Health insurance", "Organization insurance", "PPO Plan Superior")]
    [InlineData("Health insurance", "Individual Health insurance", "Individual insurance",
        "Maximum individual health A")]
    [InlineData("Health insurance", "Individual Health insurance", "Individual insurance",
        "Low cost health coverage B")]
    public void insurance_product_with_category_gets_created_successfully_v3(string parentCategoryName,
        string childCategoryName1, string childCategoryName2, string productName)
    {
        //Arrange
        var parentCategory = new ProductCategory("1", parentCategoryName);
        var childCategory1 = new ProductCategory("2", childCategoryName1, parentCategory.Id);
        var childCategory2 = new ProductCategory("3", childCategoryName2, childCategory1.Id);

        //Act
        var sut = new Product("1", productName, childCategory2.Id);

        //Assert
        sut.Id.Should().Be("1");
        sut.Name.Should().Be(productName);
        sut.ProductCategoryId.Should().Be(childCategory2.Id);
    }

    [Fact]
    public void coverageAvailability_gets_added_to_insurance_product_successfully()
    {
        //Arrange
        var sut = new Product("1", "Premium Auto Coverage");

        var coverageType = new CoverageType("1", "Bodily injury");
        var coverageLevel = new CoverageLevel("1", CoverageLevelType.CoInsurance, null, 100000, 300000, null, null);
        var coverageAvailability = new CoverageAvailability("1", sut.Id, coverageType.Id, coverageLevel);

        //Act
        sut.AddCoverageAvailability(coverageAvailability);

        //Assert
        sut.CoverageAvailabilities.Should().ContainEquivalentOf(coverageAvailability);
    }

    [Fact]
    public void some_coverageAvailabilities_get_added_to_insurance_product_successfully()
    {
        //Arrange
        var sut = new Product("1", "Premium Auto Coverage");

        var bodilyInjuryCoverageType = new CoverageType("1", "Bodily injury");
        var comprehensiveCoverageType = new CoverageType("2", "Comprehensive");
        var collisionCoverageType = new CoverageType("1", "Collision");

        var coverageAvailabilities = new[]
        {
            //Bodily injury
            new CoverageAvailability("1", sut.Id, bodilyInjuryCoverageType.Id,
                new CoverageLevel("1", CoverageLevelType.CoInsurance, null, 100000, 300000, null, null)),
            new CoverageAvailability("2", sut.Id, bodilyInjuryCoverageType.Id,
                new CoverageLevel("2", CoverageLevelType.CoInsurance, null, 250000, 500000, null, null)),

            //Comprehensive
            new CoverageAvailability("3", sut.Id, comprehensiveCoverageType.Id,
                new CoverageLevel("3", CoverageLevelType.Deductibility, 500, null, null, null, null)),

            //Collision
            new CoverageAvailability("4", sut.Id, collisionCoverageType.Id,
                new CoverageLevel("4", CoverageLevelType.CoverageAmount, 10000, null, null, null, null)),
            new CoverageAvailability("5", sut.Id, collisionCoverageType.Id,
                new CoverageLevel("5", CoverageLevelType.Deductibility, 500, null, null, null, null)),
            new CoverageAvailability("6", sut.Id, collisionCoverageType.Id,
                new CoverageLevel("6", CoverageLevelType.Deductibility, 250, null, null, null, null)),
        };

        //Act
        sut.AddCoverageAvailability(coverageAvailabilities);

        //Assert
        sut.CoverageAvailabilities.Should().Contain(coverageAvailabilities);
    }
}