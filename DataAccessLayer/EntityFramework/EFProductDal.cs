using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.OOP.ApplicationContext;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        public EFProductDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
