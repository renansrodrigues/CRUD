using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Visums.Domain.Interface;
using Visums.Domain.Models;
using Visums.Domain.Repository;

namespace Visums.Infra.Data.Repository
{
    public  class UsuarioRepository:BaseRepository,IUsuarioRepository
    {
  
        public UsuarioRepository(IUnitOfWork unitOfWork) :base(unitOfWork)
        {

        }
    

        public bool Adicionar(Usuario usuario)
        {
            var response =  _unitOfWork.Connection.Insert(usuario);

            return response > 0;
        }

    }
}
