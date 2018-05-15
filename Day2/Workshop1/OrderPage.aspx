<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="Workshop1.OrderPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Order Form</h1>
        <asp:Label ID="Label1" runat="server" Text="Dish"></asp:Label>
        <asp:DropDownList ID="DishDropDownList" runat="server">
        </asp:DropDownList>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Size"></asp:Label>
            <asp:DropDownList ID="SizeDropDownList" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Options"></asp:Label>
        <asp:RadioButtonList ID="OptionRadioButtonList" runat="server">
        </asp:RadioButtonList>
        <p>
            <asp:Label ID="Label4" runat="server" Text="User ID"></asp:Label>
            <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Order Now" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:HyperLink ID="BackLink" runat="server" NavigateUrl="~/Home.aspx">Back to Home</asp:HyperLink>
        </p>
    </form>
</body>
</html>
