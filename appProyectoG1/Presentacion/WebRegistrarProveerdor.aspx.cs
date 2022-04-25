using appProyectoG1.Entidad;
using appProyectoG1.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace appProyectoG1.Presentacion
{
    public partial class WebRegistrarProveerdor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Registar_Click(object sender, EventArgs e)
        {
            clProveedorE objDatosProveedorE = new clProveedorE();

            objDatosProveedorE.documento = txtDocumento.Text;
            objDatosProveedorE.nombre = txtNombre.Text;
            objDatosProveedorE.apellido = txtApellido.Text;
            objDatosProveedorE.correo = txtCorreo.Text;
            objDatosProveedorE.direccion = txtDireccion.Text;
            objDatosProveedorE.telefono = txtTelefono.Text;
           


            clProveedorL objProveedorL = new clProveedorL();

            int filas = objProveedorL.mtdRegistrarL(objDatosProveedorE);

            if (filas > 0)
            {
                MessageBox.Show("El Proveedor ha sido registrado correctamente");
            }
            else
            {
                MessageBox.Show("Error al registrar el Proveedor");
            }
        }
    }
}