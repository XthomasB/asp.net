<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recipe Login </title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 213px;
        }
        .auto-style3 {
            width: 213px;
            text-align: right;
        }
        .auto-style4 {
            width: 194px;
        }
        .auto-style5 {
            width: 194px;
            text-align: left;
        }
        .auto-style6 {
            width: 213px;
            text-align: right;
            height: 26px;
        }
        .auto-style7 {
            width: 194px;
            text-align: left;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style6">Username:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxUN" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUN" ErrorMessage="Username Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Password:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPass" ErrorMessage="Password Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">Confirm Password:</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBoxRPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxRPass" ErrorMessage="Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxRPass" ErrorMessage="Password Must Match" ForeColor="Red"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                    <input id="Reset1" class="auto-style9" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>