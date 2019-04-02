using CarService;

namespace CarServiceManager.Entities
{
    public class SasiuDTO
    {
        public int SasiuId { get; set; }
        public string CodSasiu { get; set; }
        public string Denumire { get; set; }

        public SasiuDTO()
        {
        }

        internal SasiuDTO(Sasiu sasiu)
        {
            this.SasiuId = sasiu.SasiuId;
            this.CodSasiu= sasiu.CodSasiu;
            this.Denumire = sasiu.Denumire;
        }
    }
}
