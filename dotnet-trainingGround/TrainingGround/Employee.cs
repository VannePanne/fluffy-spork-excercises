namespace TrainingGround
{
    public class Employee : Person, IPrintable
    {
        public Employee() : base()
        {
        }
        public Employee(string name, string employeeId) : base(name)
        {
            this.EmployeeId = employeeId;
        }

        public string EmployeeId { get; set; }

        public override string GetPrintString()
{
    return @$"{Name} ({EmployeeId})
{Address.Street} {Address.StreetNo}
{Address.City}";
}

    }
}