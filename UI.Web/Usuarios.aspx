<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
    <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="PersonaNombre" />
            <asp:BoundField HeaderText="Apellido" DataField="PersonaApellido" />
            <asp:BoundField HeaderText="EMail" DataField="PersonaEMail" />
            <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario" />
            <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
        </Columns>
        <SelectedRowStyle BackColor="Black" ForeColor="White" />
    </asp:GridView>
</asp:Panel>
</asp:Content>
