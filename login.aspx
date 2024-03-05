<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="project1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Admin Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Admin Login</h2>
            <div>
                <label for="email">Email:</label>
                <input type="text" id="email" name="email" runat="server" />
            </div>
            <div>
                <label for="password">Password:</label>
                <input type="password" id="password" name="password" runat="server" />
            </div>
            <div>
                <asp:Button ID="submitButton" runat="server" Text="Login" OnClick="Button1_Click" />
            </div>
            <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
