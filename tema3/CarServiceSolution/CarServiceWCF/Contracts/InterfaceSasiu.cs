using CarService;
using System.Collections.Generic;
using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceSasiu
    {
        [OperationContract]
        void AddSasiu(Sasiu entity);

        [OperationContract]
        void DeleteSasiu(Sasiu entity);

        [OperationContract]
        Sasiu GetSasiu(int id);

        [OperationContract]
        ICollection<Sasiu> GetAllSasiu();

        [OperationContract]
        void InsertSasiu(Sasiu entity);

        [OperationContract]
        void UpdateSasiu(Sasiu entity);
    }
}