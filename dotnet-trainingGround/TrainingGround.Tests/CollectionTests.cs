public class CollectionTests
{

    [Fact]
    public void an_array_has_a_length()
    {
        // act
        var arrayOfIntegers = new int[5];
        var arrayOfIntegersWithValues = new int[] { 1, 2, 3 };
        var arrayOfStrings = new string[] { "Name 1", "Name 2" };

        // assert
        Assert.Equal(5, arrayOfIntegers.Length);
        Assert.Equal(3, arrayOfIntegersWithValues.Length);
        Assert.Equal(2, arrayOfStrings.Length);
    }

    [Fact]
    public void getting_items_out_()
    {
        // act
        var arrString = new string[] { "Name 1", "Name 2" };

        // assert
        Assert.Equal("Name 1", arrString[0]);
        Assert.Equal("Name 2", arrString[1]);
    }
}