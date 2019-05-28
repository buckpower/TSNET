using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

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
