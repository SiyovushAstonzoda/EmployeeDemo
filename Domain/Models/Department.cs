namespace Domain.Models;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Employee? Employee { get; set; }

    public Department()
    {
        
    }

    public Department(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}

