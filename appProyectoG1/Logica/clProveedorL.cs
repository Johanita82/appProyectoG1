
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using appProyectoG1.Entidad;
using appProyectoG1.Datos;

namespace appProyectoG1.Logica
{
    public class clProveedorL
    { 
        // Registrar 
    public int mtdRegistrarL(clProveedorE objDatosProveedorE)
    {
        clProveedorD objProveedorD = new clProveedorD();

        int resultado = objProveedorD.mtdRegistrarD(objDatosProveedorE);

        return resultado;

    }
    }
}
