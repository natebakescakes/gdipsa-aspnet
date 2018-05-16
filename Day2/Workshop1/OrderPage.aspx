<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="Workshop1.OrderPage" %>

<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="../../../../favicon.ico">

    <title>FoodBrenda</title>

    <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />

    <!-- Custom styles for this template -->
    <link href="Content/starter-template.css" rel="stylesheet">
</head>

<body>
    <nav class="navbar navbar-expand-md navbar-dark bg-dark fixed-top">
        <a class="navbar-brand" href="#">FoodBrenda</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault" aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>

        <div class="collapse navbar-collapse" id="navbarsExampleDefault">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <asp:HyperLink ID="OrderFormLink" class="nav-link" runat="server" NavigateUrl="~/OrderPage.aspx">Order Form</asp:HyperLink>
                </li>
                <li class="nav-item">
                    <asp:HyperLink ID="OrderSummaryLink" class="nav-link" runat="server" NavigateUrl="~/OrderSummary.aspx">View All Orders</asp:HyperLink>
                </li>
            </ul>
        </div>
    </nav>

    <div class="page-header align">
        <h1>Order Form</h1>
    </div>

    <main role="main" class="container">
        <form id="form2" runat="server">
            <div class="row">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
                    <asp:Label ID="Label5" runat="server" Text="Dish"></asp:Label>
                    <asp:DropDownList ID="DishDropDownList" runat="server"></asp:DropDownList>
                </div>
                <div class="col-lg-4"></div>
            </div>
            <div class="row">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
                    <asp:Label ID="Label6" runat="server" Text="Size"></asp:Label>
                    <asp:DropDownList ID="SizeDropDownList" runat="server"></asp:DropDownList>
                </div>
                <div class="col-lg-4"></div>
            </div>
            <div class="row">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
                    <asp:Label ID="Label7" runat="server" Text="Options"></asp:Label>
                    <asp:RadioButtonList ID="OptionRadioButtonList" runat="server"></asp:RadioButtonList>
                </div>
                <div class="col-lg-4"></div>
            </div>
            <div class="row">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
                    <asp:Label ID="Label8" runat="server" Text="User ID"></asp:Label>
                    <asp:TextBox ID="UserIdTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-4"></div>
            </div>
            <div class="row">
                <div class="col-lg-4"></div>
                <div class="col-lg-4">
                    <asp:Button ID="Button2" class="btn-primary" runat="server" Text="Order Now" OnClick="Button1_Click" />
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Back to Home</asp:HyperLink>
                </div>
                <div class="col-lg-4"></div>
            </div>
        </form>
    </main>
    <!-- /.container -->

    <!-- Bootstrap core JavaScript
	================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery-slim.min.js"><\/script>')</script>
    <script src="../../assets/js/vendor/popper.min.js"></script>
    <script src="../../dist/js/bootstrap.min.js"></script>
</body>
</html>
