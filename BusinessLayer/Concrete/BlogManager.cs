using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogdal;

        public BlogManager(IBlogDal blogdal)
        {
            _blogdal = blogdal;
        }

        public void BlogDelete(Blog category)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog category)
        {
            throw new NotImplementedException();
        }

        public void BlogyAdd(Blog category)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogdal.GetListWithCategory();
            //Iblogdal içindeki sadece ıgeneric dala değil içinde tanımlamış olduğum metodlarada erişebiliyoruz.
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogdal.GetlistAll();
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogdal.GetlistAll(x => x.BlogID == id);
        }
    }
}
