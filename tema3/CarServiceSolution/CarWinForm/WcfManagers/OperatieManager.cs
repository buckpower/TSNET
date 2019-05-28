using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

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
        private InterfaceControllClient _repo;

        public OperatieManager()
        {
            _repo = new InterfaceControllClient();
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
            var ops = _repo.GetAllOperatie().Select(q => new OperatieDTO(q)).ToList();
            return ops;
        }

        public void Save(OperatieDTO dto)
        {
            _repo.AddOperatie(new Operatie()
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
