using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Visums.Domain.Interface;

namespace Visums.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private readonly Guid idTransaction;
        public IDbConnection Connection { get; } = null;

        public IDbTransaction Transaction { get; private set; } = null;

        public Guid IdTransaction { get { return idTransaction; } }

        public IsolationLevel IsolationLevel => throw new NotImplementedException();

        public UnitOfWork(IDbConnection connection)
        {
            Connection = connection;
            Connection.Open();
            idTransaction = Guid.NewGuid();
        }

        public void BeginTransaction()
        {
            if (Transaction == null)
            {
                Transaction = Connection.BeginTransaction();
            }


        
        }

        public void Commit()
        {
            if (Transaction != null && Transaction.Connection != null)
            {
                Transaction.Commit();
            }
        }

        public void Rollback()
        {
            if (Transaction != null && Transaction.Connection != null)
            {
                Transaction.Rollback();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing && Transaction != null)
            {
                
                Transaction.Dispose();
                Connection.Close();
                Connection.Dispose();
            }
            disposed = true;
        }
    }
}
