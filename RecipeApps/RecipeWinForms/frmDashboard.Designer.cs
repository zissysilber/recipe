namespace RecipeWinForms
{
    partial class frmDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tblMain = new TableLayoutPanel();
            lblGreatFood = new Label();
            lblFood = new Label();
            lblStartsHere = new Label();
            gSummary = new DataGridView();
            lblBlank = new Label();
            tblListButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSummary).BeginInit();
            tblListButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.BackColor = Color.FromArgb(188, 200, 135);
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142857F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.85714F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 434F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 33F));
            tblMain.Controls.Add(lblGreatFood, 1, 2);
            tblMain.Controls.Add(lblFood, 1, 3);
            tblMain.Controls.Add(lblStartsHere, 1, 5);
            tblMain.Controls.Add(gSummary, 1, 7);
            tblMain.Controls.Add(lblBlank, 1, 1);
            tblMain.Controls.Add(tblListButtons, 1, 10);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 12;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblMain.Size = new Size(1093, 514);
            tblMain.TabIndex = 1;
            // 
            // lblGreatFood
            // 
            lblGreatFood.AutoSize = true;
            lblGreatFood.BackColor = Color.FromArgb(59, 74, 46);
            lblGreatFood.Dock = DockStyle.Fill;
            lblGreatFood.Font = new Font("Garet Book", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreatFood.ForeColor = Color.White;
            lblGreatFood.Location = new Point(49, 45);
            lblGreatFood.Margin = new Padding(5, 0, 6, 0);
            lblGreatFood.Name = "lblGreatFood";
            lblGreatFood.Size = new Size(570, 46);
            lblGreatFood.TabIndex = 0;
            lblGreatFood.Text = "     Great\r\n";
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.BackColor = Color.FromArgb(59, 74, 46);
            lblFood.Dock = DockStyle.Fill;
            lblFood.Font = new Font("Twister", 47.9999962F, FontStyle.Regular, GraphicsUnit.Point);
            lblFood.ForeColor = Color.White;
            lblFood.Location = new Point(49, 91);
            lblFood.Margin = new Padding(5, 0, 6, 0);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(570, 96);
            lblFood.TabIndex = 1;
            lblFood.Text = "  Food";
            // 
            // lblStartsHere
            // 
            lblStartsHere.AutoSize = true;
            lblStartsHere.BackColor = Color.FromArgb(59, 74, 46);
            lblStartsHere.Dock = DockStyle.Fill;
            lblStartsHere.Font = new Font("Garet Book", 23.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblStartsHere.ForeColor = Color.White;
            lblStartsHere.Location = new Point(49, 187);
            lblStartsHere.Margin = new Padding(5, 0, 6, 0);
            lblStartsHere.Name = "lblStartsHere";
            lblStartsHere.Size = new Size(570, 92);
            lblStartsHere.TabIndex = 2;
            lblStartsHere.Text = "     Starts\r\n     Here";
            // 
            // gSummary
            // 
            gSummary.AllowUserToAddRows = false;
            gSummary.AllowUserToDeleteRows = false;
            gSummary.AllowUserToResizeColumns = false;
            gSummary.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Garet Book", 11.99F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = null;
            gSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gSummary.BackgroundColor = Color.White;
            gSummary.BorderStyle = BorderStyle.None;
            gSummary.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 74, 46);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gSummary.DefaultCellStyle = dataGridViewCellStyle3;
            gSummary.EnableHeadersVisualStyles = false;
            gSummary.GridColor = Color.FromArgb(188, 200, 135);
            gSummary.Location = new Point(49, 279);
            gSummary.Margin = new Padding(5, 0, 6, 3);
            gSummary.Name = "gSummary";
            gSummary.ReadOnly = true;
            gSummary.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(59, 74, 46);
            dataGridViewCellStyle5.SelectionForeColor = Color.Empty;
            gSummary.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gSummary.RowTemplate.DividerHeight = 2;
            gSummary.RowTemplate.Height = 25;
            gSummary.ScrollBars = ScrollBars.Vertical;
            gSummary.Size = new Size(570, 148);
            gSummary.TabIndex = 6;
            // 
            // lblBlank
            // 
            lblBlank.BackColor = Color.FromArgb(59, 74, 46);
            lblBlank.Dock = DockStyle.Fill;
            lblBlank.Location = new Point(49, 24);
            lblBlank.Margin = new Padding(5, 0, 6, 0);
            lblBlank.Name = "lblBlank";
            lblBlank.Size = new Size(570, 21);
            lblBlank.TabIndex = 7;
            // 
            // tblListButtons
            // 
            tblListButtons.ColumnCount = 3;
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblListButtons.Controls.Add(btnRecipeList, 0, 0);
            tblListButtons.Controls.Add(btnMealList, 1, 0);
            tblListButtons.Controls.Add(btnCookbookList, 2, 0);
            tblListButtons.Dock = DockStyle.Fill;
            tblListButtons.Location = new Point(47, 433);
            tblListButtons.Name = "tblListButtons";
            tblListButtons.RowCount = 1;
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblListButtons.Size = new Size(575, 48);
            tblListButtons.TabIndex = 8;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = Color.FromArgb(188, 200, 135);
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(185, 42);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.BackColor = Color.FromArgb(188, 200, 135);
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealList.Location = new Point(194, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(185, 42);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.BackColor = Color.FromArgb(188, 200, 135);
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCookbookList.Location = new Point(385, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(187, 42);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 514);
            Controls.Add(tblMain);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSummary).EndInit();
            tblListButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblGreatFood;
        private Label lblFood;
        private Label lblStartsHere;
        private DataGridView gSummary;
        private Label lblBlank;
        private TableLayoutPanel tblListButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}