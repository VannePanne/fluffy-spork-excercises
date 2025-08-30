
    public class Person
    {
        public string? Name { get; private set; }
        public int BirthYear { get; private set; }
        public Address Address { get; set;}

   

        public double LengthInMeters;
    

        public Person() {}
        public Person(string name) 
        {
            this.Name = name;
        }
        public Person(int birthYear)
        {
            this.BirthYear = birthYear;
        }
        public Person(string name, int birthYear)
        {
            this.Name = name;
            this.BirthYear = birthYear;
        }

        public int GetAge(int currentYear)
        {
            return currentYear - this.BirthYear;
        }
        public virtual string GetPrintString()
        {
            return @$"{this.Name}
    {this.Address.Street} {this.Address.StreetNo}
    {this.Address.City}";
        }
    }