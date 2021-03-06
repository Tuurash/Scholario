﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using Scholar.Models;
using WebApplication1.Repository;

namespace Scholar.Repository
{
      public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
        {
            scholarDBContext context;
            public Repository()
            {
                context = new scholarDBContext();
            }
            public IEnumerable<TEntity> GetAll()
            {
                return context.Set<TEntity>().ToList();
            }

            public TEntity Get(int id)
            {
                return context.Set<TEntity>().Find(id);
            }

            public void Insert(TEntity entity)
            {
                
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }

            public void Update(TEntity entity)
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }

            public void Delete(int id)
            {
                context.Set<TEntity>().Remove(this.Get(id));
                context.SaveChanges();
            }
        }
}