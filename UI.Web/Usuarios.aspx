<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
    <asp:GridView ID="gvUsuarios" runat="server" AutoGenerateColumns="False"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged">
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
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ErrorMessage="El usuario no puede estar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvClave" runat="server" ErrorMessage="La clave no puede estar vacia" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblRepetirClave" runat="server" Text="Repetir Clave:"></asp:Label>
        <asp:TextBox ID="txtRepetirClave" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvRepetirClaves" runat="server" ErrorMessage="Las claves no coinciden" ForeColor="Red">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblHabilitado" runat="server" Text="Habilitado:"></asp:Label>
        <asp:CheckBox ID="chkHabilitado" runat="server" />
        <br />
        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" />
    </asp:Panel>
    <asp:Panel ID="gridActionsPanel" runat="server">
        <asp:LinkButton ID="linkEditar" runat="server" OnClick="linkEditar_Click">Editar</asp:LinkButton>
        <asp:LinkButton ID="linkNuevo" runat="server" OnClick="linkNuevo_Click">Nuevo</asp:LinkButton>
        <asp:LinkButton ID="linkEliminar" runat="server" OnClick="linkEliminar_Click">Eliminar</asp:LinkButton>
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">
        <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
        <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
