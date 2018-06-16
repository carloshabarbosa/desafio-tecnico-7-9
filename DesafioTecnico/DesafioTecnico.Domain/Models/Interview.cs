using System.Reflection.Metadata;
using System.Security.Cryptography;
using DesafioTecnico.Domain.Core.Models;

namespace DesafioTecnico.Domain.Models
{
    public class Interview : Entity
    {
        public string Notes { get; set; }
        public JobOpportunity JobOpportunity { get; set; }
        public Candidate Candidate { get; set; }
        
    }
}