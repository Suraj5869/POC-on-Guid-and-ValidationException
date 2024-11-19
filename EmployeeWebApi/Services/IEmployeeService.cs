using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories;

namespace EmployeeWebApi.Services
{
    public interface IEmployeeService
    {
        public Guid Add(Employee employee);
        public List<Employee> GetEmployees();
        public Employee GetEmployee(Guid id);
    }
}
