using CarService;
using CarServiceManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManager.Managers
{
    public class ImagesManager
    {
        internal static Imagine DtoToEntity(ImagineDTO dto)
        {
            var img = new Imagine()
            {
                Data = dto.Data,
                Descriere = dto.Descriere,
                Foto = dto.Foto,
                ImagineId = dto.ImagineId,
                Titlu = dto.Titlu
            };
            if (dto.DetaliuComanda != null)
            {
                img.DetaliuComanda = DetaliuComandaManager.DtoToEntity(dto.DetaliuComanda);
            }

            return img;
        }
    }
}
