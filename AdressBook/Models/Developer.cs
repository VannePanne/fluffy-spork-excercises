using AdressBook.Models;

namespace AdressBook.Models;

public class Adress
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Street { get; set;}
    public string City { get; set; }
    public string? Email { get; set; }
}