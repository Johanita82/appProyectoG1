<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Menu.Master" AutoEventWireup="true" CodeBehind="frmClienteInsertar.aspx.cs" Inherits="appProyectoG1.Presentacion.frmClienteInsertar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">

        <div class="mb-3 mt-3">
            <label for="documento" class="form-label">Documento:</label>
            <br />
&nbsp;<asp:TextBox ID="txtdocumento" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="nombre" class="form-label">Nombres:</label>
            <br />
&nbsp;<asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        </div>
        <div class="mb-3">
            <label for="apellido" class="form-label">Apellido:</label>
            <br />
&nbsp;<asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
        </div>
        
        <div class="mb-3">
            <label for="telefono" class="form-label">Telefono:</label>
            <br />
&nbsp;<asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="correo" class="form-label">Correo:</label>
            <br />
&nbsp;<asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
        </div>

        <div class="mb-3">
            <label for="direccion" class="form-label">Dirección:</label>
            <br />
&nbsp;<asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
        </div>
        
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Csslass="btn btn-primary" OnClick="btnAceptar_Click" />
        <asp:Label ID="lblmensaje" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
