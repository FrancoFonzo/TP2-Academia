<%@ Page Title="Personas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script runat = "server" >
        void ValidarRegexEmail(object source, ServerValidateEventArgs args)
        {
            args.IsValid = Business.Logic.Validaciones.ValidarRegexEmail(args.Value);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvPersonas" runat="server" ViewStateMode="Enabled" 
            AutoGenerateColumns="False" OnSelectedIndexChanged="gvPersonas_SelectedIndexChanged" DataKeyNames="ID">
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="EMail" HeaderText="Email" />
                <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de nacimiento" />
                <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                <asp:CommandField HeaderText="Seleccionar" SelectText="Seleccionar" ShowSelectButton="True" />
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
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validNombre" runat="server" ErrorMessage="El nombre no puede estar vacio" ForeColor="Red" ControlToValidate="txtNombre" ValidationGroup="formPersonas">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validApellido" runat="server" ErrorMessage="El apellido no puede estar vacio" ForeColor="Red" ControlToValidate="txtApellido" ValidationGroup="formPersonas">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblLegajo" runat="server" Text="Legajo:"></asp:Label>
            <asp:TextBox ID="txtLegajo" runat="server" type="number"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="validEmail" runat="server" ControlToValidate="txtEmail" ValidateEmptyText="True" ErrorMessage="El email debe ser válido" ValidationGroup="formPersonas" OnServerValidate="ValidarRegexEmail">*</asp:CustomValidator>
            <br />
            <asp:Label ID="lblDireccion" runat="server" Text="Dirección:"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validDireccion" runat="server" ErrorMessage="La dirección no puede estar vacia" ForeColor="Red" ControlToValidate="txtDireccion" ValidationGroup="formPersonas">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validTelefono" runat="server" ErrorMessage="El teléfono no puede estar vacio" ForeColor="Red" ControlToValidate="txtTelefono" ValidationGroup="formPersonas">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblFecha" runat="server" Text="Fecha de nacimiento:"></asp:Label>
            <asp:Calendar ID="calendarFecha" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="lblTipo" runat="server" Text="Tipo:"></asp:Label>
            <asp:DropDownList ID="ddlTipo" runat="server">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="validTipo" runat="server" ErrorMessage="El tipo no puede estar vacio" ForeColor="Red" ControlToValidate="ddlTipo" InitialValue="[Seleccionar]" ValidationGroup="formPersonas">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblPlan" runat="server" Text="Plan:"></asp:Label>
            <asp:DropDownList ID="ddlPlan" runat="server" DataTextField="Descripcion" DataValueField="ID">
            </asp:DropDownList>
            <br />
            <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formPersonas" />
            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
                <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            </asp:Panel>
            <br />
        </asp:Panel>
</asp:Content>
