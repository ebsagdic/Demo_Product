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
    public class EFCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        //EFCategoryDal sınıfı, GenericRepository<Category> sınıfından türemektedir.
        //GenericRepository<T> sınıfının bir yapıcı metodu (constructor) vardır ve bu yapıcı metod, ApplicationDbContext türünde bir parametre alır.
        //Dolayısıyla, EFCategoryDal sınıfının da bu yapıcı metodu çağırması gerekir.
        //EFCategoryDal sınıfı kendi yapıcı metodunda bu parametreyi üst sınıfa (base(context)) iletmek zorundadır.
        //Bu, GenericRepository<Category> sınıfının sağlıklı bir şekilde çalışabilmesi için gerekli olan ApplicationDbContext nesnesinin oluşturulup sınıfa aktarılmasını sağlar.
        public EFCategoryDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
