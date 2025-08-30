public class PersonTests
{
  [Fact]
  public void create_person_using_parameterless_constructor()
  {
    // act
    var p = new Person();

    // assert
    Assert.NotNull(p);
  }

  [Fact]
  public void create_person_using_constructor_with_name()
  {
    // act
    var p = new Person("Marcus");

    // assert
    Assert.NotNull(p);
    Assert.Equal("Marcus", p.Name);
  }

  [Fact]
    public void create_person_using_constructor_with_birthyear()
    {
        var p = new Person(1972);
        Assert.NotNull(p);
        Assert.Equal(1972, p.BirthYear);
    }

    [Fact]
    public void someone_born_1972_is_50_in_2022()
    {
        var p = new Person(1972);
        var age = p.GetAge(2022);
        Assert.Equal(50, age);
    }

    [Fact]
    public void someone_born_2022_is_0_in_2022()
    {
        var p = new Person(2022);
        var age = p.GetAge(2022);
        Assert.Equal(0, age);
    }
}