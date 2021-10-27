<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvComisiones" runat="server" 
            AutoGenerateColumns="False" OnSelectedIndexChanged="gvComisiones_SelectedIndexChanged" DataKeyNames="ID">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="AnioEspecialidad" HeaderText="Año Calendario" />
                <asp:BoundField DataField="Plan.Descripcion" HeaderText="Descripción Plan" />
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
            <asp:Label ID="lblAnio" runat="server" Text="Año Especialidad:"></asp:Label>
            <asp:TextBox ID="txtAnio" runat="server" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validAnio" runat="server" ErrorMessage="El año no puede estar vacio" ForeColor="Red" ControlToValidate="txtAnio" ValidationGroup="formComisiones">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblDescripcion" runat="server" Text="Número de comisión:"></asp:Label>
            <asp:TextBox ID="txtDescripcion" runat="server" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validDescripcion" runat="server" ErrorMessage="La descripción no puede estar vacia" ForeColor="Red" ControlToValidate="txtDescripcion" ValidationGroup="formComisiones">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblPlan" runat="server" Text="Plan:"></asp:Label>
            <asp:DropDownList ID="ddlPlan" runat="server" DataTextField="Descripcion" DataValueField="ID">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="validPlan" runat="server" ErrorMessage="El plan no puede estar vacio" ForeColor="Red" ControlToValidate="ddlPlan" InitialValue="[Seleccionar]" ValidationGroup="formComisiones">*</asp:RequiredFieldValidator>
            <br />
            <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formComisiones" />
            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
                <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            </asp:Panel>
            <br />
        </asp:Panel>
</asp:Content>