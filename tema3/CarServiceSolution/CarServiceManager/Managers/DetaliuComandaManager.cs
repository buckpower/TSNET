using System.Linq;
using CarService;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class DetaliuComandaManager
    {
        internal static DetaliuComanda DtoToEntity(DetaliuComandaDTO dto)
        {
            var dc =  new DetaliuComanda()
            {
                Id =  dto.Id,
                
            };
            //Imagines = dto.Imagines.Select(i => ImagesManager)
            // DtoToEntity(ImagineDTO dto)
            if (dto.Imagines != null && dto.Imagines.Count > 0)
            {
                dc.Imagines = dto.Imagines.Select(i => ImagesManager.DtoToEntity(i)).ToList();
            }

            if (dto.Materials != null && dto.Materials.Count > 0)
            {
                dc.Materials = dto.Materials.Select(i => MaterialsManager.DtoToEntity(i)).ToList();
            }

            if (dto.Mecanics != null && dto.Mecanics.Count > 0)
            {
                dc.Mecanics = dto.Mecanics.Select(i => MecanicsManager.DtoToEntity(i)).ToList();
            }

            if (dto.Comanda != null )
            {
                dc.Comanda = OrderManager.DtoToEntity(dto.Comanda);
            }

            return dc;
        }
    }
}
