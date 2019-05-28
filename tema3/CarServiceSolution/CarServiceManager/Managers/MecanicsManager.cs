using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CarService;
using CarService.Repos;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class MecanicsManager
    {
        private MecanicRepo _repo;

        public MecanicsManager()
        {
            _repo = new MecanicRepo();
        }

        internal static Mecanic DtoToEntity(MecanicDTO dto)
        {
            var m = new Mecanic()
            {
                Nume = dto.Nume,
                Prenume = dto.Prenume,
                MecanicId = dto.MecanicId
            };

            return m;
        }

        public List<MecanicDTO> GetList()
        {
            var ops = _repo.GetAll().Select(q => new MecanicDTO(q)).ToList();
            return ops;
        }

        public void Save(MecanicDTO dto)
        {
            _repo.Add(new Mecanic()
            {
                Nume = dto.Nume,
                Prenume = dto.Prenume
            });
        }
    }
}
