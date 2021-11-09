<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>
<%@ Register src="UCBotones.ascx" tagname="UCBotones" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvEspecialidad" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gvEspecialidad_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        <uc1:UCBotones ID="UCBotones1" runat="server" Oneditar="linkEditar_Click" Oneliminar="linkEliminar_Click" Onnuevo="linkNuevo_Click"/>
        <br />
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="lblDescripcion" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="validEspecialidad" runat="server" ErrorMessage="El campo no puede estar vacio" ForeColor="Red" ControlToValidate="txtDescripcion" ValidationGroup="formEspecialidad">*</asp:RequiredFieldValidator>
        <br />
        &nbsp;<br />
        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formEspecialidad" />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
            &nbsp;
            <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
