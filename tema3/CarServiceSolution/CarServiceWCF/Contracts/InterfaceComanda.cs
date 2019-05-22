using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceComanda
    {
        [OperationContract]
        void Add(Comanda entity);

        [OperationContract]
        void Delete(Comanda entity);

        [OperationContract]
        Comanda Get(int id);

        [OperationContract]
        ICollection<Comanda> GetAll();

        [OperationContract]
        void Insert(Comanda entity);

        [OperationContract]
        void Update(Comanda entity);
    }
}