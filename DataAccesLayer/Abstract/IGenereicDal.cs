using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccesLayer.Abstract
{
    public interface IGenereicDal<T> where T : class  //dışardan bir entiti parametresi göndermemiz gerekiyo T entiynin karşılığı olan değer T bir class a ait tüm deeğerleri kullanacak
    {
        void Insert(T t);  //ekleme metodu eklendi.T türünde ve t isminde bir entitiyden paramtre alıyor
        void Delete(T t);
        void Update(T t);
        List<T> GetlistAll(); //listeleme işlemi için
        T GetById(int id); //id ye göre getirme
        //blog detaylarında bloğa göre listeleme işlemi yapacak bunun için expressiondan faydalanmak lazım
        List<T> GetlistAll(Expression<Func<T, bool>> filter); //şartlı sorgulamalarda kullanılıyo
    }
}
