using EmployeeWebApi.Exceptions;
using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories;

namespace EmployeeWebApi.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly IRepository<Employee> _repository;

        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }
        public Guid Add(Employee employee)
        {
            _repository.Add(employee);
            return employee.Id;
        }

        public Employee GetEmployee(Guid id)
        {
            var employee = _repository.Get(id);
            if (employee == null)
                throw new NoEmployeeException("No such employee Exist");//If the employee is null then it throw this error
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            var emplyees = _repository.GetAll().ToList();
            return emplyees;
        }
    }
}
