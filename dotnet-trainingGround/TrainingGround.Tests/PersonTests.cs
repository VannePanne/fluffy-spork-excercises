namespace TrainingGround.Tests;

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
  [Fact]
  public void an_employee_is_a_person()
  {
    // act
    var emp = new Employee();
    emp.LengthInMeters = 1.95;

    // assert
    Assert.IsType(typeof(Employee), emp);
    Assert.Equal(1.95, emp.LengthInMeters);
  }
  [Fact]
  public void an_employee_has_an_employeeId()
  {
    // act
    var emp = new Employee("Marcus", "234-BDAS");

    // assert
    Assert.IsType(typeof(Employee), emp);
    Assert.Equal("Marcus", emp.Name);
    Assert.Equal("234-BDAS", emp.EmployeeId);
  }
  [Fact]
  public void a_person_has_an_address()
  {
    // arrange
    var p = new Person("Marcus");

    // act
    p.Address = new Address();
    p.Address.Street = "A Street";
    p.Address.StreetNo = 23;
    p.Address.City = "Stockholm";

    // assert
    Assert.NotNull(p.Address);
    Assert.IsType(typeof(Address), p.Address);

    Assert.Equal("A Street", p.Address.Street);
    Assert.Equal(23, p.Address.StreetNo);
    Assert.Equal("Stockholm", p.Address.City);
  }
  
}