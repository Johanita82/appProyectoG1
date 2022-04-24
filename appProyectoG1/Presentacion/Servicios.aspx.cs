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
            if (!Page.IsPostBack)
            {
                clServicioL objServicioL = new clServicioL();
                dgvServicio.DataSource = objServicioL.mtdListarS();
                dgvServicio.DataBind();

                clClienteL objClienteL = new clClienteL();
                ddlCliente.DataSource = objClienteL.mtdlistar();
                ddlCliente.DataValueField = "idCliente";
                ddlCliente.DataTextField = "nombre";
                ddlCliente.DataBind();
                ddlCliente.Items.Insert(0, new ListItem("Seleccione Cliente", "0"));

                clProveedorL objProveedorL = new clProveedorL();
                //ddlProveedor.DataSource = objProveedorL.mtdListar();
                //ddlProveedor.DataBind();
                //ddlProveedor.Items.Insert(0, new ListItem("Seleccione Proveedor", "0"));
            }

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            clServicioE objDatos = new clServicioE();
            objDatos.nombreServicio = txtNombre.Text;
            objDatos.descripcion = txtDescripcion.Text;
            objDatos.idCliente = int.Parse(ddlCliente.SelectedValue.ToString());
            objDatos.idProveedor = 1; /*int.Parse(ddlProveedor.SelectedValue.ToString());
*/
            if (objDatos.idCliente != 0 /*&& objDatos.idProveedor != 0*/)
            {
                clServicioL objServicioL = new clServicioL();
                int resultado = objServicioL.mtdRegistrar(objDatos);

                if (resultado != 0)
                {
                    lblMensaje.Text = "Servicio pedido con exito";
                    dgvServicio.DataSource = objServicioL.mtdListarS();
                    dgvServicio.DataBind();
                }
                else
                {
                    lblMensaje.Text = "Ocurrio un error";
                }

            }

        }

    }

}