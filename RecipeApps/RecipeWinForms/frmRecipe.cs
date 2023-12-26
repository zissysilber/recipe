namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {

        DataTable dtrecipe = new DataTable();
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }



        public void LoadForm(int recipeidval)
        {
            DataTable dtusers = Recipe.GetUsersList();
            DataTable dtcuisine = Recipe.GetCuisineList();
            recipeid = recipeidval;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }

            WindowsFormUtility.SetListBinding(lstUsersName, dtusers, dtrecipe, "Users");
            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateDrafted, bindsource);

            this.Text = dtrecipe.Rows[0]["RecipeName"].ToString();
            this.Show();
        }


        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                bindsource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

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
