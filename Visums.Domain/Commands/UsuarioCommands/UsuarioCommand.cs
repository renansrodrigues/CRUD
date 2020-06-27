using System;
using System.Collections.Generic;
using System.Text;
using Visums.Domain.Core.Commands;

namespace Visums.Domain.Commands.UsuarioCommands
{
    public abstract class UsuarioCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Nome { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
    }
}
