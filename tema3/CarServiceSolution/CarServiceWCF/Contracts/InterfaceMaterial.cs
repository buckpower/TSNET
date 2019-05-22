using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceMaterial
    {
        [OperationContract]
        void Add(Material entity);

        [OperationContract]
        void Delete(Material entity);

        [OperationContract]
        Material Get(int id);

        [OperationContract]
        ICollection<Material> GetAll();

        [OperationContract]
        void Insert(Material entity);

        [OperationContract]
        void Update(Material entity);
    }
}