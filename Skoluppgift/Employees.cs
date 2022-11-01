using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift
{
    public class Employees
    {
        private string _name;
        private decimal _salary;

        private readonly List<string>? _employeeNames = new List<string>();
        private readonly List<decimal> _employeeSalaries = new List<decimal>();

        public string Name { get => _name; set => _name = value; }
        public decimal Salary { get => _salary; set => _salary = value; }


        public Employees()
        {

        }
        //public Employees(string name, decimal salary)
        //{
        //    Name = name;
        //    Salary = salary;
        //}

        public void AddNEmployeeName(string addName)
        {

            if (addName is null)
            {
                throw new ArgumentNullException(nameof(addName));
            }
            _name = addName;
            _employeeNames?.Add(_name);

        }
        public void AddEmployeeSalary(decimal addSalary)
        {


            if (addSalary < 0)
            {
                throw new ArgumentNullException(nameof(addSalary));
            }
            _salary = addSalary;
            _employeeSalaries.Add(_salary);
        }
        public void GetEmployeeInformation()
        {
            foreach (var name in _employeeNames)
            {
                foreach (var salary in _employeeSalaries)
                    Console.Write($"Employee: {name.ToLower()} has salary: {salary.ToString("C")}\n");

            }
        }
    }
}
