namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    /*private AgeCalculator _calculator;

    public AgeCalculatorTests()
    {
        _calculator = new AgeCalculator();
    }
    
    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {

        // act
        var age = _calculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);

    }

    [Fact]
    public void someone_born_2022_is_0_in_2022()
    {

        // act
        var age = _calculator.GetAge(2022, 2022);

        // assert
        Assert.Equal(0, age);

    }

    [Fact]
    public void a_person_born_1972_is_50_2022()
    {
        // arrange
        var p = new Person(1972);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(50, age);
    }
    [Fact]
    public void a_person_born_1982_is_40_2022()
    {
        // arrange
        var p = new Person(1982);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(40, age);
    }
    [Fact]
    public void a_person_born_1992_is_30_2022()
    {
        // arrange
        var p = new Person(1992);

        // act
        var age = p.GetAge(2022);

        // assert
        Assert.Equal(30, age);
    } */
    [Theory]
    [InlineData(1972, 2022, 50)]
    [InlineData(1982, 2022, 40)]
    [InlineData(1992, 2022, 30)]
    [InlineData(2022, 2022, 0)]
    public void person_age_is_correct(int birthYear, int currentYear, int expectedAge)
    {
        // act
        var age = AgeCalculator.GetAge(birthYear, currentYear);

        // assert
        Assert.Equal(expectedAge, age);
    }
   
}