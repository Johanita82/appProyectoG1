﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Menu.Master" AutoEventWireup="true" CodeBehind="frmClienteListar.aspx.cs" Inherits="appProyectoG1.Presentacion.frmClienteListar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="p-5 bg-dark text-white text-center">
        <h1>Lista de Clientes</h1>
    </div>
     <div class="container">
               <div class="card-body">
                   <asp:GridView ID="dgvCliente" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="133px" Width="843px">
                       <AlternatingRowStyle BackColor="#DCDCDC" />
                       <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                       <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                       <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                       <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                       <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                       <SortedAscendingCellStyle BackColor="#F1F1F1" />
                       <SortedAscendingHeaderStyle BackColor="#0000A9" />
                       <SortedDescendingCellStyle BackColor="#CAC9C9" />
                       <SortedDescendingHeaderStyle BackColor="#000065" />
                   </asp:GridView>
                </div>
            </div>
        
</asp:Content>
