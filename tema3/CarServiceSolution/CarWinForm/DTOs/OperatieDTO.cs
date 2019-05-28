using CarWinForm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManager.Entities
{
    public class OperatieDTO
    {
        public OperatieDTO()
        {

        }

        internal OperatieDTO(Operatie o)
        {
            OperatieId = o.OperatieId;
            Denumire = o.Denumire;
            TimpExecutie = o.TimpExecutie;
        }

        public int OperatieId { get; set; }
        public string Denumire { get; set; }
        public decimal TimpExecutie { get; set; }
    }
}
