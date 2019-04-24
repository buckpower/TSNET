using CarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManager.Entities
{
    public class DetaliuComandaDTO
    {
        public DetaliuComandaDTO()
        {
        }

        internal DetaliuComandaDTO(DetaliuComanda detaliuComanda)
        {
            Id = detaliuComanda.Id;
            if (detaliuComanda.Comanda != null)
                Comanda = new ComandaDto(detaliuComanda.Comanda);

            if (detaliuComanda.Imagines != null && detaliuComanda.Imagines.Count > 0)
                Imagines = detaliuComanda.Imagines.Select(i => new ImagineDTO(i)).ToList();

            if (detaliuComanda.Materials != null && detaliuComanda.Materials.Count > 0)
                Materials = detaliuComanda.Materials.Select(i => new MaterialDTO(i)).ToList();

            if (detaliuComanda.Mecanics != null && detaliuComanda.Mecanics.Count > 0)
                Mecanics = detaliuComanda.Mecanics.Select(i => new MecanicDTO(i)).ToList();
        }

        public int Id { get; set; }

        public virtual ICollection<MecanicDTO> Mecanics { get; set; }
        public virtual ICollection<MaterialDTO> Materials { get; set; }
        public virtual ICollection<ImagineDTO> Imagines { get; set; }
        public virtual ComandaDto Comanda { get; set; }
    }
}
