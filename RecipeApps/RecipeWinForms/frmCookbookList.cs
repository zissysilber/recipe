namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookbook.CellDoubleClick += GCookbook_CellDoubleClick;
            gCookbook.KeyDown += GCookbook_KeyDown;
            this.Activated += FrmCookbookList_Activated;
        }




        private void BindData()
        {
            gCookbook.DataSource = Cookbook.GetCookbookSummary();
            WindowsFormUtility.FormatGridForSearchResults(gCookbook);
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gCookbook, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {

                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), id);
            }
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void GCookbook_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gCookbook.ColumnCount > 0)
            {
                ShowCookbookForm(gCookbook.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }
    }
}
