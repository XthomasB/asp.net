using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Part of adding to a table
    protected void AddRecipeButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddRecipe.aspx");
    }

    protected void AddRecipeLButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddRecipeL.aspx");
    }

    protected void AddRecipeDButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddRecipeD.aspx");
    }

    protected void AddRecipDSButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddRecipeDS.aspx");
    }
}