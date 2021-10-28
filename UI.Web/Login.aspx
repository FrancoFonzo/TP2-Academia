<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Academia</title>
    <link href="./css/styles.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style1 {
            margin-left: 17px;
        }
    </style>
</head>
<body>
    <header id="header">
        <h1>Academia</h1>
    </header>
    <form id="form" class="login" runat="server">
        <fieldset id="form-group">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario"></asp:Label>
            <span>
                <asp:TextBox ID="txtUsuario" runat="server" Font-Size="20px" Height="30px" Width="240px"></asp:TextBox>
                <asp:CustomValidator ID="cvValidarUsuario" runat="server" ErrorMessage="Usuario y/o contraseña incorrectos." ForeColor="Red" OnServerValidate="cvValidarUsuario_ServerValidate" ControlToValidate="txtUsuario" ValidateEmptyText="True">*</asp:CustomValidator>
            </span>
            <asp:Label ID="lblClave" runat="server" Text="Contraseña"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password" Font-Size="20px" Height="30px" Width="240px"></asp:TextBox>
            <br />
            <asp:Button ID="btnIniciarSesion" runat="server" BorderStyle="None" Text="Iniciar Sesión" BackColor="#27B1C5" Font-Bold="True" Height="30px" OnClick="btnIniciarSesion_Click" Width="245px" />
            <br />
            <asp:ValidationSummary ID="vsLogin" runat="server" ForeColor="Red" CssClass="auto-style1" />
            <asp:LinkButton ID="linkRecuperarClave" runat="server" BorderStyle="None" Width="240px">¿Has olvidado la contraseña?</asp:LinkButton>
        </fieldset>
    </form>
</body>
</html>
