using DiabetesControl.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiabetesControl.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext dbContext;
        private IDbContextTransaction _transation;
        private bool _disposed;
        private DbContext DbContext
        {
            get
            {
                if (dbContext == null)
                    dbContext = new MasterContext();
                return dbContext;
            }
            set { dbContext = value; }
        }

        public bool BeginNewTransaction()
        {
            try
            {
                _transation = (IDbContextTransaction)DbContext.Database.BeginTransaction();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(DbContext);
        }

        public bool RollBackTransaction()
        {
            try
            {
                _transation.Rollback();
                _transation = null;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public int SaveChanges()
        {
            try
            {
                int result = 0;
                result = DbContext.SaveChanges();
                return result;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}