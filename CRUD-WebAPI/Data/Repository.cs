using System.Linq;
using System.Threading.Tasks;
using CRUD_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
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
        public void Create<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Developer[]> GetAll()
        {
            IQueryable<Developer> query = _context.Developers;

            query = query.AsNoTracking()
                         .OrderBy(c => c.Id);

            return await query.ToArrayAsync();
        }
        public async Task<Developer> GetById(int id)
        {
            IQueryable<Developer> query = _context.Developers;

            query = query.AsNoTracking()
                         .OrderBy(developer => developer.Id)
                         .Where(developer => developer.Id == id);

            return await query.FirstOrDefaultAsync();
        }
    }
}