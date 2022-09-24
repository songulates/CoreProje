using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreproje.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository()); //blogmanagerden bir bm nesnesi türet ve bunu efrepository ile newle
        public IActionResult Index()
        { //index blogların listeleneceği sayfa olacak


            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id) 
        {
            var values = bm.GetBlogById(id);
            return View(values);
            
        }
        
    }
}
