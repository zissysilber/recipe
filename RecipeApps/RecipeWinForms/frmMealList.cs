﻿namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            this.Activated += FrmMealList_Activated;
        }

        private void BindData()
        {
            gMeal.DataSource = Meal.GetMealSummary();
            WindowsFormUtility.FormatGridForSearchResults(gMeal);
        }


        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

    }
}
