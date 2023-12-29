﻿using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNewCookbook.Click += BtnNewCookbook_Click;
            this.Activated += FrmCookbookList_Activated;
        }

        private void BindData()
        {
            gCookbook.DataSource = Cookbook.GetCookbookSummary();
            WindowsFormUtility.FormatGridForSearchResults(gCookbook);
        }


        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {

        }
    }
}
