namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {


        BindingSource bindsource = new();

        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;

        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();
        }

        private void BindData()
        {
            WindowsFormUtility.SetListBinding(lstRecipeName, DataMaintenance.GetDataList("Recipe", true), null, "Recipe");
        }

        private void CloneRecipe()
        {

            int basedonrecipeid = WindowsFormUtility.GetIdFromComboBox(lstRecipeName);
            int newrecipeid = 0;
            this.Tag = basedonrecipeid;
            DataTable dtrecipe = new();
            DataTable clonedrecipe = new();
            Cursor = Cursors.WaitCursor;
            try
            {
                //See if can move this to Clone class?
                clonedrecipe = Recipe.CloneRecipe(basedonrecipeid);
                newrecipeid = Recipe.GetRecipeIdFromTable(clonedrecipe);
                dtrecipe = Recipe.GetRecipeById(newrecipeid);
                bindsource.DataSource = dtrecipe;

                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), newrecipeid);

                    this.Close();
                }
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

    }
}
