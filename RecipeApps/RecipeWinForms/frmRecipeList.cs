﻿namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gRecipeSummary.CellDoubleClick += GRecipeSummary_CellDoubleClick;
            gRecipeSummary.KeyDown += GRecipeSummary_KeyDown;
            this.Activated += FrmRecipeList_Activated;
        }


        private void BindData()
        {
            gRecipeSummary.DataSource = Recipe.GetRecipeSummary();
            WindowsFormUtility.FormatGridForSearchResults(gRecipeSummary);
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gRecipeSummary, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {

                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), id);
            }
        }


        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipeSummary_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipeSummary.ColumnCount > 0)
            {
                ShowRecipeForm(gRecipeSummary.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GRecipeSummary_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }
         
    }
}
