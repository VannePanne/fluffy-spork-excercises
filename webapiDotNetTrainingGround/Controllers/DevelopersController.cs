using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;

namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private Db _db;
    public DevelopersController(Db db)
    {
        _db = db;
    }

    [HttpGet("{Id}")]
    public Developer? GetDeveloperById(int id)
    {
        return _db.Developers.Find(d => d.Id == id);
    }

    [HttpGet]
    public List<Developer> GetAllDevelopers()
    {
        return _db.Developers;
    }

    [HttpGet("{id}/address/{addressId}/{street}")]
    public Developer? WhateverMethodName(int id, int addressId, string street);

    [HttpPost]
    public IActionResult CreateNewDeveloper(Developer developerToAdd)
    {
        var nextId = _db.Developers.Count + 1;
        developerToAdd.Id = nextId;
        _db.Developers.Add(developerToAdd);

        return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId }, developerToAdd);
    }
}