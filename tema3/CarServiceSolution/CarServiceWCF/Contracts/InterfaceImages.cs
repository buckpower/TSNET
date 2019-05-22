using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceImagine
    {
        [OperationContract]
        void AddImagine(Imagine entity);

        [OperationContract]
        void DeleteImagine(Imagine entity);

        [OperationContract]
        Imagine GetImagine(int id);

        [OperationContract]
        ICollection<Imagine> GetAllImagine();

        [OperationContract]
        void InsertImagine(Imagine entity);

        [OperationContract]
        void UpdateImagine(Imagine entity);
    }
}