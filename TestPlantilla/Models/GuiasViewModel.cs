using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPlantilla.Models
{
    public class GuiasViewModel
    {
        public int numeroGuia { get; set; }
        public Nullable<System.DateTime> fechaIngreso { get; set; }
        public string direccion { get; set; }
        public string rut { get; set; }
        public string nombreRazonSocial { get; set; }
        public Nullable<int> telefono { get; set; }
        public bool estado { get; set; }
        public string ciudad { get; set; }
        public string observacion { get; set; }
    }
}