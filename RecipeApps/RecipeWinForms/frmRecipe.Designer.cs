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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lblChef = new Label();
            lblCaptionCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeImage = new Label();
            lblCaptionRecipeStatus = new Label();
            lblCuisine = new Label();
            txtCalories = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeName = new TextBox();
            tblControl = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            lstCuisineName = new ComboBox();
            lstUsersName = new ComboBox();
            lblRecipeImage = new Label();
            label1 = new Label();
            lblRecipeStatus = new Label();
            txtDateDrafted = new TextBox();
            tblMain.SuspendLayout();
            tblControl.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 340F));
            tblMain.Controls.Add(lblChef, 0, 2);
            tblMain.Controls.Add(lblCaptionCalories, 0, 4);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 6);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipeImage, 0, 8);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 9);
            tblMain.Controls.Add(lblCuisine, 0, 3);
            tblMain.Controls.Add(txtCalories, 1, 4);
            tblMain.Controls.Add(txtDatePublished, 1, 6);
            tblMain.Controls.Add(txtDateArchived, 1, 7);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(tblControl, 0, 10);
            tblMain.Controls.Add(lstCuisineName, 1, 3);
            tblMain.Controls.Add(lstUsersName, 1, 2);
            tblMain.Controls.Add(lblRecipeImage, 1, 8);
            tblMain.Controls.Add(label1, 0, 1);
            tblMain.Controls.Add(lblRecipeStatus, 1, 9);
            tblMain.Controls.Add(txtDateDrafted, 1, 5);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 12;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 10.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9726028F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.2328768F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tblMain.Size = new Size(498, 448);
            tblMain.TabIndex = 0;
            // 
            // lblChef
            // 
            lblChef.AutoSize = true;
            lblChef.Dock = DockStyle.Fill;
            lblChef.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblChef.Location = new Point(3, 65);
            lblChef.Name = "lblChef";
            lblChef.Size = new Size(152, 39);
            lblChef.TabIndex = 30;
            lblChef.Text = "Chef";
            lblChef.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = Color.White;
            lblCaptionCalories.Dock = DockStyle.Fill;
            lblCaptionCalories.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(6, 143);
            lblCaptionCalories.Margin = new Padding(6, 0, 2, 0);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(150, 39);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.BackColor = Color.White;
            lblCaptionDateDrafted.Dock = DockStyle.Fill;
            lblCaptionDateDrafted.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(6, 182);
            lblCaptionDateDrafted.Margin = new Padding(6, 0, 2, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(150, 39);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            lblCaptionDateDrafted.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.BackColor = Color.White;
            lblCaptionDatePublished.Dock = DockStyle.Fill;
            lblCaptionDatePublished.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(6, 221);
            lblCaptionDatePublished.Margin = new Padding(6, 0, 2, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(150, 39);
            lblCaptionDatePublished.TabIndex = 6;
            lblCaptionDatePublished.Text = "Date Published";
            lblCaptionDatePublished.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.BackColor = Color.White;
            lblCaptionDateArchived.Dock = DockStyle.Fill;
            lblCaptionDateArchived.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(6, 260);
            lblCaptionDateArchived.Margin = new Padding(6, 0, 2, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(150, 39);
            lblCaptionDateArchived.TabIndex = 8;
            lblCaptionDateArchived.Text = "Date Archived";
            lblCaptionDateArchived.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCaptionRecipeImage
            // 
            lblCaptionRecipeImage.AutoSize = true;
            lblCaptionRecipeImage.BackColor = Color.White;
            lblCaptionRecipeImage.Dock = DockStyle.Fill;
            lblCaptionRecipeImage.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeImage.Location = new Point(6, 299);
            lblCaptionRecipeImage.Margin = new Padding(6, 0, 2, 0);
            lblCaptionRecipeImage.Name = "lblCaptionRecipeImage";
            lblCaptionRecipeImage.Size = new Size(150, 39);
            lblCaptionRecipeImage.TabIndex = 10;
            lblCaptionRecipeImage.Text = "Recipe Image";
            lblCaptionRecipeImage.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.BackColor = Color.White;
            lblCaptionRecipeStatus.Dock = DockStyle.Fill;
            lblCaptionRecipeStatus.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(6, 338);
            lblCaptionRecipeStatus.Margin = new Padding(6, 0, 2, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(150, 51);
            lblCaptionRecipeStatus.TabIndex = 12;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            lblCaptionRecipeStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCuisine
            // 
            lblCuisine.BackColor = Color.White;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuisine.Location = new Point(6, 104);
            lblCuisine.Margin = new Padding(6, 0, 2, 0);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(150, 39);
            lblCuisine.TabIndex = 13;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.White;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(158, 143);
            txtCalories.Margin = new Padding(0, 0, 6, 0);
            txtCalories.MinimumSize = new Size(0, 25);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(317, 31);
            txtCalories.TabIndex = 6;
            // 
            // txtDatePublished
            // 
            txtDatePublished.BackColor = Color.White;
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDatePublished.Location = new Point(158, 221);
            txtDatePublished.Margin = new Padding(0, 0, 6, 0);
            txtDatePublished.MinimumSize = new Size(0, 25);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.ReadOnly = true;
            txtDatePublished.Size = new Size(317, 31);
            txtDatePublished.TabIndex = 8;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left;
            txtDateArchived.BackColor = Color.White;
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateArchived.Location = new Point(158, 264);
            txtDateArchived.Margin = new Padding(0, 0, 6, 0);
            txtDateArchived.MinimumSize = new Size(0, 25);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.ReadOnly = true;
            txtDateArchived.Size = new Size(317, 31);
            txtDateArchived.TabIndex = 9;
            // 
            // txtRecipeName
            // 
            txtRecipeName.AcceptsReturn = true;
            txtRecipeName.Anchor = AnchorStyles.Left;
            txtRecipeName.BackColor = Color.FromArgb(188, 200, 135);
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.ForeColor = SystemColors.ControlText;
            txtRecipeName.Location = new Point(158, 24);
            txtRecipeName.Margin = new Padding(0, 3, 6, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(317, 31);
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
            tblControl.Location = new Point(6, 392);
            tblControl.Margin = new Padding(6, 3, 6, 3);
            tblControl.Name = "tblControl";
            tblControl.RowCount = 1;
            tblControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblControl.Size = new Size(486, 35);
            tblControl.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.White;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(124, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(245, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(158, 107);
            lstCuisineName.Margin = new Padding(0, 3, 3, 3);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(317, 30);
            lstCuisineName.TabIndex = 5;
            // 
            // lstUsersName
            // 
            lstUsersName.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsersName.FormattingEnabled = true;
            lstUsersName.Location = new Point(158, 68);
            lstUsersName.Margin = new Padding(0, 3, 3, 3);
            lstUsersName.Name = "lstUsersName";
            lstUsersName.Size = new Size(317, 30);
            lstUsersName.TabIndex = 4;
            // 
            // lblRecipeImage
            // 
            lblRecipeImage.AutoSize = true;
            lblRecipeImage.Dock = DockStyle.Fill;
            lblRecipeImage.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeImage.Location = new Point(161, 299);
            lblRecipeImage.Name = "lblRecipeImage";
            lblRecipeImage.Size = new Size(334, 39);
            lblRecipeImage.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(59, 74, 46);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(3, 24);
            label1.Margin = new Padding(3, 9, 0, 10);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 33;
            label1.Text = "       Recipe Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(161, 338);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(334, 51);
            lblRecipeStatus.TabIndex = 34;
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.BackColor = Color.White;
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDrafted.Location = new Point(158, 182);
            txtDateDrafted.Margin = new Padding(0, 0, 6, 0);
            txtDateDrafted.MinimumSize = new Size(0, 25);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.ReadOnly = true;
            txtDateDrafted.Size = new Size(317, 31);
            txtDateDrafted.TabIndex = 7;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 448);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRecipe";
            Text = "Recipe Info";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblControl.ResumeLayout(false);
            tblControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionCalories;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeImage;
        private Label lblCaptionRecipeStatus;
        private TextBox txtChef;
        private TableLayoutPanel tblControl;
        private Button btnSave;
        private Button btnDelete;
        private ComboBox lstCuisineName;
        private ComboBox lstUsersName;
        private TextBox txtCalories;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeName;
        private Label lblChef;
        private Label lblCuisine;
        private Label lblRecipeImage;
        private Label label1;
        private Label lblRecipeStatus;
        private TextBox txtDateDrafted;
    }
}