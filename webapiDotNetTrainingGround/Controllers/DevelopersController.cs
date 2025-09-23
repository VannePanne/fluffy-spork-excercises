using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
using System.Linq;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private readonly Db _db;

    public DevelopersController(Db db)
    {
        _db = db;
    }

    private static DeveloperResponse ToResponse(Developer d) =>
        new DeveloperResponse { Id = d.Id, Name = d.Name, Email = d.Email };

    // GET /api/developers
    [HttpGet]
    public ActionResult<List<DeveloperResponse>> GetAllDevelopers()
    {
        var list = _db.Developers.Select(ToResponse).ToList();
        return list;
    }

    // GET /api/developers/{id}
    [HttpGet("{id:int}")]
    public ActionResult<DeveloperResponse> GetDeveloperById(int id)
    {
        var dev = _db.Developers.FirstOrDefault(d => d.Id == id);
        if (dev is null) return NotFound();
        return ToResponse(dev);
    }

    // POST /api/developers
    [HttpPost]
    public IActionResult CreateNewDeveloper([FromBody] CreateDeveloperRequest request)
    {
        var nextId = _db.Developers.Count == 0 ? 1 : _db.Developers.Max(d => d.Id) + 1;

        var newDev = new Developer
        {
            Id = nextId,
            Name = request.Name!,   
            Email = request.Email!
        };

        _db.Developers.Add(newDev);

        var response = ToResponse(newDev);
        return CreatedAtAction(nameof(GetDeveloperById), new { id = newDev.Id }, response);
    }
}
