using CPUFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "Select RecipeName, Calories, DateDrafted, DateArchived, DatePublished, RecipeImage, RecipeStatus from Recipe r where r.RecipeID = " + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);

            lblRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            lblCalories.DataBindings.Add("Text", dt, "Calories");
            lblDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            lblDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            lblDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            lblRecipeImage.DataBindings.Add("Text", dt, "RecipeImage");
            lblRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");

            this.Show();


        }
    }
}
