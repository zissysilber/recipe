﻿namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {

        private enum ChangeStatusButtonEnum { Draft, Publish, Archive }
        int recipeid = 0;

        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        public frmChangeStatus()
        {
            InitializeComponent();
            btnArchive.Click += BtnArchive_Click;
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
        }
        //test
        public void LoadForm(int pkvalue)
        {
            recipeid = pkvalue;
            this.Tag = recipeid;

            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;

            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);

            SetButtonsEnabledBasedOnStatus();

            this.Text += " - " + GetRecipeDesc();

        }

        private void ChangeRecipeStatus(ChangeStatusButtonEnum statusbutton)
        {

            string changestatus = "";
            string messagebox = "";
            switch (statusbutton)
            {
                case ChangeStatusButtonEnum.Draft:
                    changestatus = "DateDrafted";
                    messagebox = "Drafted";
                    break;

                case ChangeStatusButtonEnum.Publish:
                    changestatus = "DatePublished";
                    messagebox = "Published";
                    break;

                case ChangeStatusButtonEnum.Archive:
                    changestatus = "DateArchived";
                    messagebox = "Archived";
                    break;
            }

            var response = MessageBox.Show("Are you sure you want to change this recipe to " + messagebox + "?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            try
            {
                Recipe.UpdateStatus(dtrecipe, changestatus);
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                SetButtonsEnabledBasedOnStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }
        private void SetButtonsEnabledBasedOnStatus()
        {

            foreach (Button btn in tblButton.Controls)
            {
                btn.Enabled = true;
            }

            switch (dtrecipe.Rows[0]["RecipeStatus"])
            {

                case "Drafted":
                    btnDraft.Enabled = false;
                    break;
                case "Published":
                    btnPublish.Enabled = false;
                    break;
                case "Archived":
                    btnArchive.Enabled = false;
                    break;
            }
        }
        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(ChangeStatusButtonEnum.Draft);
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(ChangeStatusButtonEnum.Archive);
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus(ChangeStatusButtonEnum.Publish);
        }






    }
}
