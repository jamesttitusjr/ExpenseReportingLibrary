using Microsoft.EntityFrameworkCore.Query;
using ExpenseReportingLibrary.Controllers;
using ExpenseReportingLibrary.Models;
using System.Reflection;



Console.WriteLine("Expense Reporting");

AppDbContext _context = new();

EmployeesController emplCtrl = new(_context);

List<Employee> empls = emplCtrl.GetAll().ToList();

foreach (Employee empl in empls)
{
    Print(empl);
}

void Print(object obj)
{
    Console.WriteLine(obj);
    System.Diagnostics.Debug.WriteLine(obj.ToString());
}