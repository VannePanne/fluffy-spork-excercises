using Microsoft.AspNetCore.Mvc;
using mvcDotNetTrainingGround.Models;
namespace mvcDotNetTrainingGround.Controllers;

public class DevelopersController : Controller
{
  private Db _db;
  public DevelopersController(Db db)
  {
    _db = db;
  }

  public IActionResult Index()
  {
    return View(_db.Developers);
  }
  public IActionResult Details(int id)
  {
    var developer = _db.Developers.Find(d => d.Id == id);
    return View(developer);
  }
  public IActionResult Create()
  {
    return View();
  }
}