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
    
    public partial class colaboradorHojaRuta
    {
        public int idColHojaRuta { get; set; }
        public int idHojaRuta { get; set; }
        public int run { get; set; }
    
        public virtual colaborador colaborador { get; set; }
        public virtual hojaRuta hojaRuta { get; set; }
    }
}