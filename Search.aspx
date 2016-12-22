<%@ Page Title="Search" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Search.aspx.cs" Inherits="Search" %>

<%@ Register TagPrefix="formControl" TagName="FormInput" Src="FormInput.ascx" %>

<asp:Content ID="Search" ContentPlaceHolderID ="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" ></asp:Label>
    

    <%--Breakfast Search Bar and Table--%>
    <div class="col-md-5 col-md-push-4">
            <div class="h3 text-center">Search the BreakFast Recipe Book</div>
            <dl class="dl-horizontal">
                <asp:DropDownList ID="SearchName"  runat="server"></asp:DropDownList>

                <dt class="h3">Category:</dt>

                <dd>
                    <asp:DropDownList ID="CategoryR" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Enabled="true" Text="" Value="0" />
                        <asp:ListItem Enabled="true" Text="Breakfast" Value="1" />
                        <asp:ListItem Enabled="true" Text="Lunch" Value="2" />
                        <asp:ListItem Enabled="true" Text="Dinner" Value="3" />
                        <asp:ListItem Enabled="true" Text="Dessert" Value="4" />
                    </asp:DropDownList>
                </dd>
                <dd>
                   
                    <asp:DropDownList ID="SearchSub"  runat="server"></asp:DropDownList>

                    </dd>
                <dd>
                    <asp:Button ID="SearchButton" runat="server" text="Search Recipes" OnClick="SearchButton_Click" CssClass="btn btn-default pull-right" />
                </dd>
            </dl>
        </div>
    <br />

    <asp:GridView ID="SearchGridView" runat="server" OnRowDeleting="SearchsGridView_RowDeleting"
            DataKeyNames="RecipeID">
            <Columns>
                <asp:CommandField HeaderText="Delete Recipe" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    <br />


    <%--Lunch Search Bar and Table--%>
    <div class="col-md-5 col-md-push-4">
            <div class="h3 text-center">Search the Lunch Recipe Book</div>
            <dl class="dl-horizontal">
                <asp:DropDownList ID="LunchName"  runat="server"></asp:DropDownList>

                <dt class="h3">Category:</dt>

                <dd>
                    <asp:DropDownList ID="LunchCategory" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Enabled="true" Text="" Value="0" />
                        <asp:ListItem Enabled="true" Text="Breakfast" Value="1" />
                        <asp:ListItem Enabled="true" Text="Lunch" Value="2" />
                        <asp:ListItem Enabled="true" Text="Dinner" Value="3" />
                        <asp:ListItem Enabled="true" Text="Dessert" Value="4" />
                    </asp:DropDownList>
                </dd>
                <dd>
                   
                    <asp:DropDownList ID="LunchSub"  runat="server"></asp:DropDownList>

                    </dd>
                <dd>
                    <asp:Button ID="LunchSearch" runat="server" text="Search Recipes" OnClick="SearchLunch_Click" CssClass="btn btn-default pull-right" />
                </dd>
            </dl>
        </div>
    <br />

    <asp:GridView ID="LunchGrid" runat="server" OnRowDeleting="LunchSearchsGridView_RowDeleting"
            DataKeyNames="RecipeID">
            <Columns>
                <asp:CommandField HeaderText="Delete Recipe" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    <br />

    <%--Dinner Search Bar and Table--%>
    <div class="col-md-5 col-md-push-4">
            <div class="h3 text-center">Search the Dinner Recipe Book</div>
            <dl class="dl-horizontal">
                <asp:DropDownList ID="DinnerName"  runat="server"></asp:DropDownList>

                <dt class="h3">Category:</dt>

                <dd>
                    <asp:DropDownList ID="DinnerCategory" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Enabled="true" Text="" Value="0" />
                        <asp:ListItem Enabled="true" Text="Breakfast" Value="1" />
                        <asp:ListItem Enabled="true" Text="Lunch" Value="2" />
                        <asp:ListItem Enabled="true" Text="Dinner" Value="3" />
                        <asp:ListItem Enabled="true" Text="Dessert" Value="4" />
                    </asp:DropDownList>
                </dd>
                <dd>
                   
                    <asp:DropDownList ID="DinnerSUb"  runat="server"></asp:DropDownList>

                    </dd>
                <dd>
                    <asp:Button ID="DinnerSearch" runat="server" text="Search Recipes" OnClick="SearchDinner_Click" CssClass="btn btn-default pull-right" />
                </dd>
            </dl>
        </div>
    <br />

    <asp:GridView ID="DinnerGridse" runat="server" OnRowDeleting="DinnerSearchsGridView_RowDeleting"
            DataKeyNames="RecipeID">
            <Columns>
                <asp:CommandField HeaderText="Delete Recipe" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    <br />


    <%--Dessert Search Bar and Table--%>
    <div class="col-md-5 col-md-push-4">
            <div class="h3 text-center">Search the Dessert Recipe Book</div>
            <dl class="dl-horizontal">
                <asp:DropDownList ID="Dessertname"  runat="server"></asp:DropDownList>

                <dt class="h3">Category:</dt>

                <dd>
                    <asp:DropDownList ID="DessertCate" runat="server" CssClass="dropdown form-control">
                        <asp:ListItem Enabled="true" Text="" Value="0" />
                        <asp:ListItem Enabled="true" Text="Breakfast" Value="1" />
                        <asp:ListItem Enabled="true" Text="Lunch" Value="2" />
                        <asp:ListItem Enabled="true" Text="Dinner" Value="3" />
                        <asp:ListItem Enabled="true" Text="Dessert" Value="4" />
                    </asp:DropDownList>
                </dd>
                <dd>
                   
                    <asp:DropDownList ID="Dessertsub"  runat="server"></asp:DropDownList>

                    </dd>
                <dd>
                    <asp:Button ID="DessertSearch" runat="server" text="Search Recipes" OnClick="SearchDessert_Click" CssClass="btn btn-default pull-right" />
                </dd>
            </dl>
        </div>
    <br />

    <asp:GridView ID="DessertGrid" runat="server" OnRowDeleting="DessertSearchsGridView_RowDeleting"
            DataKeyNames="RecipeID">
            <Columns>
                <asp:CommandField HeaderText="Delete Recipe" ShowDeleteButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    <br />


</asp:Content>


