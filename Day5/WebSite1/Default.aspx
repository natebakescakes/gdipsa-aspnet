<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <%= DateTime.Now %>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <%= DateTime.Now %>
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <%= DateTime.Now %>
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
                    <br />
                    <asp:Timer ID="Timer1" runat="server" Interval="5000">
                    </asp:Timer>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button2" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    Updating...
                </ProgressTemplate>
            </asp:UpdateProgress>
            <br />
        </div>
    </form>
</body>
</html>
