using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment4;
public partial class AddRecipeD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void addButton_Click(object sender, EventArgs e)
    {
        Dessert dessert = new Dessert();
        // when you use the using statment, the program automatically
        // opens the conection and closes it for you when it is finished
        // dont need to use try/catch to open/close the db connection
        using (RecipeContent db = new RecipeContent())
        {
            //dessert.RecipeID = int.Parse(recIDTB.Text);
            dessert.Name = nameTB.Text;
            dessert.Category = cateIDTB.Text;
            dessert.SubmittedBy = subIDTB.Text;
            dessert.PrepareC = int.Parse(prepT.Text);
            dessert.RecipeDec = desTB.Text;
            dessert.Ingredients = ingTB.Text;
            dessert.Qauntity = int.Parse(qaunTB.Text);



            db.Desserts.Add(dessert);
            db.SaveChanges();
        }
        Response.Redirect("~/Home.aspx");
    }
}