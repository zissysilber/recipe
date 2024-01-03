namespace RecipeWinForms
{
    public partial class frmCreateCookbook : Form
    {
        public frmCreateCookbook()
        {
            InitializeComponent();
            BindDate();
            btnCreate.Click += BtnCreate_Click;
        }

        private void BindDate()
        {
            
        }

        private void CreateCookbook()
        {

        }
        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }


    }
}
