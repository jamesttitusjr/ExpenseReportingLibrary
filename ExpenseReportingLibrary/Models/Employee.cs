using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportingLibrary.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public Decimal ExpenseDue { get; set; }
        public Decimal ExpensePaid { get; set; }
        
        public override string ToString()
        {
            return $"{ExpenseDue}, {ExpensePaid}";
        }
    }
}
