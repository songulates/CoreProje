using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogyAdd(Blog category);
        void BlogDelete(Blog category);
        void BlogUpdate(Blog category);
        List<Blog> GetList();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
    }
}  
