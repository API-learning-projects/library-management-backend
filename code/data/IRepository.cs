namespace LibraryManagement.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        Task<T> Get(int id);
        IEnumerable<T> GetAll();
    }
}