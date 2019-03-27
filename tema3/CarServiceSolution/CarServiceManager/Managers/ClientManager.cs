using System.Collections.Generic;
using System.Linq;
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

        public List<ClientDTO> GetClients()
        {
            var clients = _repo.GetAll().Select(q => this.ToClientDto(q)).ToList();
            return clients;
        }

        private Client ToClientEntity(ClientDTO dto)
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

        private ClientDTO ToClientDto(Client dto)
        {
            return new ClientDTO()
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
