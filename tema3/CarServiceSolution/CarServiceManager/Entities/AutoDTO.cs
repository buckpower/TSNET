using CarService;

namespace CarServiceManager.Entities
{
    public class AutoDTO
    {
        public int AutoId { get; set; }
        public string NumarAuto { get; set; }
        public string SerieSasiu { get; set; }

        public virtual SasiuDTO Sasiu { get; set; }
        public virtual ClientDTO Client { get; set; }

        public AutoDTO() { }
        internal AutoDTO(Auto auto)
        {
            Client = new ClientDTO(auto.Client);
            AutoId = auto.AutoId;
            NumarAuto = auto.NumarAuto;
            Sasiu = new SasiuDTO(auto.Sasiu);
            SerieSasiu = auto.SerieSasiu;
        }

    }
}
