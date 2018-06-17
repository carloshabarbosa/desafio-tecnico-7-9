using System;
using System.Collections.Generic;
using System.Linq;
using DesafioTecnico.Domain.Interfaces.Repository.Tecnology;
using DesafioTecnico.Infraestructure.Data.Context;

namespace DesafioTecnico.Infraestructure.Data.Repository.Tecnology
{
    public class TecnologyRepository : Repository<Domain.Models.Tecnology>, ITecnologyRepository
    {
        public TecnologyRepository(DesafioTecnicoContext context) : base(context)
        {
        }

        public List<Domain.Models.Tecnology> GetTecnologies()
        {
            return GetAll().ToList();
        }

        public Domain.Models.Tecnology GetTecnology(Guid id)
        {
            return GetById(id);
        }

        public Guid AddTecnology(Domain.Models.Tecnology tecnology)
        {
            tecnology.CreatedAt = DateTime.Now;
            Add(tecnology);
            SaveChanges();
            return tecnology.Id;
        }

        public void EditTecnology(Domain.Models.Tecnology tecnology, Guid id)
        {
            var tecnologyBase = GetById(id);
            tecnologyBase.IsActive = tecnology.IsActive;
            tecnologyBase.Name = tecnology.Name;
            Update(tecnologyBase);
            SaveChanges();
        }

        public bool DeleteTecnology(Guid id)
        {
            try
            {
                Remove(id);
                SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}