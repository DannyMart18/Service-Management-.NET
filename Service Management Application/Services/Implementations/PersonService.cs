using Microsoft.EntityFrameworkCore;
using Service_Management_Application.Models;
using Service_Management_Application.Services.Interfaces;

namespace Service_Management_Application.Services.Implementations;

public class PersonService : IPersonService
{
    private readonly AppDbContext _context;
    
    public PersonService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Persons>> GetAllPersonsAsync()
    {
        return await _context.Persons.ToListAsync();
    }
    
    public async Task<Persons> GetPersonByIdAsync(int id)
    {
        return await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);
    }
    
    
    
    //helper method for testing to create and save a person
    public async Task<Persons> CreatePersonAsync(Persons persons)
    {
        _context.Persons.Add(persons);
        await _context.SaveChangesAsync();
        return persons;
    }
    
    
    
}