
using CarWinForm.ServiceReference1;

namespace CarServiceManager.Entities
{
    public class AutoDTO
    {
        public int AutoId { get; set; }
        public string NumarAuto { get; set; }
        public string SerieSasiu { get; set; }

        public virtual SasiuDTO Sasiu { get; set; }
        //public virtual ClientDTO Client { get; set; }
        public int ClientId { get; set; }
        public ClientDTO Client { get; set; }

        public AutoDTO()
        {

        }
        public AutoDTO(Auto auto)
        {
            //Client = new ClientDTO(auto.Client);
            ClientId = auto.Client.Id;
            AutoId = auto.AutoId;
            NumarAuto = auto.NumarAuto;
            if (auto.Sasiu != null)
                Sasiu = new SasiuDTO(auto.Sasiu);

            SerieSasiu = auto.SerieSasiu;

            if(auto.Client != null)
                Client = new ClientDTO(auto.Client);
        }
    }
}
