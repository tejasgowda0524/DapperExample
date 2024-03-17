using Business.Interface;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class EmployeeServiceBL : IEmployeeBL
    {
        private readonly IEmployee employee;


        public EmployeeServiceBL(IEmployee employee)
        {
            this.employee = employee;
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            return employee.GetEmployees();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await employee.GetEmployeeById(id);
        }

    }
}
