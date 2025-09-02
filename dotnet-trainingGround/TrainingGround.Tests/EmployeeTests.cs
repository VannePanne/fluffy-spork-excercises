using TrainingGround;

public class EmployeeTests
{
    [Fact]
    public void an_employee_gets_a_nice_printed_address()
    {
        // arrange
        var emp = new Employee("Marcus", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A Street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

        // assert
        var expected = "Marcus (234-BDAS)" + Environment.NewLine +
               "A Street 23" + Environment.NewLine +
               "Stockholm";

        Assert.Equal(expected, printString);
    }
    [Fact]
        public void an_employee_have_more_than_one_address()
        {
        // arrangeS
        var emp = new Employee("Marcus", "DBCSAS-1253");

        // act
        emp.Addresses.Add(new Address() { Street = "Work street", StreetNo = 2, City = "Stockholm" });
        emp.Addresses.Add(new Address() { Street = "Vacation street", StreetNo = 2, City = "Honolulu" });

        // assert
        Assert.Equal(2, emp.Addresses.Count);
    }
}