using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appProyectoG1.Entidad
{
    public class clServicioE
    {
        public int idServicio { get; set; }
        public string nombreServicio { get; set; }
        public string descripcion { get; set; }
        public int idCliente { get; set; }
        public int idProveedor { get; set; }
    }
}