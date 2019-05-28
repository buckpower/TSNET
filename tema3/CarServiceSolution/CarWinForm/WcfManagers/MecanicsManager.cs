using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

namespace CarServiceManager.Managers
{
    public class MecanicsManager
    {
        private InterfaceControllClient _repo;

        public MecanicsManager()
        {
            _repo = new InterfaceControllClient();
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
            var ops = _repo.GetAllMecanic().Select(q => new MecanicDTO(q)).ToList();
            return ops;
        }

        public void Save(MecanicDTO dto)
        {
            _repo.AddMecanic(new Mecanic()
            {
                Nume = dto.Nume,
                Prenume = dto.Prenume
            });
        }
    }
}
