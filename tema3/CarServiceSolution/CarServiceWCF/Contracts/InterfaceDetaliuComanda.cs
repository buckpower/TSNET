using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceDetaliuComanda
    {
        [OperationContract]
        void AddDetaliuComanda(DetaliuComanda entity);

        [OperationContract]
        void DeleteDetaliuComanda(DetaliuComanda entity);

        [OperationContract]
        DetaliuComanda GetDetaliuComanda(int id);

        [OperationContract]
        ICollection<DetaliuComanda> GetAllDetaliuComanda();

        [OperationContract]
        void InsertDetaliuComanda(DetaliuComanda entity);

        [OperationContract]
        void UpdateDetaliuComanda(DetaliuComanda entity);
    }
}