using System;
using System.Collections.Generic;
using System.Linq;
using CarService;
using CarService.Repos;
using CarServiceManager.Entities;

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
            var list = _repo.GetByClient(clientId).Select(a => new AutoDTO(a));

            return list.ToList();
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
            return _repo.GetAll().Select(x => new AutoDTO(x)).ToList();
        }
    }
}