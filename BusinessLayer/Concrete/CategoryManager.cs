using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService //interfacedan miras aldık
    {
        ICategoryDal _categoryDal;
        //public CategoryManager() //konstructor metod tanımladık yapıcı metod içerisinde newlwmw işlemi gerçekleşti
        //{
        //    efCategoryRepository = new EfCategoryRepository();  
        //}

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; //yapıcı metodda  not categoridala göre constructur medor oluşturdu manaeger
        }

        public void CategoryAdd(Category category)
        {

            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetlistAll();
        }
    }
}
