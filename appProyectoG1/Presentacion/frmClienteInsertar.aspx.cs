using appProyectoG1.Entidad;
using appProyectoG1.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace appProyectoG1.Presentacion
{
    public partial class frmClienteInsertar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
                    
               clClienteE objDatosPedidos = new clClienteE();
                objDatosPedidos.documento = txtdocumento.Text;
                objDatosPedidos.nombre = txtnombre.Text;
                objDatosPedidos.apellido = txtapellido.Text;
                objDatosPedidos.telefono = txttelefono.Text;
                objDatosPedidos.correo = txtcorreo.Text;
                objDatosPedidos.direccion = txtdireccion.Text;
                

                clClienteL objPedidos = new clClienteL();
                int resultado = objPedidos.mtdRegistrar(objDatosPedidos);

                if (resultado > 0)
                {
                    lblmensaje.Text = "Datos Registrados";
                }
                else
                {
                    lblmensaje.Text = "Error al registrar Datos";
                }

            

        }
    }
}
    
