using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appProyectoG1.Entidad;

namespace appProyectoG1.Datos
{
    public class clServicioD
    {
        public int mtdRegistrar(clServicioE objDatos)
        {
            string sql = "INSERT INTO servicio (nombreServicio, descripcion, idCliente, idProveedor) VALUES ('" + objDatos.nombreServicio + "', '" + objDatos.descripcion + "', " + objDatos.idCliente + ", " + objDatos.idProveedor + " ) ";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectar(sql);
            return resultado;
        }
    }
}