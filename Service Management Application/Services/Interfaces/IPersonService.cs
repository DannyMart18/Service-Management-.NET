using Service_Management_Application.Models;

namespace Service_Management_Application.Services.Interfaces;

public interface IPersonService
{
    Task<IEnumerable<Persons>> GetAllPersonsAsync();
    Task<Persons> GetPersonByIdAsync(int id);
    
}



