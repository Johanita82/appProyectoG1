using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appProyectoG1.Entidad;
using appProyectoG1.Datos;

namespace appProyectoG1.Logica
{
    public class clServicioL
    {
        public int mtdRegistrar(clServicioE objDatos)
        {
            clServicioD objServicioD = new clServicioD();
            int resultado = objServicioD.mtdRegistrar(objDatos);
            return resultado;
        }


        public List<clServicioE> mtdListarS()
        {
            clServicioD objdatosPro = new clServicioD();
            List<clServicioE> objproE = new List<clServicioE>();
            objproE = objdatosPro.mtdListarS();
            return objproE;

        }
    }
}