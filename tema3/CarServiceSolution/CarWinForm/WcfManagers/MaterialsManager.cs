using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

namespace CarServiceManager.Managers
{
    public class MaterialsManager
    {
        private InterfaceControllClient _repo;

        public MaterialsManager()
        {
            _repo = new InterfaceControllClient();
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
            var ops = _repo.GetAllMaterial().Select(q => new MaterialDTO(q)).ToList();
            return ops;
        }

        public void Save(MaterialDTO dto)
        {
            _repo.AddMaterial(new Material()
            {
                Denumire = dto.Denumire,
                DataAprovizionare = dto.DataAprovizionare,
                Cantitate = dto.Cantitate,
                Pret = dto.Pret
            });
        }
    }
}
