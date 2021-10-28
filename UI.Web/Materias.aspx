<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvMaterias" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gvMaterias_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField HeaderText="Horas Semanales" DataField="HorasSemanales" />
                <asp:BoundField HeaderText="Horas Totales" DataField="HorasTotales" />
                <asp:BoundField HeaderText="Plan" DataField="Plan" />
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
        Materia<asp:TextBox ID="txtMateria" runat="server" type="string" Width="259px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validMateria" runat="server" ErrorMessage="El campo de materia no puede estar vacio" ForeColor="Red" ControlToValidate="txtMateria" ValidationGroup="formMateria">*</asp:RequiredFieldValidator>
        <br />
        Horas Totales<asp:TextBox ID="txtHorasTotales" runat="server" type="number" Width="146px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validHorasTotales" runat="server" ErrorMessage="El campo de horas totales no puede estar vacio" ForeColor="Red" ControlToValidate="txtHorasTotales" ValidationGroup="formMateria">*</asp:RequiredFieldValidator>
        <br />
        Horas Semanales<asp:TextBox ID="txtHorasSemanales" runat="server" type="number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="validHorasSemanales" runat="server" ErrorMessage="El campo de horas semanales no puede estar vacio" ForeColor="Red" ControlToValidate="txtHorasSemanales" ValidationGroup="formMateria">*</asp:RequiredFieldValidator>
        <br />
        Plan<asp:DropDownList ID="ddlPlan" runat="server" DataTextField="Descripcion" DataValueField="ID">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="validPlan" runat="server" ErrorMessage="El plan no puede estar vacio" ForeColor="Red" ControlToValidate="ddlPlan" InitialValue="[Seleccionar]" ValidationGroup="formMateria">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formMateria" />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
