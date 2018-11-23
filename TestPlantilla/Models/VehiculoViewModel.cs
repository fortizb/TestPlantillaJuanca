using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPlantilla.Models
{
    public class VehiculoViewModel
    {
        public string patente { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public Nullable<int> velocidadPromedio { get; set; }
        public Nullable<int> rendimiento { get; set; }
        public Nullable<int> capacidadCarga { get; set; }
        public Nullable<bool> activo { get; set; }
    }
}