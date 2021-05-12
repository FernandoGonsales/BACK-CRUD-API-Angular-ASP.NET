using System.Threading.Tasks;
using CRUD_WebAPI.Models;

namespace CRUD_WebAPI.Data
{
    public interface IRepository
    {
        void Create<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        
        Task<bool> SaveChangesAsync();

        Task<Developer[]> GetAll();   

        Task<Developer> GetById(int id);
    }
}