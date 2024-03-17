using Dapper;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly Context.DapperContext _context;
        public EmployeeService(Context.DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var query = "SELECT * FROM Employee";
            using (var connection = _context.createconn())
            {
                var employee = await connection.QueryAsync<Employee>(query);
                return employee.ToList();

            }

        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var query = "SELECT * FROM Employee WHERE Id = @Id";
            using (var connection = _context.createconn())
            {
                var employee = await connection.QueryFirstOrDefaultAsync<Employee>(query, new { Id = id });
                return employee;
            }
        }


    }
}
