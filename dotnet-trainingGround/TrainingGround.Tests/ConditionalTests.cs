using System.ComponentModel;
using TrainingGround;
public class ConditionalTests
{
    /*[Fact]
    public void should_be_kid_when_younger_than_18()
    {
        // arrange
        var p = new Person(2005);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Kid, category);
    }

    [Fact]
    public void should_be_adult_when_older_than_18()
    {
        // arrange
        var p = new Person(2002);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Adult, category);
    }
    [Fact]
    public void when_50_then_prime_Age()
    {
        // arrange
        var p = new Person(1972);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Prime, category);
    }
    [Fact]
    public void return_under_18_for_kid()
    {
        // act
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Kid);

        // assert
        Assert.Equal("Under 18 years", span);
    }*/

    [Theory]
    [InlineData(AgeCategory.Kid, "Under 18 years")]
    [InlineData(AgeCategory.Adult, "Above 18")]
    [InlineData(AgeCategory.Prime, "Exactly 50 - and proud!")]
    [InlineData((AgeCategory)999, "Unknown")]
    public void return_age_span(AgeCategory category, string expected)
    {
        // act
        var span = AgeCalculator.GetAgeSpan(category);

        // assert
        Assert.Equal(expected, span);
    }
}

