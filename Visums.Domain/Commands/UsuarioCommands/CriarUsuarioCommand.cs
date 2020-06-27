using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Visums.Domain.Commands.UsuarioCommands;
using Visums.Domain.Models;


namespace Visums.Domain.Commands.Handlers
{
    public class CriarUsuarioCommand :UsuarioCommand
    {

        public CriarUsuarioCommand(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        public override bool IsValid()
        {
            return true;
        }
    }
}
