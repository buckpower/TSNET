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
    
    public partial class Auto
    {
        public int AutoId { get; set; }
        public string NumarAuto { get; set; }
        public string SerieSasiu { get; set; }
    
        public virtual Sasiu Sasiu { get; set; }
    }
}