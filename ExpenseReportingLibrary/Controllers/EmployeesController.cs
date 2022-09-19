using ExpenseReportingLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportingLibrary.Controllers
{
    public class EmployeesController
    {
        private readonly AppDbContext _context = null!;
        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.OrderBy(e => e.Name);
        }

        public Employee GetByPK(int Id)
        {
            return _context.Employees.Find(Id);
        }

        public IEnumerable<Employee> GetByNamePartial(string subString)

        {
            IEnumerable<Employee> employees = from e in _context.Employees
                                              where e.Name.contains(subString)
                                              orderby e.Name
                                              select e;
            return employees;
        }
        public void Update(int Id, Employee employee)
        {
            if (Id != employee.Id)
            {
                throw new ArgumentException("Employee id doesn't match employee instance!");
            }
            _context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return;
            
            public Employee Insert(Employee employee)
            {
                if (employee.Id! = 0)
                {
                    throw new ArgumentException("Inserting a new employee requires the Id be set to 0!");
                }
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return employee;

            }
            public void Delete(int Id)
            {
                Employee? empl = GetByPK(int Id);
                if (empl is null)
                {
                    throw new Exception("Employee not found");
                }
                _context.Remove(empl);
                _context.SaveChanges();
            }
        }
}
