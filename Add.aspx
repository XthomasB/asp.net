<%@ Page TItle="Add" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Add.aspx.cs" Inherits="Add" %>


  <%@ Register TagPrefix="formControl" TagName="FormInput" Src="FormInput.ascx" %>


<asp:Content ID="Add" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="Label1" runat="server" ></asp:Label>
    <div id="txtholder" runat="server">
        <div class="col-md-5 col-md-push-4">
            <div class="h3 text-center">Add Your Recipe</div>
            <dl class="dl-horizontal">
                <dd/>
                <asp:Button ID="AddRecipeButton" runat="server" Text="Add New BreakFast Recipe" OnClick="AddRecipeButton_Click" />
                <dd />
                <asp:Button ID="AddRecipeL" runat="server" Text="Add New Lunch Recipe" OnClick="AddRecipeLButton_Click"/>
                <dd />

                <asp:Button ID="AddRecipeD" runat="server" Text="Add New Dinner Recipe" OnClick="AddRecipeDButton_Click"/>
                <dd />
                
                <asp:Button ID="AddRecipeDS" runat="server" Text="Add New Dessert Recipe" OnClick="AddRecipDSButton_Click"/>
           
                 </dl>
        </div>
    </div>
</asp:Content>
