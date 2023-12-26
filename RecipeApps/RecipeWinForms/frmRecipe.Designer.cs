namespace RecipeWinForms
{
    partial class frmRecipe
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
            tblMain = new TableLayoutPanel();
            lblUser = new Label();
            lblCaptionCalories = new Label();
            lblCaptionCurrentStatus = new Label();
            lblCuisine = new Label();
            txtCalories = new TextBox();
            txtRecipeName = new TextBox();
            tblControl = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lstCuisineName = new ComboBox();
            lstUsersName = new ComboBox();
            label1 = new Label();
            txtDateDrafted = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tblRecipeTab = new TableLayoutPanel();
            tabPage2 = new TabPage();
            tblMain.SuspendLayout();
            tblControl.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.AutoSize = true;
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3677139F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.4080715F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6412563F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.762331F));
            tblMain.Controls.Add(lblUser, 1, 2);
            tblMain.Controls.Add(lblCaptionCalories, 1, 4);
            tblMain.Controls.Add(lblCaptionCurrentStatus, 1, 6);
            tblMain.Controls.Add(lblCuisine, 1, 3);
            tblMain.Controls.Add(txtCalories, 2, 4);
            tblMain.Controls.Add(txtRecipeName, 2, 1);
            tblMain.Controls.Add(tblControl, 1, 0);
            tblMain.Controls.Add(lstCuisineName, 2, 3);
            tblMain.Controls.Add(lstUsersName, 2, 2);
            tblMain.Controls.Add(label1, 1, 1);
            tblMain.Controls.Add(txtDateDrafted, 2, 6);
            tblMain.Controls.Add(tabControl1, 1, 7);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 13;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.02479362F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.82093668F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.68319559F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.096419F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.958678F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.030303F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.132231F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.860031F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.860031F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.132231F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.162534F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 39.9449043F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.860031F));
            tblMain.Size = new Size(1538, 726);
            tblMain.TabIndex = 0;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(293, 92);
            lblUser.Margin = new Padding(0, 6, 3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(257, 28);
            lblUser.TabIndex = 30;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = Color.White;
            lblCaptionCalories.Dock = DockStyle.Fill;
            lblCaptionCalories.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(299, 160);
            lblCaptionCalories.Margin = new Padding(6, 3, 2, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(252, 33);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCaptionCurrentStatus
            // 
            lblCaptionCurrentStatus.AutoSize = true;
            lblCaptionCurrentStatus.BackColor = Color.White;
            lblCaptionCurrentStatus.Dock = DockStyle.Fill;
            lblCaptionCurrentStatus.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCurrentStatus.Location = new Point(299, 218);
            lblCaptionCurrentStatus.Margin = new Padding(6, 3, 2, 0);
            lblCaptionCurrentStatus.Name = "lblCaptionCurrentStatus";
            lblCaptionCurrentStatus.Size = new Size(252, 27);
            lblCaptionCurrentStatus.TabIndex = 4;
            lblCaptionCurrentStatus.Text = "Current Status";
            lblCaptionCurrentStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCuisine
            // 
            lblCuisine.BackColor = Color.Transparent;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuisine.Location = new Point(299, 123);
            lblCuisine.Margin = new Padding(6, 3, 0, 0);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(254, 34);
            lblCuisine.TabIndex = 13;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.White;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(553, 157);
            txtCalories.Margin = new Padding(0);
            txtCalories.MinimumSize = new Size(0, 25);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(218, 31);
            txtCalories.TabIndex = 6;
            // 
            // txtRecipeName
            // 
            txtRecipeName.AcceptsReturn = true;
            txtRecipeName.BackColor = Color.FromArgb(188, 200, 135);
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.ForeColor = SystemColors.ControlText;
            txtRecipeName.Location = new Point(553, 51);
            txtRecipeName.Margin = new Padding(0);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(218, 31);
            txtRecipeName.TabIndex = 3;
            // 
            // tblControl
            // 
            tblControl.BackColor = Color.White;
            tblControl.ColumnCount = 4;
            tblMain.SetColumnSpan(tblControl, 2);
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblControl.Controls.Add(btnSave, 1, 0);
            tblControl.Controls.Add(btnDelete, 2, 0);
            tblControl.Dock = DockStyle.Fill;
            tblControl.Location = new Point(299, 3);
            tblControl.Margin = new Padding(6, 3, 6, 3);
            tblControl.Name = "tblControl";
            tblControl.RowCount = 1;
            tblControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControl.Size = new Size(466, 45);
            tblControl.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.White;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(119, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(235, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 39);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(553, 120);
            lstCuisineName.Margin = new Padding(0);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(218, 30);
            lstCuisineName.TabIndex = 5;
            // 
            // lstUsersName
            // 
            lstUsersName.Dock = DockStyle.Fill;
            lstUsersName.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsersName.FormattingEnabled = true;
            lstUsersName.Location = new Point(553, 86);
            lstUsersName.Margin = new Padding(0);
            lstUsersName.Name = "lstUsersName";
            lstUsersName.Size = new Size(218, 30);
            lstUsersName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(59, 74, 46);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(293, 51);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(260, 35);
            label1.TabIndex = 33;
            label1.Text = "       Recipe Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.BackColor = Color.White;
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Dock = DockStyle.Fill;
            txtDateDrafted.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(553, 215);
            txtDateDrafted.Margin = new Padding(0);
            txtDateDrafted.MinimumSize = new Size(0, 25);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(218, 31);
            txtDateDrafted.TabIndex = 7;
            // 
            // tabControl1
            // 
            tblMain.SetColumnSpan(tabControl1, 2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(296, 400);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(472, 285);
            tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblRecipeTab);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(464, 257);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblRecipeTab
            // 
            tblRecipeTab.ColumnCount = 2;
            tblRecipeTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeTab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeTab.Dock = DockStyle.Fill;
            tblRecipeTab.Location = new Point(3, 3);
            tblRecipeTab.Name = "tblRecipeTab";
            tblRecipeTab.RowCount = 2;
            tblRecipeTab.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0579147F));
            tblRecipeTab.RowStyles.Add(new RowStyle(SizeType.Percent, 84.9420853F));
            tblRecipeTab.Size = new Size(458, 251);
            tblRecipeTab.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(464, 256);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 726);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe Info";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblControl.ResumeLayout(false);
            tblControl.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionCalories;
        private Label lblCaptionCurrentStatus;
        private TableLayoutPanel tblControl;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox lstCuisineName;
        private ComboBox lstUsersName;
        private TextBox txtCalories;
        private TextBox txtRecipeName;
        private Label lblUser;
        private Label lblCuisine;
        private Label label1;
        private TextBox txtDateDrafted;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tblRecipeTab;
        private TabPage tabPage2;
    }
}