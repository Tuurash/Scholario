using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scholar.Models;
using System.Threading.Tasks;


namespace WebApplication1.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}