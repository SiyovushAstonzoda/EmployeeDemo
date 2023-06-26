namespace Domain.Models;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public decimal Salary { get; set; }
    public DateTime BirthDate { get; set; }
    public Department? Department { get; set; }

    public Employee()
    {
        
    }

    public Employee(int id, string firstname, string lastname, decimal salary, DateTime dateTime, Department department)
    {
        Id = id;
        FirstName = firstname;
        LastName = lastname;
        Salary = salary;
        BirthDate = dateTime;
        Department = department;
    }
}
