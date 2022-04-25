using appProyectoG1.Datos;
using appProyectoG1.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appProyectoG1.Logica
{
    public class clClienteL
    {
        public List<clClienteE> mtdlistar()
        {
            clClienteD objDatosC = new clClienteD();
            List<clClienteE> listaCliente= new List<clClienteE>();
            listaCliente = objDatosC.mtdListar();
            return listaCliente;
        }

        public int mtdRegistrar(clClienteE objDatos)
        {
            clClienteD objDatosPedido = new clClienteD();
            int resultado = objDatosPedido.mtdRegistrar(objDatos);
            return resultado;
        }
    }
}