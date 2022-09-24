using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesLayer.Abstract
{
    public interface IBlogDal : IGenereicDal<Blog> /// IGenereicDal dan miras alacaksın değerlerini blogdan alacaksın
    {
        //List<Blog> ListAllBlog();//Blog tümünü getir listeleme-read-crud
        //void AddBlog(Blog blog);
        //void DeleteBlog(Blog blog);
        //void UpdateBlog(Blog blog);
        ////birde ID ye göre veri getirilecek metod kullnılacak
        //Blog GetById(int id);
        List<Blog> GetListWithCategory();
    }
}
