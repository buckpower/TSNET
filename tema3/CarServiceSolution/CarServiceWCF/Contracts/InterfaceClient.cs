using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    interface InterfaceClient
    {
        [OperationContract]
        void Add(Client entity);

        [OperationContract]
          void Delete(Client entity);

          [OperationContract]
          Client Get(int id);

          [OperationContract]
          ICollection<Client> GetAll();

          [OperationContract]
          void Insert(Client entity);

          [OperationContract]
          void Update(Client entity);
    }
}