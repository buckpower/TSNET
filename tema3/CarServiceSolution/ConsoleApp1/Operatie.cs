//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public partial class Operatie
    {
        [DataMember]
        public int OperatieId { get; set; }
        [DataMember]
        public string Denumire { get; set; }
        [DataMember]
        public decimal TimpExecutie { get; set; }
    }
}
