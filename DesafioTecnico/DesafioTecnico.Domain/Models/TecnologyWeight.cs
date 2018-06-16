using DesafioTecnico.Domain.Core.Models;

namespace DesafioTecnico.Domain.Models
{
    public class TecnologyWeight :Entity
    {
        public decimal Weight { get; set; }
        public Tecnology Tecnology { get; set; }
        public JobOpportunity JobOpportunity { get; set; }    
        
    }
}