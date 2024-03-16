<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="StudentORG.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
            width: 1185px;
        }
        .auto-style3 {
            width: 100px;
        }
        .auto-style4 {
            height: 23px;
            width: 100px;
        }
        .auto-style5 {
            width: 1185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style4">First Name</td>
                <td class="auto-style2" id="txtFname">
                    <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Last Name</td>
                <td class="auto-style5" id="txtLname">
                    <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Contact</td>
                <td class="auto-style2" id="txtContact">
                    <asp:TextBox ID="txtContact" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Email</td>
                <td class="auto-style5" id="txtEmail">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td class="auto-style3">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnCreate" runat="server" Text="Save" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>