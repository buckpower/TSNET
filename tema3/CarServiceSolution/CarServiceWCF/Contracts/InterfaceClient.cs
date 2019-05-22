using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceClient
    {
        [OperationContract]
        void AddClient(Client entity);

        [OperationContract]
          void DeleteClient(Client entity);

          [OperationContract]
          Client GetClient(int id);

          [OperationContract]
          ICollection<Client> GetAllClient();

          [OperationContract]
          void InsertClient(Client entity);

          [OperationContract]
          void UpdateClient(Client entity);
    }
}