namespace RecipeWinForms
{
    partial class frmRecipeList
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNewRecipe = new Button();
            gRecipeSummary = new DataGridView();
            lblColor1 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeSummary).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.58101F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.41899F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 942F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Controls.Add(btnNewRecipe, 1, 2);
            tableLayoutPanel1.Controls.Add(gRecipeSummary, 1, 4);
            tableLayoutPanel1.Controls.Add(lblColor1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.444445F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.55556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(1156, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.Dock = DockStyle.Fill;
            btnNewRecipe.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecipe.Location = new Point(45, 57);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(124, 25);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipeSummary
            // 
            gRecipeSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(gRecipeSummary, 2);
            gRecipeSummary.Dock = DockStyle.Fill;
            gRecipeSummary.Location = new Point(45, 111);
            gRecipeSummary.Name = "gRecipeSummary";
            gRecipeSummary.RowTemplate.Height = 25;
            gRecipeSummary.Size = new Size(1066, 300);
            gRecipeSummary.TabIndex = 1;
            // 
            // lblColor1
            // 
            lblColor1.AutoSize = true;
            lblColor1.BackColor = Color.FromArgb(59, 74, 46);
            tableLayoutPanel1.SetColumnSpan(lblColor1, 2);
            lblColor1.Dock = DockStyle.Fill;
            lblColor1.Location = new Point(0, 0);
            lblColor1.Margin = new Padding(0);
            lblColor1.Name = "lblColor1";
            lblColor1.Size = new Size(172, 33);
            lblColor1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(188, 200, 135);
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(172, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(984, 33);
            label1.TabIndex = 3;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNewRecipe;
        private DataGridView gRecipeSummary;
        private Label lblColor1;
        private Label label1;
    }
}