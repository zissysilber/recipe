using System.Windows.Forms;

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
            tblMain = new TableLayoutPanel();
            btnNewRecipe = new Button();
            gRecipeSummary = new DataGridView();
            lblRecipeList = new Label();
            label1 = new Label();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeSummary).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.77802F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.22198F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblMain.Controls.Add(btnNewRecipe, 1, 2);
            tblMain.Controls.Add(gRecipeSummary, 1, 4);
            tblMain.Controls.Add(lblRecipeList, 0, 0);
            tblMain.Controls.Add(label1, 2, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 6;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tblMain.Size = new Size(960, 630);
            tblMain.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.Dock = DockStyle.Fill;
            btnNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecipe.Location = new Point(24, 72);
            btnNewRecipe.Margin = new Padding(4);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(137, 43);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipeSummary
            // 
            gRecipeSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gRecipeSummary, 2);
            gRecipeSummary.Dock = DockStyle.Fill;
            gRecipeSummary.Location = new Point(24, 162);
            gRecipeSummary.Margin = new Padding(4);
            gRecipeSummary.Name = "gRecipeSummary";
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gRecipeSummary.RowsDefaultCellStyle = dataGridViewCellStyle2;
            gRecipeSummary.RowTemplate.Height = 25;
            gRecipeSummary.Size = new Size(911, 415);
            gRecipeSummary.TabIndex = 1;
            // 
            // lblRecipeList
            // 
            lblRecipeList.AutoSize = true;
            lblRecipeList.BackColor = Color.FromArgb(59, 74, 46);
            tblMain.SetColumnSpan(lblRecipeList, 2);
            lblRecipeList.Dock = DockStyle.Fill;
            lblRecipeList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeList.ForeColor = Color.White;
            lblRecipeList.Location = new Point(0, 0);
            lblRecipeList.Margin = new Padding(0);
            lblRecipeList.Name = "lblRecipeList";
            lblRecipeList.Size = new Size(193, 46);
            lblRecipeList.TabIndex = 2;
            lblRecipeList.Text = "    Recipe List";
            lblRecipeList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(188, 200, 135);
            tblMain.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(165, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(795, 46);
            label1.TabIndex = 3;
            // 
            // frmRecipeList
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "frmRecipeList";
            Text = "Recipe List";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeSummary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewRecipe;
        private DataGridView gRecipeSummary;
        private Label lblRecipeList;
        private Label label1;
    }
}