using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class MecanicsManager
    {
        internal static Mecanic DtoToEntity(MecanicDTO dto)
        {
            var m = new Mecanic()
            {
                Nume = dto.Nume,
                Prenume = dto.Prenume,
                MecanicId = dto.MecanicId
            };

            return m;
        }
    }
}
