using System;
using System.Collections.Generic;

namespace DesafioTecnico.Application.Interfaces.Tecnology
{
    public interface ITecnologyApplication
    {
        List<Domain.Models.Tecnology> GetTecnologies();
        Domain.Models.Tecnology GetTecnology(Guid id);
        Guid AddTecnology(Domain.Models.Tecnology tecnology);
        void EditTecnology(Domain.Models.Tecnology tecnology, Guid id);
        bool DeleteTecnology(Guid id);
    }
}