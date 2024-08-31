using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        //ICategoryDal, IGenericDal<Category> arayüzünü genişleten bir arayüz.
        //Arayüzler (interfaceler) yalnızca imza (signature) belirler; herhangi bir implementasyon içermezler. 
    }
}
