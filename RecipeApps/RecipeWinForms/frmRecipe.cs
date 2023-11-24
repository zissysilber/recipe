
using CPUFramework;
using CPUWindowsFormFramework;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {

        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            DataTable dtusers = SQLUtility.GetDataTable("select UserID, UserName from Users");
            DataTable dtcuisine = SQLUtility.GetDataTable("select CuisineID, CuisineName from Cuisine");
            string recipesql = "select r.*, c.CuisineName, u.UserName from Recipe r join Users u on r.UserID = u.UserID join Cuisine c on r.CuisineID = c.CuisineID  where r.RecipeID = " + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(recipesql);

            if (recipeid == 0)
            {
                //dtusers.Rows.Add();
                //dtcuisine.Rows.Add();
                dtrecipe.Rows.Add();

            }

            lstUserName.DataSource = dtusers;
            lstUserName.ValueMember = "UserID";
            lstUserName.DisplayMember = "UserName";
            lstUserName.DataBindings.Add("SelectedValue", dtrecipe, lstUserName.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);

            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDateArchived, dtrecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblRecipeImage, dtrecipe);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, dtrecipe);


            this.Show();

        }


        private void Save()
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeID"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"UserID = '{r["UserID"]}',",
                    $"CuisineID = '{r["CuisineID"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateDrafted= '{r["DateDrafted"]}',",
                    $"DatePublished = '{r["DatePublished"]}',",
                    $"DateArchived= '{r["DateArchived"]}'",
                    $"where RecipeID = {r["RecipeID"]} ");
            }
            else
            {
                sql = "insert Recipe(UserID, CuisineID, RecipeName, Calories, DateDrafted, DateArchived, DatePublished)";
                sql += $"select '{r["UserID"]}', '{r["CuisineID"]}','{r["RecipeName"]}',{r["Calories"]},'{r["DateDrafted"]}','{r["DateArchived"]}','{r["DatePublished"]}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            string sql = "delete recipe where RecipeID = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
    }
}
