using Microsoft.AspNetCore.Mvc;
using Service_Management_Application.Models;
using Service_Management_Application.Services.Implementations;
using Service_Management_Application.Services.Interfaces;

namespace Service_Management_Application.Controllers;

[ApiController]
[Route("[controller]")]
public class Person : Controller
{

    private readonly IPersonService _personService;
    
    public Person(IPersonService personService)
    {
        _personService = personService;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Persons>> GetAll()
    {
        return await _personService.GetAllPersonsAsync();
    }
    
    // New action method to get a person by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<Persons>> GetById(int id)
    {
        var person = await _personService.GetPersonByIdAsync(id);
        if (person == null)
        {
            return NotFound();
        }
        return person;
    }


}