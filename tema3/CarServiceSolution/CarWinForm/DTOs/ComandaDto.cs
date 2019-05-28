using CarWinForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManager.Entities
{
    public enum StareComandaDto : int
    {
        Asteptare = 0,
        Executata = 1,
        Refuz = 3
    }
    public class ComandaDto
    {
        public int ComandaID { get; set; }
        public StareComandaDto StareComanda { get; set; }
        public DateTime DAtaSystem { get; set; }
        public DateTime DataProgramare { get; set; }
        public DateTime? DataFinalizare { get; set; }
        public int KmBord { get; set; }
        public string Descriere { get; set; }
        public decimal ValoarePiese { get; set; }

        public virtual ClientDTO Client { get; set; }
        public virtual AutoDTO Auto { get; set; }
        public virtual ICollection<OperatieDTO> Operaties { get; set; }
        public virtual DetaliuComandaDTO DetaliuComanda { get; set; }

        public ComandaDto()
        {

        }
        public ComandaDto(Comanda comanda)
        {
            //Client = new ClientDTO(auto.Client);
            ComandaID = comanda.ComandaID;
            if (comanda.Client != null)
                Client = new ClientDTO(comanda.Client);

            StareComandaDto stare;
            Enum.TryParse<StareComandaDto>(comanda.StareComanda.ToString(), out stare);
            StareComanda = stare;
            DAtaSystem = comanda.DAtaSystem;
            DataProgramare = comanda.DataProgramare;
            DataFinalizare = comanda.DataFinalizare;
            KmBord = comanda.KmBord;
            Descriere = comanda.Descriere;
            ValoarePiese = comanda.ValoarePiese;

            if (comanda.Auto != null)
                Auto = new AutoDTO(comanda.Auto);

            if (comanda.Operaties != null && comanda.Operaties.ToList().Count > 0)
            {
                Operaties = comanda.Operaties.Select(o => new OperatieDTO(o)).ToList();
            }

            if (comanda.DetaliuComanda != null)
                DetaliuComanda = new DetaliuComandaDTO(comanda.DetaliuComanda);
        }
    }

}
