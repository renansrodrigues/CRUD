using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Visums.Domain.Interface
{
    public interface IUnitOfWork : IDbTransaction
    {
        IDbTransaction Transaction { get; }
        void BeginTransaction();
        new void  Commit();
        new void Rollback();
    }
}
