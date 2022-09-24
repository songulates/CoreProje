using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    //IBlog dalda bir metod tanımladın getlistwithcategori bunu buraya implemente et
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c = new Context()) 
            {
                return c.Blogs.Include(x => x.Category).ToList(); //include içine hangi entity include(dahil) edilecek
            //sonra business katmanı içinde bu metod çağırılacak
            }
        }
    }
}
