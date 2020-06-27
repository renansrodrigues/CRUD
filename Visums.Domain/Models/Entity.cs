using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Visums.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
    }
}
