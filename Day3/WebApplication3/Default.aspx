﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%= DateTime.Now %><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default2.aspx">HyperLink</asp:HyperLink>
        </p>
    </form>
</body>
</html>
