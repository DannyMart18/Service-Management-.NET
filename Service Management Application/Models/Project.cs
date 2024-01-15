namespace Service_Management_Application.Models;

public class Project
{
    public int Id { get; set; }
    public string ProjectName { get; set; }
    public string ProjectDescription { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public List<Skill> Skills { get; set; } = new List<Skill>(); // Initialize the list
}