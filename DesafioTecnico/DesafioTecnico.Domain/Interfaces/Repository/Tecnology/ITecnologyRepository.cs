using System;
using System.Collections.Generic;

namespace DesafioTecnico.Domain.Interfaces.Repository.Tecnology
{
    public interface ITecnologyRepository
    {
        List<Models.Tecnology> GetTecnologies();
        Models.Tecnology GetTecnology(Guid id);
        Guid AddTecnology(Models.Tecnology tecnology);
        void EditTecnology(Models.Tecnology tecnology, Guid id);
        bool DeleteTecnology(Guid id);
    }
}