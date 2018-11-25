using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPlantilla.Models
{
    public class HojaRutaViewModel
    {
        public int idHojaRuta { get; set; }
        public string idVehiculo { get; set; }
        public System.DateTime fechaCreacion { get; set; }
        public int fechaIngreso { get; set; }
        public Nullable<System.DateTime> fechaModificacion { get; set; }
        public Nullable<int> estado { get; set; }
        public int numeroGuia { get; set; }
    }
}