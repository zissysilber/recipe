﻿using System.Data;


namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            WindowsFormUtility.FormatGridForSearchResults(gRecipe);
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
        }

        private void SearchForRecipe(string recipename)
        {
            DataTable dt = Recipe.SearchRecipes(recipename);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
            gRecipe.Columns["CuisineId"].Visible = false;
            gRecipe.Columns["UsersId"].Visible = false;
            gRecipe.Columns["Calories"].Visible = false;
            gRecipe.Columns["DateDrafted"].Visible = false;
            gRecipe.Columns["DatePublished"].Visible = false;
            gRecipe.Columns["DateArchived"].Visible = false;
            gRecipe.Columns["RecipeStatus"].Visible = false;
            gRecipe.Columns["RecipeImage"].Visible = false;


        }

        private void ShowRecipeForm(int rowindex)
        {
            int Id = 0;
            if (rowindex > -1)
            {
                Id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new frmRecipe();
            frm.LoadForm(Id);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipe.Text);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
