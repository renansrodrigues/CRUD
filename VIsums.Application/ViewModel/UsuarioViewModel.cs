using System;
using System.Collections.Generic;
using System.Text;

namespace Visums.Application.ViewModel
{
    public class UsuarioViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get;  set; }
        public string Email { get;  set; }
        public string Senha { get;  set; }
    }
}
