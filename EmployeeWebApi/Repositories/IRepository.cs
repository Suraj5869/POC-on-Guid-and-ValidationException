namespace EmployeeWebApi.Repositories
{
    public interface IRepository<T>
    {
        public int Add(T entity);
        public IQueryable<T> GetAll();
        public T Get(Guid id);
    }
}
