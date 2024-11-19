
using EmployeeWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApi.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EmployeeContext _employeeContext;
        private readonly DbSet<T> _table;
        public Repository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
            _table = _employeeContext.Set<T>();
        }
        public int Add(T entity)
        {
            _table.Add(entity);
            return _employeeContext.SaveChanges();
        }

        public T Get(Guid id)
        {
            var entity = _table.Find(id);
            return entity;
        }

        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }
    }
}
