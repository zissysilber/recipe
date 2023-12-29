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
            gSummary = new DataGridView();
            lblGreatFood = new Label();
            lblFood = new Label();
            lblStartsHere = new Label();
            lblBlank = new Label();
            tblListButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            label1 = new Label();
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
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.594937F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.07173F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            tblMain.Controls.Add(gSummary, 1, 7);
            tblMain.Controls.Add(lblGreatFood, 1, 2);
            tblMain.Controls.Add(lblFood, 1, 3);
            tblMain.Controls.Add(lblStartsHere, 1, 5);
            tblMain.Controls.Add(lblBlank, 1, 1);
            tblMain.Controls.Add(tblListButtons, 0, 9);
            tblMain.Controls.Add(label1, 3, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 12;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(801, 681);
            tblMain.TabIndex = 1;
            // 
            // gSummary
            // 
            gSummary.AccessibleRole = AccessibleRole.None;
            gSummary.AllowUserToAddRows = false;
            gSummary.AllowUserToDeleteRows = false;
            gSummary.AllowUserToResizeColumns = false;
            gSummary.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = null;
            gSummary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gSummary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gSummary.BackgroundColor = Color.White;
            gSummary.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 74, 46);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gSummary.DefaultCellStyle = dataGridViewCellStyle3;
            gSummary.EnableHeadersVisualStyles = false;
            gSummary.GridColor = Color.FromArgb(188, 200, 135);
            gSummary.Location = new Point(59, 276);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(59, 74, 46);
            gSummary.RowsDefaultCellStyle = dataGridViewCellStyle5;
            gSummary.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gSummary.RowTemplate.DividerHeight = 2;
            gSummary.RowTemplate.Height = 25;
            gSummary.ScrollBars = ScrollBars.Vertical;
            gSummary.Size = new Size(409, 122);
            gSummary.TabIndex = 6;
            // 
            // lblGreatFood
            // 
            lblGreatFood.AutoSize = true;
            lblGreatFood.BackColor = Color.FromArgb(59, 74, 46);
            lblGreatFood.Dock = DockStyle.Fill;
            lblGreatFood.Font = new Font("Garet Book", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreatFood.ForeColor = Color.White;
            lblGreatFood.Location = new Point(59, 42);
            lblGreatFood.Margin = new Padding(5, 0, 6, 0);
            lblGreatFood.Name = "lblGreatFood";
            lblGreatFood.Size = new Size(409, 46);
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
            lblFood.Location = new Point(59, 88);
            lblFood.Margin = new Padding(5, 0, 6, 0);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(409, 96);
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
            lblStartsHere.Location = new Point(59, 184);
            lblStartsHere.Margin = new Padding(5, 0, 6, 0);
            lblStartsHere.Name = "lblStartsHere";
            lblStartsHere.Size = new Size(409, 92);
            lblStartsHere.TabIndex = 2;
            lblStartsHere.Text = "     Starts\r\n     Here";
            // 
            // lblBlank
            // 
            lblBlank.BackColor = Color.FromArgb(59, 74, 46);
            lblBlank.Dock = DockStyle.Fill;
            lblBlank.Location = new Point(59, 24);
            lblBlank.Margin = new Padding(5, 0, 6, 0);
            lblBlank.Name = "lblBlank";
            lblBlank.Size = new Size(409, 18);
            lblBlank.TabIndex = 7;
            // 
            // tblListButtons
            // 
            tblListButtons.ColumnCount = 1;
            tblMain.SetColumnSpan(tblListButtons, 2);
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblListButtons.Controls.Add(btnRecipeList, 0, 0);
            tblListButtons.Controls.Add(btnMealList, 0, 1);
            tblListButtons.Controls.Add(btnCookbookList, 0, 2);
            tblListButtons.Dock = DockStyle.Fill;
            tblListButtons.Location = new Point(3, 404);
            tblListButtons.Name = "tblListButtons";
            tblListButtons.RowCount = 3;
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblListButtons.Size = new Size(468, 147);
            tblListButtons.TabIndex = 8;
            // 
            // btnRecipeList
            // 
            btnRecipeList.BackColor = Color.FromArgb(188, 200, 135);
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(462, 44);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "&Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.BackColor = Color.FromArgb(188, 200, 135);
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealList.Location = new Point(3, 53);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(462, 44);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "&Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.BackColor = Color.FromArgb(188, 200, 135);
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCookbookList.Location = new Point(3, 103);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(462, 44);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "&Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(59, 74, 46);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(711, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            tblMain.SetRowSpan(label1, 12);
            label1.Size = new Size(90, 681);
            label1.TabIndex = 9;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 681);
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
        private Label lblBlank;
        private TableLayoutPanel tblListButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private DataGridView gSummary;
        private Label label1;
    }
}