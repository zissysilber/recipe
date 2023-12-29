﻿using CPUFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {

        DataTable dtrecipe = new DataTable();
        DataTable dtrecipeusers = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipesteps = new();
        BindingSource bindsource = new BindingSource();

        string deletecolumnname = "deletecolumn";
        int recipeid = 0;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            btnStepsSave.Click += BtnStepsSave_Click;
            this.Shown += FrmRecipe_Shown;
        }



        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
                      
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
           
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }

            DataTable dtusers = Recipe.GetUsersList();
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
          
            LoadIngredientDetails();
            LoadStepsDetails();

            SetButtonsEnabledBasedOnNewRecord();

        }

        private void LoadIngredientDetails()
        {
            dtrecipeingredient = RecipeDetail.LoadIngredientByRecipeId(recipeid);

            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;

            WindowsFormUtility.AddComboboxToGrid(gIngredients, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementName");
            WindowsFormUtility.FormatGridForEdit(gIngredients, "Measurement");
            WindowsFormUtility.AddComboboxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormUtility.FormatGridForEdit(gIngredients, "Ingredient");
        }

        private void LoadStepsDetails()
        {
            dtrecipesteps = RecipeDetail.LoadRecipeDirectionByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtrecipesteps;
            WindowsFormUtility.AddDeleteButtonToGrid(gSteps, deletecolumnname);
            WindowsFormUtility.FormatGridForEdit(gSteps, "RecipeDirection");
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
            try
             {
                RecipeDetail.SaveRecipeIngredientTable(dtrecipeingredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
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

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnIngredientsSave.Enabled = b;
            btnStepsSave.Enabled = b;
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

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            
        }

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }



        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            WindowsFormUtility.AddDeleteButtonToGrid(gIngredients, deletecolumnname);

        }
    }
}
