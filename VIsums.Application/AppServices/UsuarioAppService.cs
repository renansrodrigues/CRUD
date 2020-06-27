using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Visums.Application.Interfaces.Usuario;
using Visums.Application.ViewModel;
using Visums.Domain.Commands.Handlers;
using Visums.Domain.Core.Handler;

namespace Visums.Application.AppServices
{
    public  class UsuarioAppService: IUsuarioAppService
    {
        private readonly IMediatorHadler _imediatorHadler;
        private readonly IMapper _mapper;
        public UsuarioAppService(IMediatorHadler mediatorHadler, IMapper mapper)
        {
            _imediatorHadler = mediatorHadler;
            _mapper = mapper;
        }

        public void Criar(UsuarioViewModel usuarioView)
        {
            var criarusuariocommand = _mapper.Map<CriarUsuarioCommand>(usuarioView);
            _imediatorHadler.SendCommand(criarusuariocommand);
        }
    
    }
}
