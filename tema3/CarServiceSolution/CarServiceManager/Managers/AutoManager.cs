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
    }
}