using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift
{
    public class Employee
    {
        private readonly string? _name;
        private readonly decimal _salary;
        public string? Name { get; set; } = default!;
        public decimal Salary { get; set; }
        
        public Employee(string? name, decimal salary)
        {
            if (name?.Length! <= 0 || name is null)
                throw new ArgumentNullException(nameof(name));
            else
                Name = name;

            if (salary! <= 0)
                throw new ArgumentOutOfRangeException(nameof(salary));
            else
                Salary = salary;
        }

        public override string ToString() => $"Name: {_name} Salary: {_salary.ToString("C")}";
        //{
        //    return $"Name: {_firstName} {_lastName} Salary: {_salary.ToString("C")}";
        //}
    }
}
