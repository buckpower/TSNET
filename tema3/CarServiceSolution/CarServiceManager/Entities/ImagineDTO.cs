using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;

namespace CarServiceManager.Entities
{
    public class ImagineDTO
    {
        internal ImagineDTO(Imagine i)
        {
            ImagineId = i.ImagineId;
            Titlu = i.Titlu;
            Descriere = i.Descriere;
            Data = i.Data;
            Foto = i.Foto;

            if (i.DetaliuComanda != null)
                DetaliuComanda = new DetaliuComandaDTO(i.DetaliuComanda);
        }

        public int ImagineId { get; set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }
        public System.DateTime Data { get; set; }
        public byte[] Foto { get; set; }

        public virtual DetaliuComandaDTO DetaliuComanda { get; set; }
    }
}
