using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {

        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipedirection = new();
        BindingSource bindsource = new();

        string deletecolumnname = "deletecolumn";
        int recipeid = 0;

        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            btnDirectionSave.Click += BtnDirectionSave_Click;
            this.Shown += FrmRecipe_Shown;
            this.FormClosing += FrmRecipe_FormClosing;
            gDirection.CellContentClick += GDirection_CellContentClick;
            gIngredient.CellContentClick += GIngredient_CellContentClick;
            gIngredient.DataError += GIngredient_DataError;
        }



        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;

            dtrecipe = Recipe.GetRecipeById(recipeid);
            bindsource.DataSource = dtrecipe;

            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
                SetButtonsEnabledBasedOnNewRecord();
            }

            DataTable dtusers = Users.GetUsersList();
            DataTable dtcuisine = Recipe.GetCuisineList();
            WindowsFormUtility.SetListBinding(lstUsersName, dtusers, dtrecipe, "Users");
            WindowsFormUtility.SetListBinding(lstCuisineName, dtcuisine, dtrecipe, "Cuisine");
            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);

            this.Text = GetRecipeDesc();

        }

        private void LoadIngredientDetails()
        {
            dtrecipeingredient = RecipeDetail.LoadIngredientByRecipeId(recipeid);

            gIngredient.Columns.Clear();
            gIngredient.DataSource = dtrecipeingredient;

            WindowsFormUtility.AddComboboxToGrid(gIngredient, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementName");
            WindowsFormUtility.FormatGridForEdit(gIngredient, "Measurement");
            WindowsFormUtility.AddComboboxToGrid(gIngredient, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormUtility.FormatGridForEdit(gIngredient, "Ingredient");
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredient, deletecolumnname);
        }

        private void LoadDirectionDetails()
        {
            dtrecipedirection = RecipeDetail.LoadRecipeDirectionByRecipeId(recipeid);
            gDirection.Columns.Clear();
            gDirection.DataSource = dtrecipedirection;
            WindowsFormUtility.AddDeleteButtonToGrid(gDirection, deletecolumnname);
            WindowsFormUtility.FormatGridForEdit(gDirection, "RecipeDirection");
        }


        public void LoadChangeStatusForm(int recipeid)
        {
            int id = recipeid;

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), id);
            }
        }
        private void Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
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

        private void SaveRecipeIngredient()
        {
            Application.UseWaitCursor = true;
            try
            {
                RecipeDetail.SaveRecipeIngredientTable(dtrecipeingredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveRecipeDirection()
        {
            Application.UseWaitCursor = true;
            try
            {
                RecipeDetail.SaveRecipeDirectionTable(dtrecipedirection, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", Application.ProductName, MessageBoxButtons.YesNo);
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

        private void DeleteRecipeDetail(int rowIndex, Control tabname)
        {
            DataGridView grid = gIngredient;
            string columnname = "RecipeIngredientId" ;
            if (tabname == tbDirection)
            {
                grid = gDirection;
                columnname = "RecipeDirectionId";
            }


            int id = WindowsFormUtility.GetIdFromGrid(grid, rowIndex, columnname);
            if (id > 0)
            {
                try
                {
                    if (tabname == tbIngredient)
                    {
                        RecipeDetail.DeleteRecipeIngredientRow(id);
                        LoadIngredientDetails();
                    }
                    else
                    {
                        RecipeDetail.DeleteRecipeDirectionRow(id);
                        LoadDirectionDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < grid.Rows.Count)
            {
                grid.Rows.RemoveAt(rowIndex);
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnIngredientsSave.Enabled = b;
            btnDirectionSave.Enabled = b;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }
        private void PromptToSave(DataTable dt, FormClosingEventArgs e)
        {
            bindsource.EndEdit();

            if (SQLUtility.TableHasChanges(dt))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = false;
                        try
                        {
                            Recipe.Save(dtrecipe);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, Application.ProductName);
                        }
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            PromptToSave(dtrecipe, e);
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {

            LoadChangeStatusForm(recipeid);
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnDirectionSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeDirection();
        }

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            LoadIngredientDetails();
            LoadDirectionDetails();

        }

        private void GIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeDetail(e.RowIndex, tbIngredient);

        }

        private void GDirection_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeDetail(e.RowIndex, tbDirection);
        }

        private void GIngredient_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Sorry. Content is not valid.", Application.ProductName);
        }
    }
}
