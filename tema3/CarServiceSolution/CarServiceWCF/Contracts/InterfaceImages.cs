using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceImagine
    {
        [OperationContract]
        void Add(Imagine entity);

        [OperationContract]
        void Delete(Imagine entity);

        [OperationContract]
        Imagine Get(int id);

        [OperationContract]
        ICollection<Imagine> GetAll();

        [OperationContract]
        void Insert(Imagine entity);

        [OperationContract]
        void Update(Imagine entity);
    }
}