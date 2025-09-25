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
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateNewAdressViewModel viewModel)
    {
        var nextId = _db.Adresses.Count + 1;
        var adressToAdd = new Adress()
        {
            Id = nextId,
            Name = viewModel.Name,
            Street = viewModel.Street,
            City = viewModel.City,
            Email = viewModel.Email
        };
        _db.Adresses.Add(adressToAdd);

        return RedirectToAction(nameof(Index));
        // return RedirectToAction(nameof(Details), new { Id = nextId });
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var adress = _db.Adresses.Find(d => d.Id == id);
        if (adress != null)
        {
            _db.Adresses.Remove(adress);
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var adress = _db.Adresses.Find(d => d.Id == id);
    
        return View(adress);
    }
}