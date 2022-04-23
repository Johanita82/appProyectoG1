using appProyectoG1.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appProyectoG1.Datos
{

    public class clProveedorD
    {
        public int mtdRegistrarD(clProveedorE objProveedorE)
        {
            string sql = "insert into proveedor (documento, nombre, apellido, email, direccion, telefono )" +
                " values (" +
                "'" + objProveedorE.documento + "', " +
                "'" + objProveedorE.nombre + "'," +
                " '" + objProveedorE.apellido + "'," +
                " "  + objProveedorE.correo + "'," +" '" + objProveedorE.direccion + "', '" + objProveedorE.telefono+"')";

            clConexion objConexion = new clConexion();

            int resultado = objConexion.mtdConectar(sql);

            return resultado;

        }
       






    }




}