using System;
using System.Collections.Generic;
using System.Text;

namespace DiabetesControl.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;
        bool BeginNewTransaction();
        bool RollBackTransaction();
        int SaveChanges();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
