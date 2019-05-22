using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceMaterial
    {
        [OperationContract]
        void AddMaterial(Material entity);

        [OperationContract]
        void DeleteMaterial(Material entity);

        [OperationContract]
        Material GetMaterial(int id);

        [OperationContract]
        ICollection<Material> GetAllMaterial();

        [OperationContract]
        void InsertMaterial(Material entity);

        [OperationContract]
        void UpdateMaterial(Material entity);
    }
}