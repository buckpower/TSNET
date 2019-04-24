using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CarService;
using CarService.Repos;
using CarServiceManager.Entities;
using CarServiceManager.Managers;

namespace CarServiceManager
{
    public class AutoManager
    {
        private AutoRepo _repo;

        public AutoManager()
        {
            _repo = new AutoRepo();
        }
        public List<AutoDTO> GetAutosByClientId(int clientId)
        {
            var list = _repo.GetByClient(clientId).ToList();

            return list.Select(a => new AutoDTO(a)).ToList();
        }

        public void AddAuto(AutoDTO dto)
        {
            _repo.Add(new Auto()
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
            var a = _repo.GetAll(); //.Select(x => new AutoDTO(x)).ToList();
            return a.Select(x => new AutoDTO(x)).ToList();
        }

        public AutoDTO GetAuto(int autoId)
        {
            var a = _repo.Get(autoId);
            return new AutoDTO(a);
        }

        internal static Auto DtoToEntity(AutoDTO dto)
        {
            return new Auto()
            {
                Client = ClientManager.ToClientEntity(dto.Client),
                Sasiu = SasiuManager.DtoToEntity(dto.Sasiu),
                SerieSasiu = dto.SerieSasiu,
                NumarAuto = dto.NumarAuto,
                ClientId = dto.ClientId,
                AutoId = dto.AutoId
            };
        }
    }
}