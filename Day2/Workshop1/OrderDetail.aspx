<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="Workshop1.OrderDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Order Detail</h1>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Order ID"></asp:Label>
            &nbsp;<asp:Label ID="OrderIdLabel" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="User ID"></asp:Label>
            <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dish"></asp:Label>
            <asp:TextBox ID="DishTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Size"></asp:Label>
            <asp:TextBox ID="SizeTextBox" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Options"></asp:Label>
        </p>
        <asp:RadioButtonList ID="OptionRadioButtonList" runat="server">
        </asp:RadioButtonList>
        <asp:HyperLink ID="BackButton" runat="server" NavigateUrl="~/OrderSummary.aspx">Back to Home</asp:HyperLink>
    </form>
</body>
</html>
