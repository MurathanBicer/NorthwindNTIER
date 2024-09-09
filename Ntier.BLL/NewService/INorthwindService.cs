using Ntier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntier.BLL.NewService
{
    public interface INorthwindService<T> where T : BaseClass
    {
        List<T> GetAll();
        string Create(T model);
        T GetById(int id);
        string Update(T model);

        string Delete(int id);
    }
}
