namespace RecipeWinForms
{
    public partial class frmCreateCookbook : Form
    {

        BindingSource bindsource = new();
        int newcookbookid = 0;

        public frmCreateCookbook()
        {
            InitializeComponent();
            BindDate();
            btnCreate.Click += BtnCreate_Click;
        }

        private void BindDate()
        {
            WindowsFormUtility.SetListBinding(lstUsersName, Users.GetUsersList(), null, "Users");
        }

        private void CreateCookbook()
        {
            int basedonuserid = WindowsFormUtility.GetIdFromComboBox(lstUsersName);
            this.Tag = basedonuserid;

            Cursor = Cursors.WaitCursor;
            try
            {
                DataTable newcookbook = Cookbook.CreateCookbookBasedOnUser(basedonuserid);
                newcookbookid = Cookbook.GetCookbookIdFromTable(newcookbook);
                DataTable dtcookbook = Cookbook.Load(newcookbookid);

                bindsource.DataSource = dtcookbook;

                LoadNewCookbookForm();
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

        private void LoadNewCookbookForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), newcookbookid);

                this.Close();
            }
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }


    }
}
