namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        BindingSource bindsource = new();
        int newrecipeid = 0;

        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstRecipeName, Recipe.GetRecipeList(), null, "Recipe");
        }

        private void CloneRecipe()
        {

            int basedonrecipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeName);
            this.Tag = basedonrecipeid;

            Cursor = Cursors.WaitCursor;
            try
            {
                DataTable clonedrecipe = Recipe.CloneRecipeBasedOnId(basedonrecipeid);
                newrecipeid = Recipe.GetRecipeIdFromTable(clonedrecipe);
                DataTable dtrecipe = Recipe.Load(newrecipeid);
                bindsource.DataSource = dtrecipe;

                LoadClonedRecipeForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadClonedRecipeForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), newrecipeid);

                this.Close();
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }

    }
}
