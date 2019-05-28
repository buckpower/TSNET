using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using CarService;
using CarService.Repos;
using CarServiceManager.Entities;

namespace CarServiceManager.Managers
{
    public class ClientManager
    {
        private ClientRepo _repo;

        public ClientManager()
        {
            _repo = new ClientRepo();
        }

        public void SaveClient(ClientDTO dto)
        {
            var entity = ToClientEntity(dto);
            _repo.Add(entity);
        }

        public List<ClientDTO> GetList()
        {
            var clients = _repo.GetAll().Select(q => new ClientDTO(q)).ToList();
            return clients;
        }

        public ClientDTO GetClientById(int id)
        {
            var clients = new ClientDTO(_repo.Get(id));
            return clients;
        }

        internal static Client ToClientEntity(ClientDTO dto)
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
    }
}
