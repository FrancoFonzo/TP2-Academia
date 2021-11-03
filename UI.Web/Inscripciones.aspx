<%@ Page Title="Inscripciones" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvInscripciones" runat="server" AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gvInscripciones_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="DescripcionMateria" HeaderText="Materia" />
                <asp:BoundField HeaderText="Comision" DataField="DescripcionComision" />
                <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                <asp:BoundField HeaderText="Nota" DataField="Nota" />
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
        <asp:Label ID="lblAlumno" runat="server" Text="Alumno:"></asp:Label>
        <asp:TextBox ID="txtAlumno" runat="server"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="validAlumno" runat="server" ErrorMessage="El alumno no puede estar vacio" ForeColor="Red" ControlToValidate="txtAlumno" ValidationGroup="formInscripcion">*</asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblCondicion" runat="server" Text="Condicion:"></asp:Label>
        <asp:DropDownList ID="ddlCondicion" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblCursos" runat="server" Text="Cursos:"></asp:Label>
        <br />
        <asp:GridView ID="gvCursos" runat="server" AutoGenerateColumns="False" 
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" OnSelectedIndexChanged="gvCursos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Materia" HeaderText="Materia" />
                <asp:BoundField DataField="Comision" HeaderText="Comision" />
                <asp:BoundField DataField="AnioCalendario" HeaderText="Año Calendario" />
                <asp:CommandField ShowSelectButton="True" SelectText="Seleccionar" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
        <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formInscripcion" />
        <asp:Panel ID="formActionsPanel" runat="server">
            <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
