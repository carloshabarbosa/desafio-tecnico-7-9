using System.Collections.Generic;
using DesafioTecnico.Domain.Core.Models;

namespace DesafioTecnico.Domain.Models
{
    public class CompanyTecnology : Entity
    {
        public Company Company { get; set; }

        public Tecnology Tecnology { get; set; }
    }
}