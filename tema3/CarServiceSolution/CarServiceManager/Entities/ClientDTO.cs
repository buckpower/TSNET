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

        public ClientDTO() { }

        internal ClientDTO(Client dto)
        {
            Id = dto.Id;
            Nume = dto.Nume;
            Prenume = dto.Prenume;
            Adresa = dto.Adresa;
            Email = dto.Email;
            Localitate = dto.Localitate;
            Judet = dto.Judet;
            Telefon = dto.Telefon;
        }
    }
}
