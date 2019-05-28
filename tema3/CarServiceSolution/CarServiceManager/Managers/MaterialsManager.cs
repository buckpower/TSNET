using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;
using CarService.Repos;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class MaterialsManager
    {
        private MaterialRepo _repo;

        public MaterialsManager()
        {
            _repo = new MaterialRepo();
        }
        internal static Material DtoToEntity(MaterialDTO dto)
        {
            var m = new Material()
            {
                Denumire = dto.Denumire,
                Cantitate = dto.Cantitate,
                DataAprovizionare = dto.DataAprovizionare,
                MaterialId = dto.MaterialId,
                Pret = dto.Pret
            };

            return m;
        }

        public List<MaterialDTO> GetList()
        {
            var ops = _repo.GetAll().Select(q => new MaterialDTO(q)).ToList();
            return ops;
        }

        public void Save(MaterialDTO dto)
        {
            _repo.Add(new Material()
            {
                Denumire = dto.Denumire,
                DataAprovizionare = dto.DataAprovizionare,
                Cantitate = dto.Cantitate,
                Pret = dto.Pret
            });
        }
    }
}
