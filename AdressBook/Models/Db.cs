namespace AdressBook.Models;

public class Db
{
    public Db()
    {
        Adresses = new List<Adress>
        {
            new Adress { Id = 1, Name = "Marcus",  Email = "marcus@salt.dev" },
            new Adress { Id = 2, Name = "Vanessa", Email = "bea@salt.dev"    },
        };
    }

    public List<Adress> Adresses { get; set; }
}
