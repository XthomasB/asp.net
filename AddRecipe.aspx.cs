using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4;

public partial class AddRecipe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void addButton_Click(object sender, EventArgs e)
    {
        Breakfast breakfast = new Breakfast();
        // when you use the using statment, the program automatically
        // opens the conection and closes it for you when it is finished
        // dont need to use try/catch to open/close the db connection
        using (RecipeContent db = new RecipeContent())
        {
            //breakfast.RecipeID = int.Parse(recIDTB.Text);
            breakfast.Name = nameTB.Text;
            breakfast.Category = cateIDTB.Text;
            breakfast.SubmittedBy = subIDTB.Text;
            breakfast.PrepareC =int.Parse(prepT.Text);
            breakfast.RecipeDec = desTB.Text;
            breakfast.Ingredients = ingTB.Text;
            breakfast.Qauntity = int.Parse(qaunTB.Text);

            

            db.Breakfasts.Add(breakfast);
            db.SaveChanges();
        }
        Response.Redirect("~/Home.aspx");
    }
}