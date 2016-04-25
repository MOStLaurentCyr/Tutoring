using DataLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DataLayer.Entities;
using DataLayer;

namespace DataLayer.EntityFramework
{
    public class EfEntityRepository<T>: IRepository<T> where T:EntityDal 
    {
        private readonly EfTutoringDbContext _context;

        public EfEntityRepository(DbContext dbContext)
        {
            _context = new EfTutoringDbContext();
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().FirstOrDefault(t => t.Id == id);
        }

        public void Add(T tutor)
        {
            _context.Set<T>().Add(tutor);
            _context.SaveChanges();
        }

        public void Update(T tutor)
        {
            _context.Set<T>().Attach(tutor);
            _context.Entry(tutor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T tutor)
        {
            _context.Set<T>().Remove(tutor);
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            _context.Set<T>().RemoveRange(_context.Set<T>());
            _context.SaveChanges();
        }
    }
}
