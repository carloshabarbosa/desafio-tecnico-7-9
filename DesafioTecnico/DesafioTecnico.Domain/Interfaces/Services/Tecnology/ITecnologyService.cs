using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Services.Tecnology
{
    public interface ITecnologyService
    {
        List<Models.Tecnology> GetTecnologies();
        Models.Tecnology GetTecnology(Guid id);
        Guid AddTecnology(Models.Tecnology tecnology);
        void EditTecnology(Models.Tecnology tecnology, Guid id);
        bool DeleteTecnology(Guid id);
    }
}