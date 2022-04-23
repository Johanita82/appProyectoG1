using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using appProyectoG1.Entidad;
using appProyectoG1.Logica;

namespace appProyectoG1.Presentacion
{
    public partial class Servicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clServicioL objServicioL = new clServicioL();
            dgvServicio.DataSource = objServicioL.mtdListarS();
            dgvServicio.DataBind();

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            clServicioE objDatos = new clServicioE();
            objDatos.nombreServicio = txtNombre.Text;
            objDatos.descripcion = txtDescripcion.Text;
            objDatos.idCliente = int.Parse(ddlCliente.SelectedValue.ToString());
            objDatos.idProveedor = int.Parse(ddlProveedor.SelectedValue.ToString());

            clServicioL objServicioL = new clServicioL();
            int resultado = objServicioL.mtdRegistrar(objDatos);

        }

    }

}