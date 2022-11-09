using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift
{
    public class Register
    {
        private readonly List<Employee> _employees = new();

        public void AddEmployee(string name, decimal salary)
        {
            if (name is null && salary! >= 0)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Employee emp = new(name, salary);

            _employees?.Add(emp);

        }
        public void AddEmployee(Employee emp)
        {
            if (emp.Name is not null && emp.Salary! <= 0)
            {
                throw new ArgumentNullException(nameof(emp));
            }
            _employees?.Add(emp);

        }

        public void TestData()
        {
            //_employees.Add("nils", 222);
        }
        //public IEnumerable<Employee> GetEmployeesInformation()
        //{
        //    return _employees.ToArray();
        //}   
        public List<Employee> GetEmployeesInformation() => _employees.ToList();
        
    }
}
