using Domain.Models;
using Infrastructure.Services;

var emp1 = new Employee
{
    Id = 1,
    FirstName = "Siyovush",
    LastName = "Astonov",
    Salary = 1000,
    BirthDate = new DateTime(2005, 2, 23),
    Department = new Department(1,"IT Company", "Best Company"),
};

var empservice = new EmployeeService();
empservice.AddEmployees(emp1);

foreach (var employee in empservice.GetEmployees())
{
    Console.WriteLine(empservice.GetFullInfo(employee));
}
