using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceMecanic
    {
        [OperationContract]
        void AddMecanic(Mecanic entity);

        [OperationContract]
        void DeleteMecanic(Mecanic entity);

        [OperationContract]
        Mecanic GetMecanic(int id);

        [OperationContract]
        ICollection<Mecanic> GetAllMecanic();

        [OperationContract]
        void InsertMecanic(Mecanic entity);

        [OperationContract]
        void UpdateMecanic(Mecanic entity);
    }
}