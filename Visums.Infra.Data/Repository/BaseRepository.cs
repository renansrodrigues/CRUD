using System;
using Visums.Domain.Interface;

namespace Visums.Infra.Data.Repository
{
    public abstract class BaseRepository : IDisposable
    {
        protected readonly string _connectionString;
        protected readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Dispose()
        {
            if (_unitOfWork != null) _unitOfWork.Connection.Dispose();
        }


    }
}
