namespace Infrastructure.Services;
using Domain.Models;
public class DepartmentService
{
    private List<Department> _departments;
    public DepartmentService()
    {
        _departments = new List<Department>();
    }

    public List<Department> GetDepartments()
    {
        return _departments;
    }

    public void AddDepartments(Department department)
    {
        _departments.Add(department);
    }

    public int GetDepartmentCount()
    {
        return _departments.Count;
    }
}