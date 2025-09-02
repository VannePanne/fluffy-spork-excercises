public class LinqTests
{

    [Fact]
    public void linq_to_filer_numbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
    [Fact]
    public void linq_to_find_first()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var firstNumberLargerThan15 = numbers.Find(number => number > 15);

        // assert
        Assert.Equal(53, firstNumberLargerThan15);
    }
    [Fact]
    public void linq_to_check_if_any_matches()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var anyOver100 = numbers.Any(number => number > 100);

        // assert
        Assert.Equal(false, anyOver100);
    }

    [Fact]
    public void filter_people_by_age()
    {
        // arrange
        var people = new List<Person> {
            new Person("Aaaron"),
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        // act
        var allWithLongNames = people
            .Where(p => p.Name.Length > 4)
            .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaaron", allWithLongNames[0].Name);
    }
    [Fact]
    public void filter_people_by_age_only_names()
    {
        // arrange
        var people = new List<Person> {
            new Person("Aaaron"),
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        // act
        var allWithLongNames = people
            .Where(p => p.Name.Length > 4)
            .Select(p => p.Name)
            .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaaron", allWithLongNames[0]);
        Assert.Equal("Ceasar", allWithLongNames[1]);
    }
    [Fact]
    public void filter_people_by_age_names_age()
    {
        // arrange
        var a = new Person("Aaaron");
        a.LengthInMeters = 1.96;
        var people = new List<Person> {
            a,
            new Person("Bea"),
            new Person("Ceasar"),
            new Person("Dave"),
        };

        // act
        var namesAndAges = people
            .Where(p => p.Name.Length > 4)
            .Select(p => new { Name = p.Name, Height = p.LengthInMeters })
            .ToList();

        // assert
        Assert.Equal(2, namesAndAges.Count);
        Assert.Equal("Aaaron", namesAndAges[0].Name);
        Assert.Equal(1.96, namesAndAges[0].Height);
    }
    [Fact]
    public void sort_numbers_in_ascending_and_descending_order()
    {
        // arrange
        var numbers = new List<int> { 5, 2, 9, 1, 7 };

        // act
        var ascending = numbers.OrderBy(n => n).ToList();
        var descending = numbers.OrderByDescending(n => n).ToList();

        // assert
        Assert.Equal(new List<int> { 1, 2, 5, 7, 9 }, ascending);
        Assert.Equal(new List<int> { 9, 7, 5, 2, 1 }, descending);
    }

}