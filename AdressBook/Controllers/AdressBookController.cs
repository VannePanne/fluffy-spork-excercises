using Microsoft.AspNetCore.Mvc;
namespace AdressBook.Controllers;

public class AdressBookController : Controller
{
  private Db _db;
  public AdressBookController(Db db)
  {
    _db = db;
  }
}