﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Menu.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="appProyectoG1.Presentacion.Servicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="p-5 bg-dark text-white text-center">
        <h1>Servicios</h1>
        <p>Crud de Servicios</p>
    </div>

    <div class="container">

        <div class="card">

            <div class="card-header">Registro de Servicios</div>

            <div class="card-body">

                <div class="mb-3 mt-3">
                    <label class="form-label">Nombre:</label>
                    <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="mb-3 mt-3">
                    <label class="form-label">Descripcion:</label>
                    <asp:TextBox ID="txtDescripcion" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>

                <div class="mb-3 mt-3">
                    <label class="form-label">Cliente:</label>
                    <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <div class="mb-3 mt-3">
                    <label class="form-label">Proveedor:</label>
                    <asp:DropDownList ID="ddlProveedor" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>


            </div>

            <div class="card-footer">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label><br />
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" />
            </div>

        </div>

    </div>

</asp:Content>