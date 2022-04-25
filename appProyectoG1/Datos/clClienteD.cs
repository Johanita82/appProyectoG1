using appProyectoG1.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace appProyectoG1.Datos
{
    public class clClienteD
    {
        public List<clClienteE>  mtdListar()
        {
            string sqlC = "select * from cliente";
            clConexion objConexion = new clConexion();
            DataTable tblCliente = new DataTable();
            tblCliente = objConexion.mtdDesconectado(sqlC);
             
            List<clClienteE> ListaCliente=new List<clClienteE>();
            int cantReg =tblCliente.Rows.Count;

            for (int i = 0; i < cantReg; i++)
            {
                clClienteE objCliente = new clClienteE();
                objCliente.idCliente = int.Parse(tblCliente.Rows[i]["idCliente"].ToString());
                objCliente.documento= tblCliente.Rows[i]["documento"].ToString();
                objCliente.nombre = tblCliente.Rows[i]["nombre"].ToString();
                objCliente.apellido=tblCliente.Rows[i]["apellido"].ToString();
                objCliente.telefono=tblCliente.Rows[i]["telefono"].ToString() ;
                objCliente.correo = tblCliente.Rows[i]["correo"].ToString();
                objCliente.direccion=tblCliente.Rows[i]["direccion"].ToString();
                 ListaCliente.Add(objCliente);
            }
            return ListaCliente;
        }

        public int mtdRegistrar(clClienteE objDatos)
        {
            string sql = "insert into cliente (documento,nombre,apellido,telefono,correo,direccion) values ('"+objDatos.documento+"','"+objDatos.nombre+"','"+objDatos.apellido+"','"+objDatos.telefono+"','"+objDatos.correo+"','"+objDatos.direccion+"')";
            clConexion objConexion = new clConexion();

            int resultado = objConexion.mtdConectar(sql);

            return resultado;
        }



    }
}