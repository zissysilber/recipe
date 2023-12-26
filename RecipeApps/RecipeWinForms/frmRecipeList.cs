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
        }


        private void BindData()
        {
            gRecipeSummary.DataSource = Recipe.GetRecipeSummary();
            WindowsFormUtility.FormatGridForSearchResults(gRecipeSummary);
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormUtility.IsFormOpen(frmtype);

            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }

                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }

                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }

                if (newfrm != null)
                {
                    
                    newfrm.MdiParent = this.ParentForm;
                    newfrm.WindowState = FormWindowState.Maximized;
                    //newfrm.FormClosed += Frm_FormClosed;
                    newfrm.Show();

                }
            }
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            //is this the parent fornm that we want it to be a child of? NO



            OpenForm(typeof(frmRecipe));
        }
        //private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        //{
        //   WindowsFormUtility.SetupNav();
        //}


    }
}
