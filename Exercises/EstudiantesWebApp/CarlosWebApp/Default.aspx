<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CarlosWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Bienvenido!!
        <br>
        <asp:Button ID="btnExisteEst" runat="server" Text="Existe Estudiante" OnClick="existClick"/>
        <asp:Button ID="btnFechaNac" runat="server" Text="Fecha de Nacimiento" 
            onclick="btnFechaNac_Click" />

        <asp:Panel ID="Panel1" runat="server" Height="38px">
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>            
            <asp:TextBox ID="edtName" runat="server"></asp:TextBox>
            <asp:Label ID="lblExist" runat="server" Text="Existe Estudiante?"></asp:Label>
        </asp:Panel>
    
    <asp:Panel ID="Panel2" runat="server">
        <asp:Label ID="Label2" runat="server" Text="CI: "></asp:Label>
        <asp:TextBox ID="edtCI" runat="server"></asp:TextBox>
        <asp:Label ID="Birth" runat="server" Text="Fecha de Nacimiento?"></asp:Label>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
