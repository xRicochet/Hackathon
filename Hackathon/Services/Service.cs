using Hackathon.Data;
using Hackathon.DbData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hackathon.Services
{
    public class Service<T> where T : BaseEntity
    {
        private readonly EFDbContext context;
        private IDbSet<T> entities { get; set; }

        public Service(EFDbContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public T GetById(object id)
        {
            return this.entities.Find(id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.entities.Add(entity);
            this.context.SaveChanges();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            this.entities.Remove(entity);
            this.context.SaveChanges();
        }
        public virtual IQueryable<T> Table
        {
            get
            {
                return this.entities;
            }
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = context.Set<T>();
                }
                return entities;
            }
        }
    }
}