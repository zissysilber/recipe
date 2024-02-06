using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
	}

    private void SearchRecipe()
    {
        DataTable dt = Recipe.SearchRecipeByName(RecipeNameTxt.Text);
        RecipeLst.ItemsSource = dt.Rows;

    }
    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipe();
    }


}