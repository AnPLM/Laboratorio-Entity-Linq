﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClienteSelect.aspx.vb" Inherits="UI.ClienteSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div align="center">
            <h2>Clientes</h2>
            <br />
            <br />
            <br />
        </div>
   
        
         <div align="center">
             <asp:GridView ID="grdClientes" runat="server"></asp:GridView>
     </div>

    </form>
</body>
</html>
