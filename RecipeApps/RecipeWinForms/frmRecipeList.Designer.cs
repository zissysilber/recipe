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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnNewRecipe, 1, 2);
            tableLayoutPanel1.Controls.Add(gRecipeSummary, 1, 4);
            tableLayoutPanel1.Controls.Add(lblColor1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.Size = new Size(960, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.Dock = DockStyle.Fill;
            btnNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecipe.Location = new Point(24, 79);
            btnNewRecipe.Margin = new Padding(4);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(452, 43);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipeSummary
            // 
            gRecipeSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(gRecipeSummary, 2);
            gRecipeSummary.Dock = DockStyle.Fill;
            gRecipeSummary.Location = new Point(24, 162);
            gRecipeSummary.Margin = new Padding(4);
            gRecipeSummary.Name = "gRecipeSummary";
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gRecipeSummary.RowsDefaultCellStyle = dataGridViewCellStyle2;
            gRecipeSummary.RowTemplate.Height = 25;
            gRecipeSummary.Size = new Size(912, 415);
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
            lblColor1.Size = new Size(480, 46);
            lblColor1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(188, 200, 135);
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(480, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(480, 46);
            label1.TabIndex = 3;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 630);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
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