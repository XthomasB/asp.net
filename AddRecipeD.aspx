<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddRecipeD.aspx.cs" Inherits="AddRecipeD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--Adds new RecipeID
        <asp:Label ID="Label1" runat="server" Text="RecipeID"></asp:Label>
        <asp:TextBox ID="recIDTB" runat="server"></asp:TextBox>
        <br />--%>

        
         <asp:Label ID="Label5" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator" runat="server" ControlToValidate="nameTB" ErrorMessage="Name Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
                <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
        <asp:TextBox ID="cateIDTB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator0" runat="server" ControlToValidate="cateIDTB" ErrorMessage="Category Name Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

                <asp:Label ID="Label3" runat="server" Text="Submitted By"></asp:Label>
        <asp:TextBox ID="subIDTB" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator1" runat="server" ControlToValidate="subIDTB" ErrorMessage="Name Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
              <asp:Label ID="Label7" runat="server" Text="Preare Time"></asp:Label>
        <asp:TextBox ID="prepT" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator2" runat="server" ControlToValidate="prepT" ErrorMessage="TIme Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
          <asp:Label ID="Label6" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="desTB" runat="server"  TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator3" runat="server" ControlToValidate="desTB" ErrorMessage=" Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
          <asp:Label ID="Label4" runat="server" Text="Ingredients"></asp:Label>
        <asp:TextBox ID="ingTB" runat="server" TextMode="MultiLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator4" runat="server" ControlToValidate="ingTB" ErrorMessage="Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Qauntity"></asp:Label>
        <asp:TextBox ID="qaunTB" runat="server" TextMode="Number"></asp:TextBox>
        <asp:RequiredFieldValidator ID="NameFieldValidator5" runat="server" ControlToValidate="qaunTB" ErrorMessage="Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

        <asp:Button ID="addButton" runat="server" Text="Add Dinner" OnClick="addButton_Click" />        
    </div>
    </form>
</body>
</html>
