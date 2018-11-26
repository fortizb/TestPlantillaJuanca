using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPlantilla.Models
{
    public class HojaRutaDetalleGuiaViewModel
    {
        public int idHrdGuia { get; set; }
        public int idHojaRutaDetalle { get; set; }
        public int numeroGuia { get; set; }
        public int idEstadoEntrega { get; set; }
        public string observaciones { get; set; }
        public string direccion { get; set; }
        public string rut { get; set; }
        public string ciudad { get; set; }
        public string nombreRazonSocial { get; set; }
        public int telefono { get; set; }
    }
}