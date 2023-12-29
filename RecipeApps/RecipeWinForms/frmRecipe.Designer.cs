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
            tblButtons = new TableLayoutPanel();
            btnDelete = new Button();
            btnSave = new Button();
            btnChangeStatus = new Button();
            tblRecipeInfo = new TableLayoutPanel();
            txtCalories = new TextBox();
            lstCuisineName = new ComboBox();
            lstUsersName = new ComboBox();
            lblUser = new Label();
            txtRecipeName = new TextBox();
            lblRecipeName = new Label();
            lblCuisine = new Label();
            lblCalories = new Label();
            tblRecipeStatus = new TableLayoutPanel();
            lblRecipeStatus = new Label();
            lblRecipeStatusLabel = new Label();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            tbRecipeDetails = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnIngredientsSave = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnStepsSave = new Button();
            gSteps = new DataGridView();
            lblName = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            tableLayoutPanel6 = new TableLayoutPanel();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            tblRecipeInfo.SuspendLayout();
            tblRecipeStatus.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbRecipeDetails.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tblMain.Controls.Add(tblButtons, 1, 1);
            tblMain.Controls.Add(tblRecipeInfo, 1, 3);
            tblMain.Controls.Add(tblRecipeStatus, 1, 5);
            tblMain.Controls.Add(tbRecipeDetails, 1, 7);
            tblMain.Controls.Add(lblName, 3, 2);
            tblMain.Controls.Add(label1, 3, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 124F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 14F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 90F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(847, 699);
            tblMain.TabIndex = 1;
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 5;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.29607F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.4533663F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.6132622F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6304646F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.13117F));
            tblButtons.Controls.Add(btnDelete, 0, 0);
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnChangeStatus, 4, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(65, 22);
            tblButtons.Margin = new Padding(3, 4, 3, 4);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(689, 38);
            tblButtons.TabIndex = 43;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(94, 4);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 31);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.BackColor = Color.White;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(3, 4);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 31);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Dock = DockStyle.Fill;
            btnChangeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeStatus.Location = new Point(531, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(155, 33);
            btnChangeStatus.TabIndex = 4;
            btnChangeStatus.Text = "&Change Status...";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // tblRecipeInfo
            // 
            tblRecipeInfo.ColumnCount = 2;
            tblRecipeInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.09128F));
            tblRecipeInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.90872F));
            tblRecipeInfo.Controls.Add(txtCalories, 1, 4);
            tblRecipeInfo.Controls.Add(lstCuisineName, 1, 3);
            tblRecipeInfo.Controls.Add(lstUsersName, 1, 2);
            tblRecipeInfo.Controls.Add(lblUser, 0, 2);
            tblRecipeInfo.Controls.Add(txtRecipeName, 1, 1);
            tblRecipeInfo.Controls.Add(lblRecipeName, 0, 1);
            tblRecipeInfo.Controls.Add(lblCuisine, 0, 3);
            tblRecipeInfo.Controls.Add(lblCalories, 0, 4);
            tblRecipeInfo.Dock = DockStyle.Fill;
            tblRecipeInfo.Location = new Point(65, 85);
            tblRecipeInfo.Margin = new Padding(3, 4, 3, 4);
            tblRecipeInfo.Name = "tblRecipeInfo";
            tblRecipeInfo.RowCount = 5;
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.RowStyles.Add(new RowStyle());
            tblRecipeInfo.Size = new Size(689, 116);
            tblRecipeInfo.TabIndex = 0;
            // 
            // txtCalories
            // 
            txtCalories.BackColor = Color.White;
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCalories.Location = new Point(241, 87);
            txtCalories.Margin = new Padding(0);
            txtCalories.MinimumSize = new Size(2, 25);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(448, 29);
            txtCalories.TabIndex = 41;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Dock = DockStyle.Fill;
            lstCuisineName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(241, 58);
            lstCuisineName.Margin = new Padding(0);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(448, 29);
            lstCuisineName.TabIndex = 39;
            // 
            // lstUsersName
            // 
            lstUsersName.Dock = DockStyle.Fill;
            lstUsersName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsersName.FormattingEnabled = true;
            lstUsersName.Location = new Point(241, 29);
            lstUsersName.Margin = new Padding(0);
            lstUsersName.Name = "lstUsersName";
            lstUsersName.Size = new Size(448, 29);
            lstUsersName.TabIndex = 37;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(0, 37);
            lblUser.Margin = new Padding(0, 8, 3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(238, 21);
            lblUser.TabIndex = 36;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtRecipeName
            // 
            txtRecipeName.AcceptsReturn = true;
            txtRecipeName.BackColor = Color.FromArgb(188, 200, 135);
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipeName.ForeColor = SystemColors.ControlText;
            txtRecipeName.Location = new Point(241, 0);
            txtRecipeName.Margin = new Padding(0);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(448, 29);
            txtRecipeName.TabIndex = 35;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.FromArgb(59, 74, 46);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.ForeColor = SystemColors.HighlightText;
            lblRecipeName.Location = new Point(0, 0);
            lblRecipeName.Margin = new Padding(0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(241, 29);
            lblRecipeName.TabIndex = 34;
            lblRecipeName.Text = "       Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuisine.Location = new Point(3, 58);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(235, 29);
            lblCuisine.TabIndex = 42;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCalories
            // 
            lblCalories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalories.Location = new Point(3, 87);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(235, 29);
            lblCalories.TabIndex = 43;
            lblCalories.Text = "Calories";
            lblCalories.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblRecipeStatus
            // 
            tblRecipeStatus.ColumnCount = 2;
            tblRecipeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tblRecipeStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tblRecipeStatus.Controls.Add(lblRecipeStatus, 1, 0);
            tblRecipeStatus.Controls.Add(lblRecipeStatusLabel, 0, 0);
            tblRecipeStatus.Controls.Add(lblStatusDates, 0, 1);
            tblRecipeStatus.Controls.Add(tblStatusDates, 1, 1);
            tblRecipeStatus.Dock = DockStyle.Fill;
            tblRecipeStatus.Location = new Point(65, 222);
            tblRecipeStatus.Name = "tblRecipeStatus";
            tblRecipeStatus.RowCount = 3;
            tblRecipeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.720932F));
            tblRecipeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 31.39535F));
            tblRecipeStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblRecipeStatus.Size = new Size(689, 84);
            tblRecipeStatus.TabIndex = 44;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = Color.FromArgb(188, 200, 135);
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatus.ForeColor = SystemColors.ActiveCaptionText;
            lblRecipeStatus.Location = new Point(241, 0);
            lblRecipeStatus.Margin = new Padding(0);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(448, 28);
            lblRecipeStatus.TabIndex = 39;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRecipeStatusLabel
            // 
            lblRecipeStatusLabel.AutoSize = true;
            lblRecipeStatusLabel.BackColor = Color.FromArgb(59, 74, 46);
            lblRecipeStatusLabel.Dock = DockStyle.Fill;
            lblRecipeStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatusLabel.ForeColor = SystemColors.HighlightText;
            lblRecipeStatusLabel.Location = new Point(0, 0);
            lblRecipeStatusLabel.Margin = new Padding(0);
            lblRecipeStatusLabel.Name = "lblRecipeStatusLabel";
            lblRecipeStatusLabel.Size = new Size(241, 28);
            lblRecipeStatusLabel.TabIndex = 35;
            lblRecipeStatusLabel.Text = "Recipe Status";
            lblRecipeStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 28);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(235, 26);
            lblStatusDates.TabIndex = 37;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblPublished, 1, 0);
            tblStatusDates.Controls.Add(lblArchived, 2, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 1);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 1);
            tblStatusDates.Controls.Add(lblDateArchived, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(241, 28);
            tblStatusDates.Margin = new Padding(0);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblRecipeStatus.SetRowSpan(tblStatusDates, 2);
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(448, 56);
            tblStatusDates.TabIndex = 38;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(0, 0);
            lblDrafted.Margin = new Padding(0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(149, 28);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.BorderStyle = BorderStyle.FixedSingle;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(149, 0);
            lblPublished.Margin = new Padding(0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(149, 28);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.BorderStyle = BorderStyle.FixedSingle;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(298, 0);
            lblArchived.Margin = new Padding(0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(150, 28);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.WhiteSmoke;
            lblDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(0, 28);
            lblDateDrafted.Margin = new Padding(0);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(149, 28);
            lblDateDrafted.TabIndex = 3;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.WhiteSmoke;
            lblDatePublished.BorderStyle = BorderStyle.FixedSingle;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(149, 28);
            lblDatePublished.Margin = new Padding(0);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(149, 28);
            lblDatePublished.TabIndex = 4;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.WhiteSmoke;
            lblDateArchived.BorderStyle = BorderStyle.FixedSingle;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(298, 28);
            lblDateArchived.Margin = new Padding(0);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(150, 28);
            lblDateArchived.TabIndex = 5;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbRecipeDetails
            // 
            tbRecipeDetails.Controls.Add(tbIngredients);
            tbRecipeDetails.Controls.Add(tbSteps);
            tbRecipeDetails.Dock = DockStyle.Fill;
            tbRecipeDetails.Location = new Point(65, 329);
            tbRecipeDetails.Name = "tbRecipeDetails";
            tbRecipeDetails.SelectedIndex = 0;
            tbRecipeDetails.Size = new Size(689, 309);
            tbRecipeDetails.TabIndex = 45;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 29);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(681, 276);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(btnIngredientsSave, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tblIngredients.Size = new Size(675, 270);
            tblIngredients.TabIndex = 0;
            // 
            // btnIngredientsSave
            // 
            btnIngredientsSave.AutoSize = true;
            btnIngredientsSave.Location = new Point(3, 3);
            btnIngredientsSave.Name = "btnIngredientsSave";
            btnIngredientsSave.Size = new Size(50, 30);
            btnIngredientsSave.TabIndex = 0;
            btnIngredientsSave.Text = "S&ave";
            btnIngredientsSave.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.BackgroundColor = Color.White;
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 39);
            gIngredients.Name = "gIngredients";
            gIngredients.RowTemplate.Height = 25;
            gIngredients.Size = new Size(669, 228);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tblSteps);
            tbSteps.Location = new Point(4, 24);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(681, 281);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnStepsSave, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tblSteps.Size = new Size(675, 275);
            tblSteps.TabIndex = 1;
            // 
            // btnStepsSave
            // 
            btnStepsSave.AutoSize = true;
            btnStepsSave.Location = new Point(3, 3);
            btnStepsSave.Name = "btnStepsSave";
            btnStepsSave.Size = new Size(103, 30);
            btnStepsSave.TabIndex = 0;
            btnStepsSave.Text = "S&ave";
            btnStepsSave.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = Color.White;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 39);
            gSteps.Name = "gSteps";
            gSteps.RowTemplate.Height = 25;
            gSteps.Size = new Size(669, 233);
            gSteps.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(188, 200, 135);
            lblName.Dock = DockStyle.Fill;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(810, 64);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            tblMain.SetRowSpan(lblName, 9);
            lblName.Size = new Size(37, 635);
            lblName.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(59, 74, 46);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(810, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            tblMain.SetRowSpan(label1, 2);
            label1.Size = new Size(37, 64);
            label1.TabIndex = 47;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(103, 30);
            button1.TabIndex = 0;
            button1.Text = "S&ave";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(194, 250);
            dataGridView2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(button1, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 699);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecipe";
            Text = "Recipe Info";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            tblRecipeInfo.ResumeLayout(false);
            tblRecipeInfo.PerformLayout();
            tblRecipeStatus.ResumeLayout(false);
            tblRecipeStatus.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbRecipeDetails.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblControl;
        private TabControl tbRecipeDetails;
        private TabPage tbIngredients;
        private TableLayoutPanel tblRecipeTab;
        private TabPage tbSteps;
        private TableLayoutPanel tblStatusDates;
        private TableLayoutPanel tblRecipeInfo;
        private TextBox txtCalories;
        private ComboBox lstCuisineName;
        private ComboBox lstUsersName;
        private Label lblUser;
        private TextBox txtRecipeName;
        private Label lblRecipeName;
        private TableLayoutPanel tblIngredients;
        private TableLayoutPanel tblButtons;
        private Button btnDelete;
        private Button btnSave;
        private Label lblCuisine;
        private Label lblCalories;
        private TableLayoutPanel tblRecipeStatus;
        private Label lblRecipeStatusLabel;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Button btnIngredientsSave;
        private DataGridView gIngredients;
        private TableLayoutPanel tblSteps;
        private Button btnStepsSave;
        private DataGridView gSteps;
        private Button button1;
        private DataGridView dataGridView2;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnChangeStatus;
        private Label lblName;
        private Label label1;
        private Label lblRecipeStatus;
    }
}