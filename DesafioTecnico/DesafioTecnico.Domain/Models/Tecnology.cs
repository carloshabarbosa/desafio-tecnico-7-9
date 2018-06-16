using System;
using DesafioTecnico.Domain.Core.Models;

namespace DesafioTecnico.Domain.Models
{
    public class Tecnology : Entity
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}