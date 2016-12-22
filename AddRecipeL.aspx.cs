using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4;

public partial class AddRecipeL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void addButton_Click(object sender, EventArgs e)
    {
        Lunch lunch = new Lunch();
        // when you use the using statment, the program automatically
        // opens the conection and closes it for you when it is finished
        // dont need to use try/catch to open/close the db connection
        using (RecipeContent db = new RecipeContent())
        {
            //lunch.RecipeID = int.Parse(recIDTB.Text);
            lunch.Name = nameTB.Text;
            lunch.Category = cateIDTB.Text;
            lunch.SubmittedBy = subIDTB.Text;
            lunch.PrepareC = int.Parse(prepT.Text);
            lunch.RecipeDec = desTB.Text;
            lunch.Ingredients = ingTB.Text;
            lunch.Qauntity = int.Parse(qaunTB.Text);



            db.Lunches.Add(lunch);
            db.SaveChanges();
        }
        Response.Redirect("~/Home.aspx");
    }
}