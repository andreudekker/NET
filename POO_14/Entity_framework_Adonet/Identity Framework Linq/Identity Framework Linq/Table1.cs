//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Identity_Framework_Linq
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table1
    {
        public int Idclientes { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
    
        public virtual Clientes1 Clientes1 { get; set; }
    }
}