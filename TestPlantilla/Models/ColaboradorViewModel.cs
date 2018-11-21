using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestPlantilla.Models
{
    public class ColaboradorViewModel
    {
        public int run { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public Nullable<int> edad { get; set; }
        public string cargo { get; set; }
        public Nullable<int> telefono { get; set; }
        public Nullable<int> valorHoraExtra { get; set; }
        public Nullable<bool> activo { get; set; }
    }
}