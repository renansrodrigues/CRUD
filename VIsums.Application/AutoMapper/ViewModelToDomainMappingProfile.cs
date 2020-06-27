using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Visums.Application.ViewModel;
using Visums.Domain.Commands.Handlers;

namespace Visums.Application.AutoMapper
{
    public  class ViewModelToDomainMappingProfile :Profile
    {

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<UsuarioViewModel, CriarUsuarioCommand>()
                .ConstructUsing(u => new CriarUsuarioCommand(u.Nome, u.Email, u.Senha));
        }
    
    }
}
