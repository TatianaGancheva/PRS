<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllStudents.aspx.cs" Inherits="ClientProject.AllStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <asp:Label ID="lbl" runat="server" Width="400" Font-Bold Font-Size="Large" Text="Students" style="margin-left:264px" />
        <br />
        <br />
        <asp:Label ID="lbl2" runat="server" Text="Search for Student:" Height="16px" style="margin-left:0px; margin-top: 0px" Width="115px" Font-Bold></asp:Label>
        <asp:TextBox ID="searching" runat="server" Width="129px" Height="16px" style="margin-left: 12px"></asp:TextBox>
        <asp:DropDownList ID="DropDown" runat="server">
            <asp:ListItem Enabled="true" Text="Search by: " Value="1"></asp:ListItem>
            <asp:ListItem Text="Name" Value="name"></asp:ListItem>
            <asp:ListItem Text="Classes" Value="classes"></asp:ListItem>
            
        </asp:DropDownList>
        <br />
        <br />
        <asp:ListView ID="names" runat="server"  OnSelectedIndexChanging="names_SelectedIndexChanging" OnSelectedIndexChanged="names_SelectedIndexChanged">
        <LayoutTemplate>
           <table runat="server" id="tblCategories" 
                 cellspacing="0" cellpadding="1" width="440px" border="1">
            <tr id="itemPlaceholder" runat="server"></tr>
          </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr runat="server">
                    <td>
                   <asp:LinkButton ID="btnSel" runat="server" Text="Select" CommandName="Select"/>
                    </td>
                    <td style="width:300px">
                        <asp:Label ID="lblSel" Text="<%#Container.DataItem%>" runat="server"/>
                    </td>
                 </tr>
        </ItemTemplate>
         <SelectedItemTemplate>
                <tr runat="server" style="background-color:#90EE90">
                     
                   <td>&nbsp;</td>
                    <td style="width:300px">
                        <asp:Label ID="Label1" Text="<%#Container.DataItem%>" runat="server"/>
                    </td>
                </tr>
            </SelectedItemTemplate>
        </asp:ListView>
        <br />
         <asp:Label ID="lblErr" runat="server" ForeColor="Red" Font-Bold></asp:Label>
        <br />
        <br />

      
        <asp:Button ID="btnSrch" runat="server" Text="Search" Width="90px" OnClick="btnSrc_Click" Font-Bold/>

      
        <asp:Button ID="btnDelete" runat="server" style="margin-left: 29px" Text="Delete" Width="100px" OnClick="btnDelete_Click" Font-Bold />

      
        <asp:Button ID="btnOvrvw" runat="server" style="margin-left: 34px" Text="View Details" Width="100px" OnClick="btnOvrvw_Click" Font-Bold />

    </form>
</body>
</html>
