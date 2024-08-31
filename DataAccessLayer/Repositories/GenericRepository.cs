using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.OOP.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Delete(T item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Update(item);
            _context.SaveChanges();
        }
    }
}
