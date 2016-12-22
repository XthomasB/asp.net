using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Assignment4;
public partial class Search : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=centennialrecipe.database.windows.net;Initial Catalog=Recipe;Persist Security Info=True;User ID=RecipeComp229;Password=Recipe229;MultipleActiveResultSets=True;Application Name=EntityFramework");

            try
            {

                string sql = "SELECT * FROM information_schema.tables WHERE TABLE_TYPE='BASE TABLE'";
                SqlCommand sqCommand = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = sqCommand.ExecuteReader();
                CategoryR.DataSource = reader;
                CategoryR.DataTextField = "";
                CategoryR.DataValueField = "";
                CategoryR.DataBind();
                con.Close();
            }
            catch (SqlException ex)
            {
                Label1.Text = ex.Message;
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }

            
            // BreakFast GRIDVIEW STARTS HERE ============================
            using (RecipeContent db = new RecipeContent())
            {
                //SearchGridView.DataSource = db.Breakfasts.ToList();
                //SearchGridView.DataBind();

                SearchName.DataSource = (from em in db.Breakfasts
                                              select em.Name).ToList();
                SearchName.DataBind();

                CategoryR.DataSource = (from em in db.Breakfasts
                                      select em.Category).ToList();
                CategoryR.DataBind();

                SearchSub.DataSource = (from em in db.Breakfasts
                                       select em.SubmittedBy).ToList();
                SearchSub.DataBind();
            }

            // Lunch GRIDVIEW STARTS HERE ============================
            using (RecipeContent db = new RecipeContent())
            {
                //LunchGrid.DataSource = db.Lunches.ToList();
                //LunchGrid.DataBind();

                LunchName.DataSource = (from em in db.Lunches
                                        select em.Name).ToList();
                LunchName.DataBind();

                LunchCategory.DataSource = (from em in db.Lunches
                                            select em.Category).ToList();
                LunchCategory.DataBind();

                LunchSub.DataSource = (from em in db.Lunches
                                        select em.SubmittedBy).ToList();
                LunchSub.DataBind();
            }

            // Dinner GRIDVIEW STARTS HERE ============================
            using (RecipeContent db = new RecipeContent())
            {
                //DinnerGridse.DataSource = db.Dinners.ToList();
                //DinnerGridse.DataBind();

                DinnerName.DataSource = (from em in db.Dinners
                                        select em.Name).ToList();
                DinnerName.DataBind();

                DinnerCategory.DataSource = (from em in db.Dinners
                                            select em.Category).ToList();
                DinnerCategory.DataBind();

                DinnerSUb.DataSource = (from em in db.Dinners
                                       select em.SubmittedBy).ToList();
                DinnerSUb.DataBind();
            }

            // Dessert GRIDVIEW STARTS HERE ============================
            using (RecipeContent db = new RecipeContent())
            {
                //DessertGrid.DataSource = db.Desserts.ToList();
                //DessertGrid.DataBind();

                Dessertname.DataSource = (from em in db.Desserts
                                         select em.Name).ToList();
                Dessertname.DataBind();

                DessertCate.DataSource = (from em in db.Desserts
                                             select em.Category).ToList();
                DessertCate.DataBind();

                Dessertsub.DataSource = (from em in db.Desserts
                                        select em.SubmittedBy).ToList();
                Dessertsub.DataBind();
            }

        }

    }
    //Search bar tab index > 
    //protected void CategoryR_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    //Retrieves the new page index
    //    int newPageIndex = e.NewPageIndex;
    //    //set the new page index
    //    CategoryR.PageIndex = newPageIndex;
    //    bindGrid();
    //}

    //Deleting rows from the BreakFast table
    protected void SearchsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            int selectedRow = e.RowIndex;

            int recID = Convert.ToInt32(SearchGridView.DataKeys[selectedRow].Values["RecipeID"]);

            Breakfast breakfast = (from Breakfasts in db.Breakfasts
                                   where Breakfasts.RecipeID == recID
                                 select Breakfasts).FirstOrDefault();
            db.Breakfasts.Remove(breakfast);
            db.SaveChanges();
        }
    }

    //Deleting rows from the Lunch table
    protected void LunchSearchsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            int selectedRow = e.RowIndex;

            int recID = Convert.ToInt32(LunchGrid.DataKeys[selectedRow].Values["RecipeID"]);

            Lunch lunch = (from lunches in db.Lunches
                           where lunches.RecipeID == recID
                                   select lunches).FirstOrDefault();
            db.Lunches.Remove(lunch);
            db.SaveChanges();
        }
    }

    //Deleting rows from the Dinner table
    protected void DinnerSearchsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            int selectedRow = e.RowIndex;

            int recID = Convert.ToInt32(DinnerGridse.DataKeys[selectedRow].Values["RecipeID"]);

            Dinner dinner = (from Dinners in db.Dinners
                           where Dinners.RecipeID == recID
                           select Dinners).FirstOrDefault();
            db.Dinners.Remove(dinner);
            db.SaveChanges();
        }
    }

    //Deleting rows from the Dessert table
    protected void DessertSearchsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            int selectedRow = e.RowIndex;

            int recID = Convert.ToInt32(DessertGrid.DataKeys[selectedRow].Values["RecipeID"]);

            Dessert dessert = (from Dessert in db.Desserts
                               where Dessert.RecipeID == recID
                             select Dessert).FirstOrDefault();
            db.Desserts.Remove(dessert);
            db.SaveChanges();
        }
    }


    //search buttong for Breakfast
    protected void SearchButton_Click(object sender, EventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            string Name = SearchName.SelectedValue;
            string Category = CategoryR.SelectedValue;
            string SubmittedBy = SearchSub.SelectedValue;

            List<Breakfast> food = (from allBreakfasts in db.Breakfasts
                                   where allBreakfasts.Name == Name
                                   &&
                                   allBreakfasts.Category == Category
                                   &&
                                   allBreakfasts.SubmittedBy == SubmittedBy
                                    select allBreakfasts).ToList();

            SearchGridView.DataSource = food;
            SearchGridView.DataBind();
        }
    }

    //search buttong for lunch
    protected void SearchLunch_Click(object sender, EventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            string Name = LunchName.SelectedValue;
            string Category = LunchCategory.SelectedValue;
            string SubmittedBy = LunchSub.SelectedValue;

            List<Lunch> LunchFood = (from allLunches in db.Lunches
                                    where allLunches.Name == Name
                                    &&
                                    allLunches.Category == Category
                                    &&
                                    allLunches.SubmittedBy == SubmittedBy
                                    select allLunches).ToList();

            LunchGrid.DataSource = LunchFood;
            LunchGrid.DataBind();
        }
    }

    //search buttong for dinner
    protected void SearchDinner_Click(object sender, EventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            string Name = DinnerName.SelectedValue;
            string Category = DinnerCategory.SelectedValue;
            string SubmittedBy = DinnerSUb.SelectedValue;

            List<Dinner> dinerfood = (from allDinner in db.Dinners
                                     where allDinner.Name == Name
                                     &&
                                     allDinner.Category == Category
                                     &&
                                     allDinner.SubmittedBy == SubmittedBy
                                     select allDinner).ToList();

            DinnerGridse.DataSource = dinerfood;
            DinnerGridse.DataBind();
        }
    }


    //search buttong for Dessert
    protected void SearchDessert_Click(object sender, EventArgs e)
    {
        using (RecipeContent db = new RecipeContent())
        {
            string Name = Dessertname.SelectedValue;
            string Category = DessertCate.SelectedValue;
            string SubmittedBy = Dessertsub.SelectedValue;

            List<Dessert> desFood = (from allDessert in db.Desserts
                                      where allDessert.Name == Name
                                      &&
                                      allDessert.Category == Category
                                      &&
                                      allDessert.SubmittedBy == SubmittedBy
                                      select allDessert).ToList();

            DessertGrid.DataSource = desFood;
            DessertGrid.DataBind();
        }
    }

}

