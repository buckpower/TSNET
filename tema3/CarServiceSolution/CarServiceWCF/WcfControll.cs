using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;
using CarService.Repos;
using CarServiceManager;
using CarServiceManager.Managers;

namespace CarServiceWCF.Contracts
{
    public class WcfControll : InterfaceControll
    { 
        private AutoRepo _autoRepo;
        private ClientRepo _clientRepo;
        private ComandaRepo _comandaRepo;
        private DetaliuComandaRepo _detaliuComandaRepo;
        private ImagineRepo _imagesRepo;
        private MaterialRepo _materialRepo;
        private MecanicRepo _mecanicRepo;
        private OperatieRepo _operatieRepo;
        private SasiuRepo _sasiuRepo;

        public void AddAuto(Auto entity)
        {
            _autoRepo.Add(entity);
        }

        public void AddClient(Client entity)
        {
            _clientRepo.Add(entity);
        }

        public void AddComanda(Comanda entity)
        {
            _comandaRepo.Add(entity);
        }

        public void AddDetaliuComanda(DetaliuComanda entity)
        {
            _detaliuComandaRepo.Add(entity);
        }

        public void AddImagine(Imagine entity)
        {
            _imagesRepo.Add(entity);
        }

        public void AddMaterial(Material entity)
        {
            _materialRepo.Add(entity);
        }

        public void AddMecanic(Mecanic entity)
        {
            _mecanicRepo.Add(entity);
        }

        public void AddOperatie(Operatie entity)
        {
            _operatieRepo.Add(entity);
        }

        public void AddSasiu(Sasiu entity)
        {
            _sasiuRepo.Add(entity);
        }

        public void DeleteAuto(Auto entity)
        {
            _autoRepo.Delete(entity);
        }

        public void DeleteClient(Client entity)
        {
            _clientRepo.Delete(entity);
        }

        public void DeleteComanda(Comanda entity)
        {
            _comandaRepo.Delete(entity);
        }

        public void DeleteDetaliuComanda(DetaliuComanda entity)
        {
            _detaliuComandaRepo.Delete(entity);
        }

        public void DeleteImagine(Imagine entity)
        {
            _imagesRepo.Delete(entity);
        }

        public void DeleteMaterial(Material entity)
        {
            _materialRepo.Delete(entity);
        }

        public void DeleteMecanic(Mecanic entity)
        {
            _mecanicRepo.Delete(entity);
        }

        public void DeleteOperatie(Operatie entity)
        {
            _operatieRepo.Delete(entity);
        }

        public void DeleteSasiu(Sasiu entity)
        {
            _sasiuRepo.Delete(entity);
        }

        public ICollection<Auto> GetAllAuto()
        {
            return _autoRepo.GetAll();
        }

        public ICollection<Client> GetAllClient()
        {
            return _clientRepo.GetAll();
        }

        public ICollection<Comanda> GetAllComanda()
        {
            return _comandaRepo.GetAll();
        }

        public ICollection<DetaliuComanda> GetAllDetaliuComanda()
        {
            return _detaliuComandaRepo.GetAll();
        }

        public ICollection<Imagine> GetAllImagine()
        {
            return _imagesRepo.GetAll();
        }

        public ICollection<Material> GetAllMaterial()
        {
            return _materialRepo.GetAll();
        }

        public ICollection<Mecanic> GetAllMecanic()
        {
            return _mecanicRepo.GetAll();
        }

        public ICollection<Operatie> GetAllOperatie()
        {
            return _operatieRepo.GetAll();
        }

        public ICollection<Sasiu> GetAllSasiu()
        {
            return _sasiuRepo.GetAll();
        }

        public Auto GetAuto(int id)
        {
            return _autoRepo.Get(id);
        }

        public ICollection<Auto> GetAutoByClient(int clientId)
        {
            return _autoRepo.GetByClient(clientId);
        }

        public Client GetClient(int id)
        {
            return _clientRepo.Get(id);
        }

        public Comanda GetComanda(int id)
        {
            return _comandaRepo.Get(id);
        }

        public DetaliuComanda GetDetaliuComanda(int id)
        {
            return _detaliuComandaRepo.Get(id);
        }

        public Imagine GetImagine(int id)
        {
            return _imagesRepo.Get(id);
        }

        public Material GetMaterial(int id)
        {
            return _materialRepo.Get(id);
        }

        public Mecanic GetMecanic(int id)
        {
            return _mecanicRepo.Get(id);
        }

        public Operatie GetOperatie(int id)
        {
            return _operatieRepo.Get(id);
        }

        public Sasiu GetSasiu(int id)
        {
            return _sasiuRepo.Get(id);
        }

        public void InsertAuto(Auto entity)
        {
            _autoRepo.Insert(entity);
        }

        public void InsertClient(Client entity)
        {
            _clientRepo.Insert(entity);
        }

        public void InsertComanda(Comanda entity)
        {
            _comandaRepo.Insert(entity);
        }

        public void InsertDetaliuComanda(DetaliuComanda entity)
        {
            _detaliuComandaRepo.Insert(entity);
        }

        public void InsertImagine(Imagine entity)
        {
            _imagesRepo.Insert(entity);
        }

        public void InsertMaterial(Material entity)
        {
            _materialRepo.Insert(entity);
        }

        public void InsertMecanic(Mecanic entity)
        {
            _mecanicRepo.Insert(entity);
        }

        public void InsertOperatie(Operatie entity)
        {
            _operatieRepo.Insert(entity);
        }

        public void InsertSasiu(Sasiu entity)
        {
            _sasiuRepo.Insert(entity);
        }

        public void UpdateAuto(Auto entity)
        {
            _autoRepo.Update(entity);
        }

        public void UpdateClient(Client entity)
        {
            _clientRepo.Update(entity);
        }

        public void UpdateComanda(Comanda entity)
        {
            _comandaRepo.Update(entity);
        }

        public void UpdateDetaliuComanda(DetaliuComanda entity)
        {
            _detaliuComandaRepo.Update(entity);
        }

        public void UpdateImagine(Imagine entity)
        {
            _imagesRepo.Update(entity);
        }

        public void UpdateMaterial(Material entity)
        {
            _materialRepo.Update(entity);
        }

        public void UpdateMecanic(Mecanic entity)
        {
            _mecanicRepo.Update(entity);
        }

        public void UpdateOperatie(Operatie entity)
        {
            _operatieRepo.Update(entity);
        }

        public void UpdateSasiu(Sasiu entity)
        {
            _sasiuRepo.Update(entity);
        }
    }
}
