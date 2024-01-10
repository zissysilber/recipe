namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Users, Cuisine, Ingredient, Measurement, Course }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Users;
        string deletecol = "deletecolumn";

        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            SetupRadioButtons();
            BindData(currenttabletype);
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmDataMaintenance_FormClosing;
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormUtility.AddDeleteButtonToGrid(gData, deletecol);
            WindowsFormUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;

        }

        private void Delete(int rowindex)
        {
            int id = WindowsFormUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                if (currenttabletype == TableTypeEnum.Users)
                {
                    var response = MessageBox.Show("Are you sure you want to delete this user and all related recipes, meals and cookbooks?", Application.ProductName, MessageBoxButtons.YesNo);
                    if (response == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    var response = MessageBox.Show($"Are you sure you want to delete this {currenttabletype}?", Application.ProductName, MessageBoxButtons.YesNo);
                    if (response == DialogResult.No)
                    {
                        return;
                    }
                }
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptionButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEnum.Users;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optMeasurement.Tag = TableTypeEnum.Measurement;
            optCourse.Tag = TableTypeEnum.Course;
        }
        private void PromptToSave(DataTable dt, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dt))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = false;
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

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            PromptToSave(dtlist, e);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecol)
            {
                Delete(e.RowIndex);
            }
        }

    }
}
