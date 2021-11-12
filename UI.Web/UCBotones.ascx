<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCBotones.ascx.cs" Inherits="UI.Web.UCBotones" %>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <br />
        <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="linkEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="eliminarLinkButton" runat="server" OnClick="linkEliminar_Click">Eliminar</asp:LinkButton>
        <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="linkNuevo_Click">Nuevo</asp:LinkButton>
    </asp:Panel>