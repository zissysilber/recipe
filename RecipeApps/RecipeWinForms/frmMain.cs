﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuMealsList.Click += MnuMealsList_Click;
            mnuCookbookList.Click += MnuCookbooksList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuCookbookAutoCreate.Click += MnuCookbooksAutoCreate_Click;
            mnuMaintEditData.Click += MnuMaintEditData_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            this.Shown += FrmMain_Shown;
        }



        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
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

                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }

                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookDetail))
                {
                    frmCookbookDetail f = new();
                    newfrm = f;
                }

                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Frm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }

                WindowsFormUtility.SetupNav(tsMain);
            }
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }
        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormUtility.SetupNav(tsMain);
        }

        private void MnuMaintEditData_Click(object? sender, EventArgs e)
        {

        }

        private void MnuCookbooksAutoCreate_Click(object? sender, EventArgs e)
        {

        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookDetail));
        }

        private void MnuCookbooksList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }
        private void MnuMealsList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }
        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {

        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }




    }
}
