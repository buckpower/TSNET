using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

namespace CarServiceManager.Managers
{
    public class OrderManager
    {
        //private ComandaRepo _repo;
        private CarWinForm.ServiceReference1.InterfaceControllClient _repo;
        public OrderManager()
        {
            _repo = new InterfaceControllClient();
        }
        public List<ComandaDto> GetOrderByAuto(int autoID)
        {
            //var lst = 
            var dataList = _repo.GetAllComanda().ToList().Where(c => c.Auto.AutoId == autoID);
            //var dtoList = dataList.Select(x => new ComandaDto(x));
            //return dtoList.ToList();
            var dtoList = new List<ComandaDto>();
            foreach (var comanda in dataList)
            {
                dtoList.Add(new ComandaDto(comanda));
            }

            return dtoList;
        }

        public void AddNewOrder(AutoDTO auto, StareComandaDto sc, string description, DateTime appDateTime,
            int dashKm, IList<ImagineDTO> imgs)
        {
            var dto = new ComandaDto()
            {
                Client = auto.Client,
                Auto = auto,
                StareComanda = sc,
                Descriere = description,
                DataProgramare = appDateTime,
                DAtaSystem = DateTime.Now,
                KmBord = dashKm
            };

            dto.DetaliuComanda = new DetaliuComandaDTO()
            {
            };

            if (imgs != null && imgs.Count > 0)
            {
                dto.DetaliuComanda.Imagines = imgs;
            }

            var entity = DtoToEntity(dto);

            _repo.AddComanda(entity);
        }

        internal static Comanda DtoToEntity(ComandaDto dto)
        {
            var c =  new Comanda()
            {
                ComandaID = dto.ComandaID,
                DAtaSystem = dto.DAtaSystem,
                DataFinalizare = dto.DataFinalizare,
                DataProgramare = dto.DataProgramare,
                Descriere = dto.Descriere,
                KmBord = dto.KmBord,
                ValoarePiese = dto.ValoarePiese,
            };

            StareComanda sc;
            Enum.TryParse<StareComanda>(dto.StareComanda.ToString(), out sc);
            c.StareComanda = sc;

            if (dto.Client != null)
            {
                c.Client = ClientManager.ToClientEntity(dto.Client);
            }

            if (dto.Auto != null)
            {
                c.Auto = AutoManager.DtoToClientEntity(dto.Auto);
            }

            if (dto.DetaliuComanda != null)
            {
                c.DetaliuComanda = DetaliuComandaManager.DtoToEntity(dto.DetaliuComanda);
            }

            if (dto.Operaties != null && dto.Operaties.Count > 0)
            {
                c.Operaties = dto.Operaties.Select(dc => OperatieManager.DtoToEntity(dc)).ToArray();
            }

            return c;
        }
    }
}
