using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Login_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RecipeConnectionString"].ConnectionString);
        conn.Open();
        string checkuser = "Select count(*) from UserData where Username='" + TextBoxUserName.Text + "' ";
        SqlCommand comm = new SqlCommand(checkuser, conn);
        int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
        conn.Close();
        if (temp == 1)
        {
            conn.Open();
            string checkPassowrd = "Select password from UserData where Username='" + TextBoxUserName.Text + "' ";
            SqlCommand passComm = new SqlCommand(checkPassowrd, conn);
            string password = passComm.ExecuteScalar().ToString().Replace(" ", "");
            if (password == TextBoxPassword.Text)
            {
                Session["New"] = TextBoxUserName.Text;
                Response.Write("Password is Correct");
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Password is Incorrect");
            }
            conn.Close();
        }
        else
        {
            Response.Write("Username is Incorrect");
        }
        
    }
}