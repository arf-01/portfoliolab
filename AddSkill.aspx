<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSkill.aspx.cs" Inherits="project1.AddSkill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Skill</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Add New Skill</h2>
            <asp:TextBox ID="SkillNameTextBox" runat="server" placeholder="Skill Name"></asp:TextBox>
            <asp:Button ID="AddSkillButton" runat="server" Text="Add Skill" OnClick="AddSkillButton_Click" />
        </div>
    </form>
</body>
</html>

