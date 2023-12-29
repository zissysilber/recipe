using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            this.Activated += FrmRecipeList_Activated;
            gRecipeSummary.CellDoubleClick += GRecipeSummary_CellDoubleClick;
            gRecipeSummary.KeyDown += GRecipeSummary_KeyDown;
            
        }



        private void BindData()
        {
            gRecipeSummary.DataSource = Recipe.GetRecipeSummary();
            WindowsFormUtility.FormatGridForSearchResults(gRecipeSummary);
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gRecipeSummary, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }


        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipeSummary_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gRecipeSummary.ColumnCount > 0)
            {
                ShowRecipeForm(gRecipeSummary.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GRecipeSummary_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

    }
}
