using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;

        }

        private void OpenForm(Type frmtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                if (frmtype == typeof(frmRecipeList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                }
                else if (frmtype == typeof(frmMealList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
                }

            }
        }

        private void BindData()
        {
            gSummary.DataSource = DatabaseMaintenance.GetDatabaseSummary();
            WindowsFormUtility.FormatGridForSearchResults(gSummary, "Summary");
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
    }
}
