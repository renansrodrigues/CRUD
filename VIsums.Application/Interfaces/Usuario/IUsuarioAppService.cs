using System;
using System.Collections.Generic;
using System.Text;
using Visums.Application.ViewModel;

namespace Visums.Application.Interfaces.Usuario
{
    public interface IUsuarioAppService
    {
        void Criar(UsuarioViewModel usuarioViewModel);
    }
}
