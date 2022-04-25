<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRegistrarProveerdor.aspx.cs" Inherits="appProyectoG1.Presentacion.WebRegistrarProveerdor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>REGISTRO</title>
   
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" />
</head>
<body  >
    <form id="form1" runat="server">
        <div>

            <div class="form-group">
                <asp:Label ID="Label1" runat="server" CssClass="form-label col-sm-2" Text=" Documento"></asp:Label>
                <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="Digite su Documento  "></asp:TextBox>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label2" runat="server" CssClass="form-label col-sm-2" Text=" Nombre"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Digite su Nombre  "></asp:TextBox>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label3" runat="server" CssClass="form-label col-sm-2" Text=" Apellido"></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Digite su Apellido  "></asp:TextBox>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label4" runat="server" CssClass="form-label col-sm-2" Text=" Telefono"></asp:Label>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" placeholder="Digite su Telefono "></asp:TextBox>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label5" runat="server" CssClass="form-label col-sm-2" Text=" Correo"></asp:Label>
                <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" placeholder="Buscar su Correo" TextMode="Email"></asp:TextBox>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">
                <asp:Label ID="Label6" runat="server" CssClass="form-label col-sm-2" Text=" Direccion"></asp:Label>
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Digite su Direccion "></asp:TextBox>
                <div class="col-sm-10">
                </div>
            </div>

            <div class="form-group">

                <asp:Button ID="btnRegistrar" runat="server" Text=" Registrar" CssClass="form-control btn btn-success" OnClick="Registar_Click" />
                <div class="col-sm-10">
                </div>
            </div>





        </div>
    </form>
</body>
</html>
