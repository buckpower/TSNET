using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class MaterialsManager
    {
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
    }
}
