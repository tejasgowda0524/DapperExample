using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IEmployee
    {
        public Task<IEnumerable<Employee>> GetEmployees();

        Task<Employee> GetEmployeeById(int id);
    }
}
