namespace RecipeWinForms
{
    partial class frmCookbookList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNewRecipe = new Button();
            gRecipeSummary = new DataGridView();
            btnNewCookbook = new Button();
            gCookbook = new DataGridView();
            lblCookbookList = new Label();
            lblColorLight = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeSummary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gCookbook).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.23395F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.76605F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnNewRecipe, 1, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewRecipe
            // 
            btnNewRecipe.AutoSize = true;
            btnNewRecipe.Dock = DockStyle.Fill;
            btnNewRecipe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecipe.Location = new Point(24, 44);
            btnNewRecipe.Margin = new Padding(4);
            btnNewRecipe.Name = "btnNewRecipe";
            btnNewRecipe.Size = new Size(16, 52);
            btnNewRecipe.TabIndex = 0;
            btnNewRecipe.Text = "New Recipe";
            btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // gRecipeSummary
            // 
            gRecipeSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeSummary.Dock = DockStyle.Fill;
            gRecipeSummary.Location = new Point(24, 427);
            gRecipeSummary.Margin = new Padding(4);
            gRecipeSummary.Name = "gRecipeSummary";
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gRecipeSummary.RowsDefaultCellStyle = dataGridViewCellStyle1;
            gRecipeSummary.RowTemplate.Height = 25;
            gRecipeSummary.Size = new Size(151, 415);
            gRecipeSummary.TabIndex = 1;
            // 
            // btnNewCookbook
            // 
            btnNewCookbook.AutoSize = true;
            btnNewCookbook.Dock = DockStyle.Fill;
            btnNewCookbook.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewCookbook.Location = new Point(24, 72);
            btnNewCookbook.Margin = new Padding(4);
            btnNewCookbook.Name = "btnNewCookbook";
            btnNewCookbook.Size = new Size(165, 33);
            btnNewCookbook.TabIndex = 0;
            btnNewCookbook.Text = "New Cookbook";
            btnNewCookbook.UseVisualStyleBackColor = true;
            // 
            // gCookbook
            // 
            gCookbook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(gCookbook, 2);
            gCookbook.Dock = DockStyle.Fill;
            gCookbook.Location = new Point(24, 152);
            gCookbook.Margin = new Padding(4);
            gCookbook.Name = "gCookbook";
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gCookbook.RowsDefaultCellStyle = dataGridViewCellStyle2;
            gCookbook.RowTemplate.Height = 25;
            gCookbook.Size = new Size(1129, 417);
            gCookbook.TabIndex = 1;
            // 
            // lblCookbookList
            // 
            lblCookbookList.AutoSize = true;
            lblCookbookList.BackColor = Color.FromArgb(59, 74, 46);
            tableLayoutPanel2.SetColumnSpan(lblCookbookList, 2);
            lblCookbookList.Dock = DockStyle.Fill;
            lblCookbookList.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCookbookList.ForeColor = Color.White;
            lblCookbookList.Location = new Point(0, 0);
            lblCookbookList.Margin = new Padding(0);
            lblCookbookList.Name = "lblCookbookList";
            lblCookbookList.Size = new Size(193, 46);
            lblCookbookList.TabIndex = 2;
            lblCookbookList.Text = "    Cookbook List";
            lblCookbookList.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblColorLight
            // 
            lblColorLight.AutoSize = true;
            lblColorLight.BackColor = Color.FromArgb(188, 200, 135);
            tableLayoutPanel2.SetColumnSpan(lblColorLight, 2);
            lblColorLight.Dock = DockStyle.Fill;
            lblColorLight.Location = new Point(193, 0);
            lblColorLight.Margin = new Padding(0);
            lblColorLight.Name = "lblColorLight";
            lblColorLight.Size = new Size(985, 46);
            lblColorLight.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.23395F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.76605F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnNewCookbook, 1, 2);
            tableLayoutPanel2.Controls.Add(gCookbook, 1, 4);
            tableLayoutPanel2.Controls.Add(lblCookbookList, 0, 0);
            tableLayoutPanel2.Controls.Add(lblColorLight, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel2.Size = new Size(1178, 622);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 622);
            Controls.Add(tableLayoutPanel2);
            Name = "frmCookbookList";
            Text = "Cookbook List";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeSummary).EndInit();
            ((System.ComponentModel.ISupportInitialize)gCookbook).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNewRecipe;
        private DataGridView gRecipeSummary;
        private Button btnNewCookbook;
        private DataGridView gCookbook;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblCookbookList;
        private Label lblColorLight;
    }
}