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
    public partial class frmClienteListar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clClienteL objDatos = new clClienteL();
            List<clClienteE> lista = new List<clClienteE>();
            lista = objDatos.mtdlistar();
            dgvCliente.DataSource = lista;
            dgvCliente.DataBind();
        }

        protected void dgvCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}