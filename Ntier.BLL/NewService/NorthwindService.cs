using Ntier.DAL.Context;
using Ntier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.BLL.NewService
{
    public class NorthwindService<T>: INorthwindService<T> where T : BaseClass
    {
        NortwindContext _context= new NortwindContext();

        public string Create(T model)
        {
           
            _context.Set<T>().Add(model);
            _context.SaveChanges();
            return "VERİ KAYDEDİLDİ";   

        }

        public string Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null) 
            {
                return "VERİ KALDIRILDI";
            }
            _context.Set<T>().Remove(entity);
            _context.SaveChanges() ;
            return "veri silindi";

        }


        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }


        public string Update(T model)
        {
            _context.Set<T>().Update(model);
            _context.SaveChanges();
            return "VERİ GÜNCELLENDİ";
        }

        List<T> INorthwindService<T>.GetAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
