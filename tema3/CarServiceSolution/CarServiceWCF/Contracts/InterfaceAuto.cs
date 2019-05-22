using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceAuto
    {
        [OperationContract]
         void Add(Auto entity);

        [OperationContract]
         void Delete(Auto entity);

        [OperationContract]
         Auto Get(int id);

        [OperationContract]
         ICollection<Auto> GetByClient(int clientId);

        [OperationContract]
         ICollection<Auto> GetAll();

        [OperationContract]
         void Insert(Auto entity);

        [OperationContract]
         void Update(Auto entity);
    }
}