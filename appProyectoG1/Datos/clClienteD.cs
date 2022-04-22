using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appProyectoG1.Datos
{
    public class clClienteD
    {
        public void  mtdListar()
        {
            string sqlC = "select * from cliente";
            clConexion objConexion = new clConexion();
            DataTable tblCliente = new DataTable();
            tblCliente = objConexion |.mtdDesconectado(sqlC);
             
        }
    }
}