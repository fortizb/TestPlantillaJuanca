//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestPlantilla.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class estadoHojaRuta
    {
        public estadoHojaRuta()
        {
            this.hojaRuta = new HashSet<hojaRuta>();
        }
    
        public int idEstadoHojaRuta { get; set; }
        public string descEstadoHojaRuta { get; set; }
    
        public virtual ICollection<hojaRuta> hojaRuta { get; set; }
    }
}
