namespace RecipeWinForms
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            tblMain = new TableLayoutPanel();
            lblGreatFood = new Label();
            lblFood = new Label();
            lblStartsHere = new Label();
            tblSearch = new TableLayoutPanel();
            btnSearch = new Button();
            txtRecipe = new TextBox();
            lblRecipeName = new Label();
            gRecipe = new DataGridView();
            lblBlank = new Label();
            tblMain.SuspendLayout();
            tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.142857F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.85714F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 410F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            tblMain.Controls.Add(lblGreatFood, 1, 2);
            tblMain.Controls.Add(lblFood, 1, 3);
            tblMain.Controls.Add(lblStartsHere, 1, 5);
            tblMain.Controls.Add(tblSearch, 1, 8);
            tblMain.Controls.Add(gRecipe, 1, 7);
            tblMain.Controls.Add(lblBlank, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 5, 4, 5);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.5608253F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3572578F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.081921F));
            tblMain.Size = new Size(878, 631);
            tblMain.TabIndex = 0;
            // 
            // lblGreatFood
            // 
            lblGreatFood.AutoSize = true;
            lblGreatFood.BackColor = Color.FromArgb(59, 74, 46);
            lblGreatFood.Dock = DockStyle.Fill;
            lblGreatFood.Font = new Font("Garet Book", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblGreatFood.ForeColor = Color.White;
            lblGreatFood.Location = new Point(36, 79);
            lblGreatFood.Margin = new Padding(10, 0, 6, 0);
            lblGreatFood.Name = "lblGreatFood";
            lblGreatFood.Size = new Size(327, 46);
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
            lblFood.Location = new Point(36, 125);
            lblFood.Margin = new Padding(10, 0, 6, 0);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(327, 96);
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
            lblStartsHere.Location = new Point(36, 221);
            lblStartsHere.Margin = new Padding(10, 0, 6, 0);
            lblStartsHere.Name = "lblStartsHere";
            lblStartsHere.Size = new Size(327, 139);
            lblStartsHere.TabIndex = 2;
            lblStartsHere.Text = "     Starts\r\n     Here";
            // 
            // tblSearch
            // 
            tblSearch.AutoSize = true;
            tblSearch.ColumnCount = 3;
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.27559F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.72441F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            tblSearch.Controls.Add(btnSearch, 2, 0);
            tblSearch.Controls.Add(txtRecipe, 1, 0);
            tblSearch.Controls.Add(lblRecipeName, 0, 0);
            tblSearch.Dock = DockStyle.Fill;
            tblSearch.Location = new Point(30, 565);
            tblSearch.Margin = new Padding(4, 5, 4, 5);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 1;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSearch.Size = new Size(335, 37);
            tblSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSearch.AutoSize = true;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(255, 3);
            btnSearch.Margin = new Padding(6, 3, 3, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(77, 31);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search!";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtRecipe
            // 
            txtRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtRecipe.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecipe.Location = new Point(120, 3);
            txtRecipe.Name = "txtRecipe";
            txtRecipe.Size = new Size(121, 31);
            txtRecipe.TabIndex = 1;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new Font("Twister", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRecipeName.Location = new Point(4, 0);
            lblRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(105, 37);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name:";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gRecipe
            // 
            gRecipe.AllowUserToAddRows = false;
            gRecipe.AllowUserToDeleteRows = false;
            gRecipe.AllowUserToResizeColumns = false;
            gRecipe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Garet Book", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = null;
            gRecipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gRecipe.BackgroundColor = Color.White;
            gRecipe.BorderStyle = BorderStyle.None;
            gRecipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gRecipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Garet Book", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(59, 74, 46);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gRecipe.DefaultCellStyle = dataGridViewCellStyle3;
            gRecipe.EnableHeadersVisualStyles = false;
            gRecipe.GridColor = Color.FromArgb(188, 200, 135);
            gRecipe.Location = new Point(36, 360);
            gRecipe.Margin = new Padding(10, 0, 6, 3);
            gRecipe.Name = "gRecipe";
            gRecipe.ReadOnly = true;
            gRecipe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gRecipe.RowTemplate.DividerHeight = 2;
            gRecipe.RowTemplate.Height = 25;
            gRecipe.Size = new Size(327, 197);
            gRecipe.TabIndex = 6;
            // 
            // lblBlank
            // 
            lblBlank.BackColor = Color.FromArgb(59, 74, 46);
            lblBlank.Dock = DockStyle.Fill;
            lblBlank.Location = new Point(36, 19);
            lblBlank.Margin = new Padding(10, 0, 6, 0);
            lblBlank.Name = "lblBlank";
            lblBlank.Size = new Size(327, 60);
            lblBlank.TabIndex = 7;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(188, 200, 135);
            ClientSize = new Size(878, 631);
            Controls.Add(tblMain);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSearch";
            Text = "Foodie";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblGreatFood;
        private Label lblFood;
        private TableLayoutPanel tblSearch;
        private Label lblRecipeName;
        private TextBox txtRecipe;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Label lblStartsHere;
        private Label lblBlank;
    }
}