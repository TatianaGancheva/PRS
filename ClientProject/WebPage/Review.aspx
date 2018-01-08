<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Review.aspx.cs" Inherits="ClientProject.WebPage.Review" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
         #form1 {
            width: 776px;
            height: 501px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />
         <asp:Label ID="lbl" runat="server" Width="400 " Font-Bold Font-Italic Font-Size="X-Large" Text="Student " style="margin-left: 264px"/>
        <br />
        <br />
        <asp:Label Text="Name: " width="90px" runat="server"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" Width="200px"></asp:TextBox>
        <br />
        <asp:Label Text="Age: " runat="server" width="90px"></asp:Label>
        <asp:TextBox ID="txtAge" runat="server" Width="201px"></asp:TextBox>
        <br />
        <asp:Label Text="Course: " runat="server" Width="90px"></asp:Label>
        <asp:TextBox ID="txtCourse" runat="server" Width="200px"></asp:TextBox>
        <br />
        <asp:Label Text="Class: " runat="server" Width="90px"></asp:Label>
        <asp:TextBox ID="txtClass" runat="server" Width="200px"></asp:TextBox>
        <br />
        <asp:Label Text="Average Mark: " runat="server" Width="90px"></asp:Label>
        <asp:TextBox ID="txtAverageMark" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnRefresh" runat="server" Text="Refresh" Width="86px" OnClick="btnRefresh_Click" />
        <asp:Button ID="btnAddNew" runat="server" style="margin-left: 48px" Text="Add new Student " Width="115px" OnClick="btnAddNew_Click" />
      


    </form>
</body>
</html>
