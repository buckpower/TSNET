using System.ServiceModel;

namespace CarServiceWCF.Contracts
{
    [ServiceContract]
    public interface InterfaceControll: InterfaceAuto,InterfaceClient,InterfaceComanda,InterfaceDetaliuComanda,InterfaceImagine,InterfaceMaterial,InterfaceMecanic,InterfaceOperatie, InterfaceSasiu
    {
    }
}