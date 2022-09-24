using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class GenericRepository<T> : IGenereicDal<T> where T : class
    {
        //context c =new context();
        public void Delete(T t)
        {
            //Metodların içini dolduralım
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c=new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetlistAll()
        {
            using var c=new Context();  
            return c.Set<T>().ToList(); 
        }

        public void Insert(T t)
        {
            using var c=new Context();  
            c.Add(t);
            c.SaveChanges();
        }

        public List<T> GetlistAll(Expression<Func<T, bool>> filter)
        {
            //repoasitoryde Igeneric metodların altını dolduruyoz
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();//where ile filterdan gelen değeri listeleyecek
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
