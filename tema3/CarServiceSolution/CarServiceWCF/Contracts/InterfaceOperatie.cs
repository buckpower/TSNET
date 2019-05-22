using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceOperatie
    {
        [OperationContract]
        void AddOperatie(Operatie entity);

        [OperationContract]
        void DeleteOperatie(Operatie entity);

        [OperationContract]
        Operatie GetOperatie(int id);

        [OperationContract]
        ICollection<Operatie> GetAllOperatie();

        [OperationContract]
        void InsertOperatie(Operatie entity);

        [OperationContract]
        void UpdateOperatie(Operatie entity);
    }
}