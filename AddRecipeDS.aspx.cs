using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4;

public partial class AddRecipeDS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void addButton_Click(object sender, EventArgs e)
    {
        Dinner dinner = new Dinner();
        // when you use the using statment, the program automatically
        // opens the conection and closes it for you when it is finished
        // dont need to use try/catch to open/close the db connection
        using (RecipeContent db = new RecipeContent())
        {
            //dinner.RecipeID = int.Parse(recIDTB.Text);
            dinner.Name = nameTB.Text;
            dinner.Category = cateIDTB.Text;
            dinner.SubmittedBy = subIDTB.Text;
            dinner.PrepareC = int.Parse(prepT.Text);
            dinner.RecipeDec = desTB.Text;
            dinner.Ingredients = ingTB.Text;
            dinner.Qauntity = int.Parse(qaunTB.Text);



            db.Dinners.Add(dinner);
            db.SaveChanges();
        }
        Response.Redirect("~/Home.aspx");
    }
}