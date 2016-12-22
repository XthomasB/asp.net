using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RecipeConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "Select count(*) from UserData where Username='"+ TextBoxUN.Text + "' ";
            SqlCommand comm = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(comm.ExecuteScalar().ToString());
            if (temp == 1)
            {
                Response.Write("User already exist");
            }
            conn.Close();


        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Guid newGuid = Guid.NewGuid();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RecipeConnectionString"].ConnectionString);
            conn.Open();
            string insertQuery = "insert into UserData (ID, Username, Password) values (@ID, @Uname, @password)";
            SqlCommand comm = new SqlCommand(insertQuery, conn);
            comm.Parameters.AddWithValue("@ID", newGuid.ToString());
            comm.Parameters.AddWithValue("@Uname", TextBoxUN.Text);
            comm.Parameters.AddWithValue("@password", TextBoxPass.Text);
            comm.ExecuteNonQuery();
            Response.Redirect("Admin.aspx");
            Response.Write("Registration is successful!");

            conn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("Error" + ex.ToString());
        }
    }
}