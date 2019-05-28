using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

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
        internal static CarWinForm.ServiceReference1.Sasiu DtoToClientEntity(SasiuDTO dto)
        {
            return new CarWinForm.ServiceReference1.Sasiu()
            {
                CodSasiu = dto.CodSasiu,
                Denumire = dto.Denumire,
                SasiuId = dto.SasiuId
            };
        }
    }
}
