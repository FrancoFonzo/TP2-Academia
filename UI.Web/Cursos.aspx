<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<%@ Register src="UCBotones.ascx" tagname="UCBotones" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvCursos" runat="server" 
            AutoGenerateColumns="False" OnSelectedIndexChanged="gvCursos_SelectedIndexChanged" DataKeyNames="ID">
            <Columns>
                <asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:CommandField HeaderText="Seleccionar" SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        
        <br />
        <uc1:UCBotones ID="UCBotones1" runat="server" Oneditar="linkEditar_Click" Oneliminar="linkEliminar_Click" Onnuevo="linkNuevo_Click"/>
        
    </asp:Panel>
    <asp:Panel ID="formPanel" runat="server" Visible="False">
            <asp:Label ID="lblAnio" runat="server" Text="Año Calendario:"></asp:Label>
            <asp:TextBox ID="txtAnio" runat="server" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validAnio" runat="server" ErrorMessage="El año no puede estar vacio" ForeColor="Red" ControlToValidate="txtAnio" ValidationGroup="formCursos">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblCupo" runat="server" Text="Cupo:"></asp:Label>
            <asp:TextBox ID="txtCupo" runat="server" type="number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="validCupo" runat="server" ErrorMessage="El cupo no puede estar vacio" ForeColor="Red" ControlToValidate="txtCupo" ValidationGroup="formCursos">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblMateria" runat="server" Text="Materia:"></asp:Label>
            <asp:DropDownList ID="ddlMateria" runat="server" DataTextField="Descripcion" DataValueField="ID">
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="validMateria" runat="server" ErrorMessage="La materia no puede estar vacia" ForeColor="Red" ControlToValidate="ddlMateria" InitialValue="[Seleccionar]" ValidationGroup="formCursos">*</asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblComision" runat="server" Text="Comision:"></asp:Label>
            <asp:DropDownList ID="ddlComision" runat="server" DataTextField="Descripcion" DataValueField="ID"></asp:DropDownList>
            <asp:RequiredFieldValidator ID="validComision" runat="server" ErrorMessage="La comisión no puede estar vacia" ForeColor="Red" ControlToValidate="ddlComision" InitialValue="[Seleccionar]" ValidationGroup="formCursos">*</asp:RequiredFieldValidator>
            <br />
            <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formCursos" />
            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
                &nbsp;&nbsp;
                <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            </asp:Panel>
            <br />
        </asp:Panel>
</asp:Content>