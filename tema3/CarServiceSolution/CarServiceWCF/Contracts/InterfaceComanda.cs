using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceComanda
    {
        [OperationContract]
        void AddComanda(Comanda entity);

        [OperationContract]
        void DeleteComanda(Comanda entity);

        [OperationContract]
        Comanda GetComanda(int id);

        [OperationContract]
        ICollection<Comanda> GetAllComanda();

        [OperationContract]
        void InsertComanda(Comanda entity);

        [OperationContract]
        void UpdateComanda(Comanda entity);
    }
}