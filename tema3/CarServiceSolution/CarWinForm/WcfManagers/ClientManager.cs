using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using CarServiceManager.Entities;
using CarWinForm.ServiceReference1;

namespace CarServiceManager.Managers
{
    public class ClientManager
    {
        private InterfaceControllClient _repo;

        public ClientManager()
        {
            _repo = new InterfaceControllClient();
        }

        public void SaveClient(ClientDTO dto)
        {
            var entity = ToClientEntity(dto);
            _repo.AddClient(entity);
        }

        public List<ClientDTO> GetList()
        {
            var clients = _repo.GetAllClient().Select(q => new ClientDTO(q)).ToList();
            return clients;
        }

        public ClientDTO GetClientById(int id)
        {
            var clients = new ClientDTO(_repo.GetClient(id));
            return clients;
        }

        internal static  Client ToClientEntity(ClientDTO dto)
        {
            return new Client()
            {
                Id = dto.Id,
                Nume = dto.Nume,
                Prenume = dto.Prenume,
                Adresa = dto.Adresa,
                Email = dto.Email,
                Localitate = dto.Localitate,
                Judet = dto.Judet,
                Telefon = dto.Telefon
            };
        }

        internal static CarWinForm.ServiceReference1.Client ToClientClientEntity(ClientDTO dto)
        {
            return new CarWinForm.ServiceReference1.Client()
            {
                Id = dto.Id,
                Nume = dto.Nume,
                Prenume = dto.Prenume,
                Adresa = dto.Adresa,
                Email = dto.Email,
                Localitate = dto.Localitate,
                Judet = dto.Judet,
                Telefon = dto.Telefon
            };
        }
    }
}
