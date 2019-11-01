<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendaWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SW Tienda Online</title>
    <style type="text/css">
        #Panel1,#Panel2,#Panel3 { padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label4" runat="server" Text="Bienvenido a nuestra Tienda Online" Font-Bold="True" Font-Italic="True" Font-Size="Large" Font-Strikeout="False" Font-Underline="False" ForeColor="#333333"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BorderColor="#CCCCCC" BorderStyle="Inset">
            Nombre del Producto:<br />
            <asp:TextBox ID="txtProdName" runat="server" OnTextChanged="txtProdName_TextChanged"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Buscar Producto" />
            <asp:DropDownList ID="dropProdName" runat="server" OnSelectedIndexChanged="dropProdName_SelectedIndexChanged" OnTextChanged="dropProdName_TextChanged">
                <asp:ListItem Selected="True" Value="0">[Seleccione un producto...]</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblExist" runat="server" Text=""></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" BorderColor="#CCCCCC" BorderStyle="Inset">
            ID del Producto:<br />
            <asp:TextBox ID="txtProdId" runat="server"></asp:TextBox>            
            <asp:Button ID="btnFechaAlta" runat="server" Text="Buscar Fecha" OnClick="btnFechaAlta_Click" />
            <asp:Label ID="lblFecha" runat="server" Text=""></asp:Label>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel3" runat="server" BorderColor="#CCCCCC" BorderStyle="Outset">
            Ventas:<br />
            <asp:Label ID="Label1" runat="server" Text="1er Cuatrimestre:"></asp:Label>
            <asp:TextBox ID="txtq1" runat="server" Width="50px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="2do Cuatrimestre:"></asp:Label>
            <asp:TextBox ID="txtq2" runat="server" Width="50px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="3er Cuatrimestre:"></asp:Label>
            <asp:TextBox ID="txtq3" runat="server" Width="50px"></asp:TextBox>            
            <asp:Button ID="btnProm" runat="server" Text="Promedio de Ventas" OnClick="btnProm_Click" />            
            <asp:TextBox ID="txtPromedio" runat="server" Width="85px"></asp:TextBox>
            
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
