using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceMecanic
    {
        [OperationContract]
        void Add(Mecanic entity);

        [OperationContract]
        void Delete(Mecanic entity);

        [OperationContract]
        Mecanic Get(int id);

        [OperationContract]
        ICollection<Mecanic> GetAll();

        [OperationContract]
        void Insert(Mecanic entity);

        [OperationContract]
        void Update(Mecanic entity);
    }
}