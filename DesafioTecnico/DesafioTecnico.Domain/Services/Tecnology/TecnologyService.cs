using System;
using System.Collections.Generic;
using DesafioTecnico.Domain.Interfaces.Repository.Tecnology;
using DesafioTecnico.Domain.Interfaces.Services.Tecnology;

namespace DesafioTecnico.Domain.Services.Tecnology
{
    public class TecnologyService : ITecnologyService
    {
        private readonly ITecnologyRepository _tecnologyRepository;

        public TecnologyService(ITecnologyRepository tecnologyRepository)
        {
            _tecnologyRepository = tecnologyRepository;
        }

        public List<Models.Tecnology> GetTecnologies()
        {
            return _tecnologyRepository.GetTecnologies();
        }

        public Models.Tecnology GetTecnology(Guid id)
        {
            return _tecnologyRepository.GetTecnology(id);
        }

        public Guid AddTecnology(Models.Tecnology tecnology)
        {
            return _tecnologyRepository.AddTecnology(tecnology);
        }

        public void EditTecnology(Models.Tecnology tecnology, Guid id)
        {
            _tecnologyRepository.EditTecnology(tecnology, id);
        }

        public bool DeleteTecnology(Guid id)
        {
            return _tecnologyRepository.DeleteTecnology(id);
        }
    }
}