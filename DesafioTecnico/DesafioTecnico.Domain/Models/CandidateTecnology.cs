using System.Collections.Generic;
using DesafioTecnico.Domain.Core.Models;

namespace DesafioTecnico.Domain.Models
{
    public class CandidateTecnology : Entity
    {
        public Candidate Candidate { get; set; }

        public Tecnology Tecnology { get; set; }
    }
}