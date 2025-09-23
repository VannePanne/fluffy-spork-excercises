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

    [HttpGet("{id}/address/{addressId}/{street}")]
    public Developer? WhateverMethodName(int id, int addressId, string street);

    [HttpPost]
    public IActionResult CreateNewDeveloper(Developer developerToAdd)
    {
        var nextId = _db.Count + 1;
        developerToAdd.Id = nextId;
        _db.Add(developerToAdd);

        return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId }, developerToAdd);
    }
}