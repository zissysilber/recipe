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
            this.Activated += FrmCookbookDetail_Activated;
            this.FormClosing += FrmCookbookDetail_FormClosing;
            gCookbookDetail.CellContentClick += GCookbookDetail_CellContentClick;
            gCookbookDetail.DataError += GCookbookDetail_DataError;
            this.Shown += FrmCookbookDetail_Shown;
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
        }

        private void LoadCookbookRecipe()
        {
            dtcookbookrecipe = Cookbook.LoadRecipebyCookbookId(cookbookid);
            gCookbookDetail.Columns.Clear();
            gCookbookDetail.DataSource = dtcookbookrecipe;

            WindowsFormUtility.AddComboboxToGrid(gCookbookDetail, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormUtility.FormatGridForEdit(gCookbookDetail, "Recipe");
            WindowsFormUtility.AddDeleteButtonToGrid(gCookbookDetail, deletecol);
        }

        private bool Save()
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
            return b;
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
                Cookbook.Delete(dtcookbook);
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

        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gCookbookDetail, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    Cookbook.DeleteCookbookRecipe(id);
                    LoadCookbookRecipe();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gCookbookDetail.Rows.Count)
            {
                gCookbookDetail.Rows.RemoveAt(rowIndex);
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

        private void FrmCookbookDetail_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipe();
            //WindowsFormUtility.AddDeleteButtonToGrid(gCookbookDetail, deletecol);

        }
        private void FrmCookbookDetail_Activated(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void FrmCookbookDetail_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();

            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = true;
                        try
                        {
                            b = Save();
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

        private void GCookbookDetail_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }
        private void GCookbookDetail_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Sorry. Content is not valid.", Application.ProductName);
        }

    }
}
