using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Visums.Domain.Commands.Handlers;
using Visums.Domain.Interface;
using Visums.Domain.Models;
using Visums.Domain.Repository;

namespace Visums.Domain.Commands.UsuarioCommands.UsuarioHandler
{
    public  class UsuarioCommandHandler : IRequestHandler<CriarUsuarioCommand,bool>
    {

        private readonly IUnitOfWork _uow;
        private readonly IUsuarioRepository _usuarioRepository;


        public UsuarioCommandHandler(IUnitOfWork uow , IUsuarioRepository usuarioRepository )
        {
            _uow = uow;
            _usuarioRepository = usuarioRepository;
        }


        public Task<bool> Handle(CriarUsuarioCommand command, CancellationToken cancellationToken)
        {

            var usuario = new Usuario(Guid.NewGuid(), command.Email, command.Nome, command.Senha);


            if(_usuarioRepository.Adicionar(usuario))
            {
                   
                //TODO : Send to Rabbit
            }

            return Task.FromResult(true);
        }

       
    }
}
