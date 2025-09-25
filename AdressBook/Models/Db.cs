namespace AdressBook.Models;

public class Db
{
    public Db()
    {
        Adresses = new List<Adress>
        {
            new Adress { Id = 1, Name = "Marcus", Street ="Hölöv", City = "Hölö", Email = "marcus@salt.dev" },
            new Adress { Id = 2, Name = "Vanessa",Street ="Kyrkv", City = "Tumba", Email = "vanne@salt.dev" },
        };
    }

    public List<Adress> Adresses { get; set; }
}
