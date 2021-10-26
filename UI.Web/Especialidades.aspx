<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvEspecialidad" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gvEspecialidad_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        <asp:Panel ID="gridActionsPanel" runat="server">
            <asp:LinkButton ID="linkEditar" runat="server" OnClick="linkEditar_Click">Editar</asp:LinkButton>
            <asp:LinkButton ID="linkNuevo" runat="server" OnClick="linkNuevo_Click">Nuevo</asp:LinkButton>
            <asp:LinkButton ID="linkEliminar" runat="server" OnClick="linkEliminar_Click">Eliminar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        &nbsp;<br />&nbsp;<asp:Label ID="lblDescripcion" runat="server" Text="Descripcion:"></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        &nbsp;<br />&nbsp;
        <br />
&nbsp;<asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
