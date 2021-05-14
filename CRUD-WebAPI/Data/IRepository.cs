using System.Threading.Tasks;
using CRUD_WebAPI.Models;

namespace CRUD_WebAPI.Data
{
    public interface IRepository
    {
        Developer Create(Developer developer);

        Developer Update(Developer developer);

        Developer Delete(Developer developer);
        
        Task<bool> SaveChangesAsync();

        Task<Developer[]> GetAll();   

        Task<Developer> GetById(int id);
    }
}