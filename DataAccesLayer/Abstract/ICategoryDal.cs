using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal : IGenereicDal<Category> //direk jenerikten miras aldık
    {
        //burada 4 metod tanımlanacak 3 ü void diğeri farklı
        //List<Category> ListAllCategory();//kategorinin tümünü getir listeleme-read-crud
        //void AddCategory(Category category);
        //void DeleteCategory(Category category); 
        //void UpdateCategory(Category category); 
        ////birde ID ye göre veri getirilecek metod kullnılacak
        //Category GetById(int id);
        ////***tanımlamış olduğumuz entityler için birer tane dataacceslayer interface tanımlayacak böylece hiç bir entity boş kalmayacak.
    }
}
