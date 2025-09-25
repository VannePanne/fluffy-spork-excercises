using Microsoft.AspNetCore.Mvc;
using AdressBook.Models;

namespace AdressBook.Controllers;

public class AdressBookController : Controller
{
  private Db _db;
  public AdressBookController(Db db)
    {
        _db = db;
    }
  public IActionResult Index()
    {
        return View(_db.Adresses);
    }
}