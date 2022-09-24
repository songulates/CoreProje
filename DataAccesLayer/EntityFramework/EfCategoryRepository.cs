using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfCategoryRepository:GenericRepository<Category>,ICategoryDal
    //böylece EfCategoryRepository sınıfım hem GenericRepository içinde yer alan metodları alacak t parametresine göre hemde  ICategoryDal ı
    //ICategoryDal ı constructor metodla kullanacak
    {
    }
}
