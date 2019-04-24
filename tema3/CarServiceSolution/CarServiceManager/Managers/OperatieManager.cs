using CarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class OperatieManager
    {
        internal static Operatie DtoToEntity(OperatieDTO dto)
        {
            var o = new Operatie()
            {
                Denumire = dto.Denumire,
                OperatieId = dto.OperatieId,
                TimpExecutie = dto.TimpExecutie
            };

            return o;
        }
    }
}
