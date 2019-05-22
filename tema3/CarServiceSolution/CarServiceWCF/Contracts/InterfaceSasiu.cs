using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceSasiu
    {
        [OperationContract]
        void Add(Sasiu entity);

        [OperationContract]
        void Delete(Sasiu entity);

        [OperationContract]
        Sasiu Get(int id);

        [OperationContract]
        ICollection<Sasiu> GetAll();

        [OperationContract]
        void Insert(Sasiu entity);

        [OperationContract]
        void Update(Sasiu entity);
    }
}