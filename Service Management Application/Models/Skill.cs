using Service_Management_Application.Controllers;

namespace Service_Management_Application.Models;

public class Skill
{
    public int Id { get; set; }
    public string SkillName { get; set; }
    public string SkillDescription { get; set; }
    public int SkillLevel { get; set; }
    public int PersonId { get; set; }
    public int ProjectId { get; set; }
    public Persons Person { get; set; }
    public Project Project { get; set; }
}