using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class SasiuManager
    {
        internal static Sasiu DtoToEntity(SasiuDTO dto)
        {
            return new Sasiu()
            {
                CodSasiu = dto.CodSasiu,
                Denumire = dto.Denumire,
                SasiuId = dto.SasiuId
            };
        }
    }
}
