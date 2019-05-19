using CarServiceManager.Entities;
using System;

namespace CarWinForm.PresentationEntites
{
    public class OrderGridView
    {
        public int ComandaID { get; set; }
        public StareComandaDto StareComanda { get; set; }
        public DateTime DataSystem { get; set; }
        public DateTime DataProgramare { get; set; }
        public DateTime? DataFinalizare { get; set; }
        public int KmBord { get; set; }
        public string Descriere { get; set; }
        public decimal ValoarePiese { get; set; }
    }
}
