using CarService;
namespace CarServiceManager.Entities
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public short Telefon { get; set; }
        public string Email { get; set; }
    }
}
