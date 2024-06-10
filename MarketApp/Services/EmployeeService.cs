using MarketApp.Entities;
using MarketApp.Infrastructure;

namespace MarketApp.Services
{
    public class EmployeeService
    {
        public List<Employee> GetAll()
        {
            return Database.Employees;
        }

        public Employee Get(int id)
        {
            return Database.Employees.First(p => p.Id == id);
        }
    }
}
