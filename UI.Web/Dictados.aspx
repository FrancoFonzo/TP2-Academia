<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Dictados.aspx.cs" Inherits="UI.Web.Dictados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="gridPanel" runat="server">
        <asp:GridView ID="gvDictados" runat="server" 
            AutoGenerateColumns="False" OnSelectedIndexChanged="gvCursos_SelectedIndexChanged" DataKeyNames="ID">
            <Columns>
                <asp:BoundField DataField="DocenteId" HeaderText="ID_Docente" />
                <asp:BoundField DataField="Docente" HeaderText="Docente" />
                <asp:BoundField DataField="CursoId" HeaderText="ID_Curso" />
                <asp:BoundField DataField="Curso" HeaderText="Descripcion" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
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
            <asp:Label ID="lblDocente" runat="server" Text="Docente"></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlDocentes" runat="server" DataValueField="ID">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblCurso" runat="server" Text="Curso"></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlCursos" runat="server" DataValueField="ID">
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblCargo" runat="server" Text="Cargo"></asp:Label>
            &nbsp;<asp:DropDownList ID="ddlCargos" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:ValidationSummary ID="vsErrores" runat="server" ForeColor="Red" HeaderText="Error" ValidationGroup="formCursos" />
            <asp:Panel ID="formActionsPanel" runat="server">
                <asp:LinkButton ID="linkCancelar" runat="server" OnClick="linkCancelar_Click">Cancelar</asp:LinkButton>
                <asp:LinkButton ID="linkAceptar" runat="server" OnClick="linkAceptar_Click">Aceptar</asp:LinkButton>
            </asp:Panel>
            <br />
        </asp:Panel>
</asp:Content>
