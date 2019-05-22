using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceOperatie
    {
        [OperationContract]
        void Add(Operatie entity);

        [OperationContract]
        void Delete(Operatie entity);

        [OperationContract]
        Operatie Get(int id);

        [OperationContract]
        ICollection<Operatie> GetAll();

        [OperationContract]
        void Insert(Operatie entity);

        [OperationContract]
        void Update(Operatie entity);
    }
}