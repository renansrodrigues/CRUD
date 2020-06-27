using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Visums.Application.ViewModel;
using Visums.Domain.Models;

namespace Visums.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile :Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>();
        }
        
      
    }
}
