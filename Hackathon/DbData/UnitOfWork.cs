﻿using Hackathon.Data;
using Hackathon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hackathon.DbData
{
    public class UnitOfWork : IDisposable
    {
        private readonly EFDbContext context;
        private bool disposed;
        private Dictionary<string, object> repositories;

        public UnitOfWork(EFDbContext context)
        {
            this.context = context;
        }

        public UnitOfWork()
        {
            context = new EFDbContext();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public Service<T> Service<T>() where T : BaseEntity
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Service<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (Service<T>)repositories[type];
        }
    }
}