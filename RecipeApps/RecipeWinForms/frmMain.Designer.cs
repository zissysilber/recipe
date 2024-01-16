namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            mnuRecipe = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuNewRecipe = new ToolStripMenuItem();
            mnuCloneRecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealsList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuNewCookbook = new ToolStripMenuItem();
            mnuCookbookAutoCreate = new ToolStripMenuItem();
            mnuDataMaint = new ToolStripMenuItem();
            mnuMaintEditData = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            mnuWindowTile = new ToolStripMenuItem();
            mnuWindowCascade = new ToolStripMenuItem();
            tsMain = new ToolStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnuRecipe, mnuMeals, mnuCookbooks, mnuDataMaint, mnuWindow });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(695, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "&File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(156, 26);
            mnuDashboard.Text = "&Dashboard";
            // 
            // mnuRecipe
            // 
            mnuRecipe.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuNewRecipe, mnuCloneRecipe });
            mnuRecipe.Name = "mnuRecipe";
            mnuRecipe.Size = new Size(75, 25);
            mnuRecipe.Text = "&Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(182, 26);
            mnuRecipeList.Text = "&List";
            // 
            // mnuNewRecipe
            // 
            mnuNewRecipe.Name = "mnuNewRecipe";
            mnuNewRecipe.Size = new Size(182, 26);
            mnuNewRecipe.Text = "&New Recipe";
            // 
            // mnuCloneRecipe
            // 
            mnuCloneRecipe.Name = "mnuCloneRecipe";
            mnuCloneRecipe.Size = new Size(182, 26);
            mnuCloneRecipe.Text = "Cl&one a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealsList });
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(63, 25);
            mnuMeals.Text = "&Meals";
            // 
            // mnuMealsList
            // 
            mnuMealsList.Name = "mnuMealsList";
            mnuMealsList.Size = new Size(104, 26);
            mnuMealsList.Text = "Lis&t";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuNewCookbook, mnuCookbookAutoCreate });
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(100, 25);
            mnuCookbooks.Text = "&Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(187, 26);
            mnuCookbookList.Text = "Li&st";
            // 
            // mnuNewCookbook
            // 
            mnuNewCookbook.Name = "mnuNewCookbook";
            mnuNewCookbook.Size = new Size(187, 26);
            mnuNewCookbook.Text = "New Coo&kbook";
            // 
            // mnuCookbookAutoCreate
            // 
            mnuCookbookAutoCreate.Name = "mnuCookbookAutoCreate";
            mnuCookbookAutoCreate.Size = new Size(187, 26);
            mnuCookbookAutoCreate.Text = "A&uto-Create";
            // 
            // mnuDataMaint
            // 
            mnuDataMaint.DropDownItems.AddRange(new ToolStripItem[] { mnuMaintEditData });
            mnuDataMaint.Name = "mnuDataMaint";
            mnuDataMaint.Size = new Size(147, 25);
            mnuDataMaint.Text = "D&ata Maintenance";
            // 
            // mnuMaintEditData
            // 
            mnuMaintEditData.Name = "mnuMaintEditData";
            mnuMaintEditData.Size = new Size(142, 26);
            mnuMaintEditData.Text = "&Edit Data";
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { mnuWindowTile, mnuWindowCascade });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(80, 25);
            mnuWindow.Text = "&Window";
            // 
            // mnuWindowTile
            // 
            mnuWindowTile.Name = "mnuWindowTile";
            mnuWindowTile.Size = new Size(137, 26);
            mnuWindowTile.Text = "&Tile ";
            // 
            // mnuWindowCascade
            // 
            mnuWindowCascade.Name = "mnuWindowCascade";
            mnuWindowCascade.Size = new Size(137, 26);
            mnuWindowCascade.Text = "&Cascade";
            // 
            // tsMain
            // 
            tsMain.Location = new Point(0, 31);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(695, 25);
            tsMain.TabIndex = 3;
            tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 690);
            Controls.Add(tsMain);
            Controls.Add(menuStrip1);
            Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmMain";
            Text = "Hearty Hearth";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuRecipe;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealsList;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuCookbookAutoCreate;
        private ToolStripMenuItem mnuDataMaint;
        private ToolStripMenuItem mnuMaintEditData;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem mnuWindowTile;
        private ToolStripMenuItem mnuWindowCascade;
        private ToolStripMenuItem mnuDashboard;
        private ToolStrip tsMain;
    }
}