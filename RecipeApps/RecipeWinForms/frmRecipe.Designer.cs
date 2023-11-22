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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblCaptionCalories = new Label();
            lblCalories = new Label();
            lblCaptionDateDrafted = new Label();
            lblDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblDateArchived = new Label();
            lblCaptionRecipeImage = new Label();
            lblRecipeImage = new Label();
            lblCaptionRecipeStatus = new Label();
            lblRecipeStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 255F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblRecipeName, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCaptionCalories, 0, 1);
            tableLayoutPanel1.Controls.Add(lblCalories, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCaptionDateDrafted, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDateDrafted, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCaptionDatePublished, 0, 3);
            tableLayoutPanel1.Controls.Add(lblDatePublished, 1, 3);
            tableLayoutPanel1.Controls.Add(lblCaptionDateArchived, 0, 4);
            tableLayoutPanel1.Controls.Add(lblDateArchived, 1, 4);
            tableLayoutPanel1.Controls.Add(lblCaptionRecipeImage, 0, 5);
            tableLayoutPanel1.Controls.Add(lblRecipeImage, 1, 5);
            tableLayoutPanel1.Controls.Add(lblCaptionRecipeStatus, 0, 6);
            tableLayoutPanel1.Controls.Add(lblRecipeStatus, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(411, 291);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.BackColor = Color.FromArgb(59, 74, 46);
            tableLayoutPanel1.SetColumnSpan(lblRecipeName, 2);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Twister", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeName.ForeColor = Color.White;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(405, 41);
            lblRecipeName.TabIndex = 1;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCaptionCalories
            // 
            lblCaptionCalories.AutoSize = true;
            lblCaptionCalories.BackColor = Color.FromArgb(188, 200, 135);
            lblCaptionCalories.Dock = DockStyle.Fill;
            lblCaptionCalories.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionCalories.Location = new Point(3, 41);
            lblCaptionCalories.Name = "lblCaptionCalories";
            lblCaptionCalories.Size = new Size(150, 41);
            lblCaptionCalories.TabIndex = 2;
            lblCaptionCalories.Text = "Calories";
            lblCaptionCalories.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCalories
            // 
            lblCalories.BackColor = Color.FromArgb(188, 200, 135);
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Font = new Font("Garet Book", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalories.Location = new Point(159, 41);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(249, 41);
            lblCalories.TabIndex = 3;
            lblCalories.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.BackColor = Color.FromArgb(188, 200, 135);
            lblCaptionDateDrafted.Dock = DockStyle.Fill;
            lblCaptionDateDrafted.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateDrafted.Location = new Point(3, 82);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(150, 41);
            lblCaptionDateDrafted.TabIndex = 4;
            lblCaptionDateDrafted.Text = "Date Drafted";
            lblCaptionDateDrafted.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.BackColor = Color.FromArgb(188, 200, 135);
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Font = new Font("Garet Book", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateDrafted.Location = new Point(159, 82);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(249, 41);
            lblDateDrafted.TabIndex = 5;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.BackColor = Color.FromArgb(188, 200, 135);
            lblCaptionDatePublished.Dock = DockStyle.Fill;
            lblCaptionDatePublished.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDatePublished.Location = new Point(3, 123);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(150, 41);
            lblCaptionDatePublished.TabIndex = 6;
            lblCaptionDatePublished.Text = "Date Published";
            lblCaptionDatePublished.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDatePublished
            // 
            lblDatePublished.BackColor = Color.FromArgb(188, 200, 135);
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Font = new Font("Garet Book", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatePublished.Location = new Point(159, 123);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(249, 41);
            lblDatePublished.TabIndex = 7;
            lblDatePublished.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.BackColor = Color.FromArgb(188, 200, 135);
            lblCaptionDateArchived.Dock = DockStyle.Fill;
            lblCaptionDateArchived.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionDateArchived.Location = new Point(3, 164);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(150, 41);
            lblCaptionDateArchived.TabIndex = 8;
            lblCaptionDateArchived.Text = "Date Archived";
            lblCaptionDateArchived.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateArchived
            // 
            lblDateArchived.BackColor = Color.FromArgb(188, 200, 135);
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Font = new Font("Garet Book", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateArchived.Location = new Point(159, 164);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(249, 41);
            lblDateArchived.TabIndex = 9;
            lblDateArchived.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionRecipeImage
            // 
            lblCaptionRecipeImage.AutoSize = true;
            lblCaptionRecipeImage.BackColor = Color.FromArgb(188, 200, 135);
            lblCaptionRecipeImage.Dock = DockStyle.Fill;
            lblCaptionRecipeImage.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeImage.Location = new Point(3, 205);
            lblCaptionRecipeImage.Name = "lblCaptionRecipeImage";
            lblCaptionRecipeImage.Size = new Size(150, 41);
            lblCaptionRecipeImage.TabIndex = 10;
            lblCaptionRecipeImage.Text = "Recipe Image";
            lblCaptionRecipeImage.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecipeImage
            // 
            lblRecipeImage.BackColor = Color.FromArgb(188, 200, 135);
            lblRecipeImage.Dock = DockStyle.Fill;
            lblRecipeImage.Font = new Font("Garet Book", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeImage.Location = new Point(159, 205);
            lblRecipeImage.Name = "lblRecipeImage";
            lblRecipeImage.Size = new Size(249, 41);
            lblRecipeImage.TabIndex = 11;
            lblRecipeImage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.BackColor = Color.FromArgb(188, 200, 135);
            lblCaptionRecipeStatus.Dock = DockStyle.Fill;
            lblCaptionRecipeStatus.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaptionRecipeStatus.Location = new Point(3, 246);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(150, 45);
            lblCaptionRecipeStatus.TabIndex = 12;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            lblCaptionRecipeStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.BackColor = Color.FromArgb(188, 200, 135);
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Garet Book", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lblRecipeStatus.Location = new Point(159, 246);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(249, 45);
            lblRecipeStatus.TabIndex = 13;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 291);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRecipe";
            Text = "Recipe Info";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblRecipeName;
        private Label lblCaptionCalories;
        private Label lblCalories;
        private Label lblCaptionDateDrafted;
        private Label lblDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblDateArchived;
        private Label lblCaptionRecipeImage;
        private Label lblRecipeImage;
        private Label lblCaptionRecipeStatus;
        private Label lblRecipeStatus;
    }
}