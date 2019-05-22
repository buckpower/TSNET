using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceAuto
    {
        [OperationContract]
         void AddAuto(Auto entity);

        [OperationContract]
         void DeleteAuto(Auto entity);

        [OperationContract]
         Auto GetAuto(int id);

        [OperationContract]
         ICollection<Auto> GetAutoByClient(int clientId);

        [OperationContract]
         ICollection<Auto> GetAllAuto();

        [OperationContract]
         void InsertAuto(Auto entity);

        [OperationContract]
         void UpdateAuto(Auto entity);
    }
}