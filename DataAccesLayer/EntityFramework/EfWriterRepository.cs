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
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer t)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            throw new NotImplementedException();
        }

        Writer IGenereicDal<Writer>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Writer> IGenereicDal<Writer>.GetlistAll()
        {
            throw new NotImplementedException();
        }
    }
}
