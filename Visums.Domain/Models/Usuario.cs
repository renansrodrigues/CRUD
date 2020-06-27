using System;
using System.Collections.Generic;
using System.Text;

namespace Visums.Domain.Models
{
    public class Usuario: Entity
    {
        public Usuario(Guid id,string nome, string email, string senha)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public string  Nome { get; private set; }
        public string Email { get; private set; }
        public string  Senha { get; private set; }
    }
}
