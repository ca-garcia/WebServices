﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsumeService.aspx.cs" Inherits="CarlosWebService.ConsumeService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consumiendo Servicio Web</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblName" runat="server" Text="Nombre: " Font-Bold="true"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" Text="" ></asp:TextBox>
    <asp:Button ID="btnSend" runat="server" Text="Fecha"></asp:Button>
    <br />
    <br />
    <asp:Label ID="lblDateTime" runat="server" Text="Fecha"></asp:Label>
    </div>
    </form>
</body>
</html>
