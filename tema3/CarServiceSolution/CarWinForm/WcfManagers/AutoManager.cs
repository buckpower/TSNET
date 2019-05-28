using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CarServiceManager.Entities;
using CarServiceManager.Managers;
using CarWinForm.ServiceReference1;

namespace CarServiceManager
{
    public class AutoManager
    {
        private InterfaceControllClient _repo;

        public AutoManager()
        {
            _repo = new InterfaceControllClient();
        }

        public List<AutoDTO> GetAutosByClientId(int clientId)
        {
            var list = _repo.GetAutoByClient(clientId).ToList();

            //return list.Select(a => new AutoDTO(new CarService.Auto()){
            //    Client = a.Client,
            //    Sasiu = a.Sasiu,
            //    SerieSasiu = a.SerieSasiu,
            //    NumarAuto = a.NumarAuto,
            //    ClientId = a.ClientId,
            //    AutoId = a.AutoId
            //    })).ToList();}
            return list.Select(a => new AutoDTO(a)).ToList();
        }

        public void AddAuto(AutoDTO dto)
        {
            _repo.AddAuto(new Auto()
            {
                NumarAuto = dto.NumarAuto,
                SerieSasiu = dto.SerieSasiu,
                Sasiu = new Sasiu()
                {
                    CodSasiu = dto.Sasiu.CodSasiu,
                    Denumire = dto.Sasiu.Denumire
                },
                Client = new Client()
                {
                    Id = dto.ClientId
                }
            });
        }

        public List<AutoDTO> GetAutos()
        {
            var a = _repo.GetAllAuto(); //.Select(x => new AutoDTO(x)).ToList();
            return a.Select(x => new AutoDTO(x)).ToList();
        }

        public AutoDTO GetAuto(int autoId)
        {
            var a = _repo.GetAuto(autoId);
            return new AutoDTO(a);
        }

        internal static Auto DtoToEntity(AutoDTO dto)
        {
            return new Auto()
            {
                Client = ClientManager.ToClientClientEntity(dto.Client),
                Sasiu = SasiuManager.DtoToClientEntity(dto.Sasiu),
                SerieSasiu = dto.SerieSasiu,
                NumarAuto = dto.NumarAuto,
                ClientId = dto.ClientId,
                AutoId = dto.AutoId
            };
        }
        internal static CarWinForm.ServiceReference1.Auto DtoToClientEntity(AutoDTO dto)
        {
            return new CarWinForm.ServiceReference1.Auto()
            {
                Client = ClientManager.ToClientClientEntity(dto.Client),
                Sasiu = SasiuManager.DtoToClientEntity(dto.Sasiu),
                SerieSasiu = dto.SerieSasiu,
                NumarAuto = dto.NumarAuto,
                ClientId = dto.ClientId,
                AutoId = dto.AutoId
            };
        }
    }
}