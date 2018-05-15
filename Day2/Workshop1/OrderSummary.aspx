<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderSummary.aspx.cs" Inherits="Workshop1.OrderSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Order Summary</h1>
        <asp:PlaceHolder ID="OrderPlaceHolder" runat="server"></asp:PlaceHolder>
        <br />
        <asp:HyperLink ID="BackButton" runat="server" NavigateUrl="~/Home.aspx">Back to Home</asp:HyperLink>
    </form>
</body>
</html>