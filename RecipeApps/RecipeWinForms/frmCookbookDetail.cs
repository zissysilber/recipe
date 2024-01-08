using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmCookbookDetail : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new();

        int cookbookid = 0;
        string deletecol = "deletecolumn";

        public frmCookbookDetail()
        {

            InitializeComponent();
            btnCookbookSave.Click += BtnCookbookSave_Click;
            btnCookbookDelete.Click += BtnCookbookDelete_Click;
            btnCookbookDetailSave.Click += BtnCookbookDetailSave_Click;
            this.Shown += FrmCookbookDetail_Shown;
            this.Activated += FrmCookbookDetail_Activated;

        }


        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;

            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
                SetButtonsEnabledBasedOnNewRecord();
            }

            DataTable dtusers = Users.GetUsersList();
            WindowsFormUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormUtility.SetListBinding(lstUsersName, dtusers, dtcookbook, "Users");
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(cbxIsActive, bindsource);
            this.Text = GetCookbookDesc();

            LoadCookbookRecipe();

        }

        private void LoadCookbookRecipe()
        {
            dtcookbookrecipe = Cookbook.LoadRecipebyCookbookId(cookbookid);
            gCookbookDetail.Columns.Clear();
            gCookbookDetail.DataSource = dtcookbookrecipe;

            WindowsFormUtility.AddComboboxToGrid(gCookbookDetail, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormUtility.FormatGridForEdit(gCookbookDetail, "Recipe");
        }
        private void Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveCookbookRecipe()
        {
            try
            {
                Cookbook.SaveCookbookRecipeTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

        }
        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }



        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnCookbookDelete.Enabled = b;
            btnCookbookDetailSave.Enabled = b;
        }
        public void BindData()
        {
            LoadCookbookRecipe();
        }

        private void FrmCookbookDetail_Shown(object? sender, EventArgs e)
        {
            WindowsFormUtility.AddDeleteButtonToGrid(gCookbookDetail, deletecol);

        }
        private void FrmCookbookDetail_Activated(object? sender, EventArgs e)
        {
            //Why is it coming in not maximized that makes this necessary?
            this.WindowState = FormWindowState.Maximized;
            BindData();

        }
        private void BtnCookbookDetailSave_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void BtnCookbookDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnCookbookSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


    }
}
