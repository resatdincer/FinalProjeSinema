using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema.Repository
{
    internal interface IRepo<T> : IDisposable where T : class
    {
        IQueryable<T> GetAllEntities();
        T GetEntityById(int id);
        bool InsertEntity(T entity);
        bool UpdateEntity(T entity);
        bool DeleteEntity(int id);
    }
}
