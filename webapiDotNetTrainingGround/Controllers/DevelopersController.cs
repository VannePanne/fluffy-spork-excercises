using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private List<Developer> _db;

    public DevelopersController()
    {
        _db = new List<Developer>();
    }

    [HttpGet("{Id}")]
    public Developer? GetDeveloperById(int id)
    {
        return _db.Find(d => d.Id == id);
    }

    [HttpGet]
    public List<Developer> GetAllDevelopers()
    {
        return _db;
    }
    

}