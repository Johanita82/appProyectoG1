using System;
using System.Collections.Generic;
using System.Data;
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
        public List<clServicioE> mtdListarS()
        {
            string sql = "select * from servicio ";
            clConexion objConexion = new clConexion();
            DataTable tblServicio = new DataTable();
            tblServicio = objConexion.mtdDesconectado(sql);

            List<clServicioE> listarServicio = new List<clServicioE>();
            int cantReg = tblServicio.Rows.Count;
            for (int i = 0; i < cantReg; i++)
            {
                clServicioE objDatosPro = new clServicioE();
                objDatosPro.idServicio = int.Parse(tblServicio.Rows[i]["idServicio"].ToString());
                objDatosPro.nombreServicio = tblServicio.Rows[i]["nombreServicio"].ToString();
                objDatosPro.descripcion = tblServicio.Rows[i]["descripcion"].ToString();
                objDatosPro.idCliente = int.Parse(tblServicio.Rows[i]["idCliente"].ToString());
                objDatosPro.idProveedor = int.Parse(tblServicio.Rows[i]["idProveedor"].ToString());
                listarServicio.Add(objDatosPro);
            }
            return listarServicio;
        }
    }

}