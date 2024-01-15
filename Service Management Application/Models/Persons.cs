using System.Diagnostics.CodeAnalysis;
using Service_Management_Application.Enums;

namespace Service_Management_Application.Models
{
    public class Persons
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Grades Grade { get; set; }
        public List<Skill> Skills { get; set; } = new List<Skill>(); // Initialize the list
    }
}