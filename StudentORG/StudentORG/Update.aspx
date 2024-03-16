<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="StudentORG.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    </td>
         </tr>
     </table>
 </form>
</body>
</html>
