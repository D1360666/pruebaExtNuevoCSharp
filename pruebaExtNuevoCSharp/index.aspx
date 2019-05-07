<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="pruebaExtNuevoCSharp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.js"></script>
    <link href="Scripts/ol.css" rel="stylesheet" />
    <script src="Scripts/ol.js"></script>
</head>
<body>
    <form id="form1" runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre" for="txtNombre"></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Apellido" for="txtApellido"></asp:Label>
            <asp:TextBox ID="txtApellido" runat="server" class="form-control"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Dirección"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" class="form-control"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Teléfono"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" class="form-control"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" class="btn btn-primary"/>

        </div>
        <div id="Map">

        </div>
    </form>
    <script src="Scripts/map.js"></script>
</body>
</html>
