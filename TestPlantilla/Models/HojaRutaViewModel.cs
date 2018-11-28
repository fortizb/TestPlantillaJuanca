using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPlantilla.Models
{
    public class HojaRutaViewModel
    {
        public int idHojaRuta { get; set; }
        public string patente { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public int fechaIngreso { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public string estado { get; set; }
        public int idColHojaRuta { get; set; }
        public int run { get; set; }
        public string nombre { get; set; }
    }
}