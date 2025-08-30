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
}