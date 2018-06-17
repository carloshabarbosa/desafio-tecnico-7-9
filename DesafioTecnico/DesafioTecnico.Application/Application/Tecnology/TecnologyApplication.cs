using System;
using System.Collections.Generic;
using DesafioTecnico.Application.Interfaces.Tecnology;
using DesafioTecnico.Domain.Interfaces.Services.Tecnology;

namespace DesafioTecnico.Application.Application.Tecnology 
{
    public class TecnologyApplication : ITecnologyApplication
    {
        private readonly ITecnologyService _tecnologyService;

        public TecnologyApplication(ITecnologyService tecnologyService)
        {
            _tecnologyService = tecnologyService;
        }

        public List<Domain.Models.Tecnology> GetTecnologies()
        {
            return _tecnologyService.GetTecnologies();
        }

        public Domain.Models.Tecnology GetTecnology(Guid id)
        {
            return _tecnologyService.GetTecnology(id);
        }

        public Guid AddTecnology(Domain.Models.Tecnology tecnology)
        {
            return _tecnologyService.AddTecnology(tecnology);
        }

        public void EditTecnology(Domain.Models.Tecnology tecnology, Guid id)
        {
            _tecnologyService.EditTecnology(tecnology, id);
        }

        public bool DeleteTecnology(Guid id)
        {
            return _tecnologyService.DeleteTecnology(id);
        }
    }
}