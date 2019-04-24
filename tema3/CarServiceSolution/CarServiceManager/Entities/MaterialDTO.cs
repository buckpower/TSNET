using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarService;

namespace CarServiceManager.Entities
{
    public class MaterialDTO
    {
        internal MaterialDTO(Material material)
        {
            MaterialId = material.MaterialId;
            Cantitate = material.Cantitate;
            Denumire = material.Denumire;
            Pret = material.Pret;
            DataAprovizionare = material.DataAprovizionare;
        }

        public int MaterialId { get; set; }
        public string Denumire { get; set; }
        public decimal Cantitate { get; set; }
        public decimal Pret { get; set; }
        public System.DateTime DataAprovizionare { get; set; }
    }
}
