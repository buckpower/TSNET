using CarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService.Repos;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class OperatieManager
    {
        /*
         * private ClientRepo _repo;

        public ClientManager()
        {
            _repo = new ClientRepo();
        }
         */
        private OperatieRepo _repo;

        public OperatieManager()
        {
            _repo = new OperatieRepo();
        }

        internal static Operatie DtoToEntity(OperatieDTO dto)
        {
            var o = new Operatie()
            {
                Denumire = dto.Denumire,
                OperatieId = dto.OperatieId,
                TimpExecutie = dto.TimpExecutie
            };

            return o;
        }

        public List<OperatieDTO> GetList()
        {
            var ops = _repo.GetAll().Select(q => new OperatieDTO(q)).ToList();
            return ops;
        }

        public void Save(OperatieDTO dto)
        {
            _repo.Add(new Operatie()
            {
                Denumire = dto.Denumire,
                TimpExecutie = dto.TimpExecutie
            });
        }
        /*
* List<ClientDTO> GetClients()
{
   var clients = _repo.GetAll().Select(q => new ClientDTO(q)).ToList();
   return clients;
}
*/
    }
}
