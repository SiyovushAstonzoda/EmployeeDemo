namespace Infrastructure.Services;
using Domain.Models;
public class EmployeeService
{
    private List<Employee>? _employees;
    public EmployeeService()
    {
        _employees = new List<Employee>();
    }

    public List<Employee>? GetEmployees()
    {
        return _employees; 
    }

    public void AddEmployees(Employee employee)
    {
        _employees.Add(employee);
    }

    public int? CountEmployees() 
    {
        return _employees.Count(); 
    }

    public string GetFullInfo(Employee employee)
    {
        return $"Employee Id: {employee.Id}{Environment.NewLine}Employee FirstName: {employee.FirstName}{Environment.NewLine}Employee LastName: {employee.LastName}{Environment.NewLine}Employee Salary: {employee.Salary}{Environment.NewLine}Employee BirthDate: {employee.BirthDate.ToShortDateString()}{Environment.NewLine}Employee Department Id: {employee.Department.Id}{Environment.NewLine}Employee Department Name: {employee.Department.Name}{Environment.NewLine}Employee Department Description: {employee.Department.Description}";
    }
}