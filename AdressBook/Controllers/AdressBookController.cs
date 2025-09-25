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
    public IActionResult Details(int id){
        var adress = _db.Adresses.Find(d => d.Id == id);
        return View(adress);
    }

}