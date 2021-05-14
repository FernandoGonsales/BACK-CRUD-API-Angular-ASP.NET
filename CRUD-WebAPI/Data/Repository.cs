using System.Linq;
using System.Threading.Tasks;
using CRUD_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public Developer Create(Developer developer)
        {
            _context.Developers.AddRangeAsync(developer);
            return developer;
        }

        public Developer Update(Developer developer)
        {
            _context.Developers.UpdateRange(developer);
            return developer;
        }
        public Developer Delete(Developer developer)
        {
            _context.Developers.RemoveRange(developer);
            return developer;
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        public async Task<Developer> GetById(int id)
        {
            IQueryable<Developer> query = _context.Developers;

            query = query.AsNoTracking()
                         .OrderBy(developer => developer.Id)
                         .Where(developer => developer.Id == id);

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Developer[]> GetAll()
        {
            IQueryable<Developer> query = _context.Developers;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
    }
}