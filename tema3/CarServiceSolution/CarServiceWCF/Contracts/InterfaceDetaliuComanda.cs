using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceDetaliuComanda
    {
        [OperationContract]
        void Add(DetaliuComanda entity);

        [OperationContract]
        void Delete(DetaliuComanda entity);

        [OperationContract]
        DetaliuComanda Get(int id);

        [OperationContract]
        ICollection<DetaliuComanda> GetAll();

        [OperationContract]
        void Insert(DetaliuComanda entity);

        [OperationContract]
        void Update(DetaliuComanda entity);
    }
}