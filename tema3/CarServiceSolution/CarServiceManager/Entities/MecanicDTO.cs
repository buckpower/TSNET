using CarService;

namespace CarServiceManager.Entities
{
    public class MecanicDTO
    {
        public MecanicDTO()
        {
        }

        internal MecanicDTO(Mecanic mecanic)
        {
            MecanicId = mecanic.MecanicId;
            Nume = mecanic.Nume;
            Prenume = mecanic.Prenume;
        }

        public int MecanicId { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
    }
}
