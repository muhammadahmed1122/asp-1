<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="-" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click1" Text="*" />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="/" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click1" Text="sentific" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="root" />
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="log" />
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="tan" />
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="cos" />
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="max" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
