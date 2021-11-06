<%@ Page Title="RegistrarNotas" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="RegistrarNotas.aspx.cs" Inherits="UI.Web.RegistrarNotas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
     <asp:Panel ID="formPanelCurso" runat="server" Visible="False">
         <br />
         <asp:Label ID="lblDocente" runat="server" Text="Docente:" Visible="False"></asp:Label>
         <asp:DropDownList ID="ddlDocente" runat="server" DataTextField="NombreCompleto" DataValueField="ID" OnSelectedIndexChanged="ddlDocente_SelectedIndexChanged" Visible="False" AutoPostBack="True">
         </asp:DropDownList>
        <br />
         <br />
        <asp:Label ID="lblCurso" runat="server" Text="Curso: "></asp:Label>
        <asp:DropDownList ID="ddlCurso" runat="server" DataTextField="Curso" DataValueField="ID" OnSelectedIndexChanged="ddlCurso_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
         <br />
     </asp:Panel>
    <br />
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvRegistrarNotas" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White" OnSelectedIndexChanged="gvRegistrarNotas_SelectedIndexChanged" DataKeyNames="ID">
            <Columns>
                <asp:BoundField HeaderText="Legajo" DataField="Legajo"  />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                <asp:BoundField HeaderText="Nota" DataField="Nota" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>
    <br />
    <asp:Panel ID="formPanel" runat="server" Visible="False">
        <asp:Label ID="lblNota" runat="server" Text="Ingresar nota: "></asp:Label>
        <asp:TextBox ID="txtNota" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validNota" runat="server" ErrorMessage="La nota no puede estar vacía" ForeColor="Red" ControlToValidate="txtNota" InitialValue="[Seleccionar]" ValidationGroup="formRegistrar">*</asp:RequiredFieldValidator>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formRegistrar" />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
            <asp:LinkButton ID="linkGuardar" runat="server" OnClick="linkGuardar_Click">Guardar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
