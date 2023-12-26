using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace RecipeWinForms
{
    public class FormManagement
    {
        
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

                    //newfrm.MdiParent = this.ParentForm;
                    //frmMain frm = ParentForm
                    //newfrm.WindowState = FormWindowState.Maximized;
                    //newfrm.FormClosed += Frm_FormClosed;
                    newfrm.Show();

                }
            }
        }
    }
}
