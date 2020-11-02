using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementDAL
{
    public interface IEntityManager<T>
    {
        IQueryable<T> FindAll();
        T Find(int id);
        void Save(T entity);
        void Modify(T entity);
        void Delete(int id);
        void Dispose();
    }
}
