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
            tblMain.Controls.Add(gSummary, 1, 4);
            tblMain.Controls.Add(lblGreatFood, 1, 1);
            tblMain.Controls.Add(lblFood, 1, 2);
            tblMain.Controls.Add(lblStartsHere, 1, 3);
            tblMain.Controls.Add(tblListButtons, 1, 6);
            tblMain.Controls.Add(label1, 3, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 8;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.754772F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.048458F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.80323F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6463661F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 32.80943F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 1.57170928F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 18.27112F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            gSummary.Dock = DockStyle.Fill;
            gSummary.EnableHeadersVisualStyles = false;
            gSummary.GridColor = Color.FromArgb(188, 200, 135);
            gSummary.Location = new Point(59, 238);
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
            gSummary.Size = new Size(409, 163);
            gSummary.TabIndex = 6;
            gSummary.TabStop = false;
            // 
            // lblGreatFood
            // 
            lblGreatFood.AutoSize = true;
            lblGreatFood.BackColor = Color.FromArgb(59, 74, 46);
            lblGreatFood.Dock = DockStyle.Fill;
            lblGreatFood.Font = new Font("Garet Book", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreatFood.ForeColor = Color.White;
            lblGreatFood.Location = new Point(59, 34);
            lblGreatFood.Margin = new Padding(5, 0, 6, 0);
            lblGreatFood.Name = "lblGreatFood";
            lblGreatFood.Size = new Size(409, 35);
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
            lblFood.Location = new Point(59, 69);
            lblFood.Margin = new Padding(5, 0, 6, 0);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(409, 70);
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
            lblStartsHere.Location = new Point(59, 139);
            lblStartsHere.Margin = new Padding(5, 0, 6, 0);
            lblStartsHere.Name = "lblStartsHere";
            lblStartsHere.Size = new Size(409, 99);
            lblStartsHere.TabIndex = 2;
            lblStartsHere.Text = "     Starts\r\n     Here";
            // 
            // tblListButtons
            // 
            tblListButtons.AutoSize = true;
            tblListButtons.ColumnCount = 1;
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblListButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblListButtons.Controls.Add(btnRecipeList, 0, 0);
            tblListButtons.Controls.Add(btnMealList, 0, 1);
            tblListButtons.Controls.Add(btnCookbookList, 0, 2);
            tblListButtons.Dock = DockStyle.Fill;
            tblListButtons.Location = new Point(57, 414);
            tblListButtons.Name = "tblListButtons";
            tblListButtons.RowCount = 3;
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblListButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblListButtons.Size = new Size(414, 168);
            tblListButtons.TabIndex = 0;
            // 
            // btnRecipeList
            // 
            btnRecipeList.AutoSize = true;
            btnRecipeList.BackColor = Color.FromArgb(188, 200, 135);
            btnRecipeList.Dock = DockStyle.Fill;
            btnRecipeList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRecipeList.Location = new Point(3, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(408, 50);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "&Recipe List";
            btnRecipeList.UseVisualStyleBackColor = false;
            // 
            // btnMealList
            // 
            btnMealList.AutoSize = true;
            btnMealList.BackColor = Color.FromArgb(188, 200, 135);
            btnMealList.Dock = DockStyle.Fill;
            btnMealList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMealList.Location = new Point(3, 59);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(408, 50);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "&Meal List";
            btnMealList.UseVisualStyleBackColor = false;
            // 
            // btnCookbookList
            // 
            btnCookbookList.AutoSize = true;
            btnCookbookList.BackColor = Color.FromArgb(188, 200, 135);
            btnCookbookList.Dock = DockStyle.Fill;
            btnCookbookList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCookbookList.Location = new Point(3, 115);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(408, 50);
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
            tblMain.SetRowSpan(label1, 8);
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
            tblListButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblGreatFood;
        private Label lblFood;
        private Label lblStartsHere;
        private TableLayoutPanel tblListButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private DataGridView gSummary;
        private Label label1;
    }
}