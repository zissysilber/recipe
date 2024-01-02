namespace RecipeWinForms
{
    partial class frmCloneRecipe
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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblSelectRecipe = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnClone = new Button();
            lstRecipeName = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7194252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.9928055F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.28777F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.89855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.362318F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.7391319F));
            tableLayoutPanel1.Size = new Size(695, 690);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblSelectRecipe, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(lstRecipeName, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(147, 161);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.15094F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35.8490562F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel2.Size = new Size(404, 169);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSelectRecipe
            // 
            lblSelectRecipe.AutoSize = true;
            lblSelectRecipe.Dock = DockStyle.Fill;
            lblSelectRecipe.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectRecipe.Location = new Point(3, 0);
            lblSelectRecipe.Name = "lblSelectRecipe";
            lblSelectRecipe.Size = new Size(398, 68);
            lblSelectRecipe.TabIndex = 1;
            lblSelectRecipe.Text = "Select Recipe";
            lblSelectRecipe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnClone, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 109);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.0701752F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.9298248F));
            tableLayoutPanel3.Size = new Size(398, 57);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnClone
            // 
            btnClone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClone.Location = new Point(263, 19);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(132, 35);
            btnClone.TabIndex = 0;
            btnClone.Text = "&Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // lstRecipeName
            // 
            lstRecipeName.Dock = DockStyle.Fill;
            lstRecipeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstRecipeName.FormattingEnabled = true;
            lstRecipeName.Location = new Point(3, 71);
            lstRecipeName.Name = "lstRecipeName";
            lstRecipeName.Size = new Size(398, 29);
            lstRecipeName.TabIndex = 3;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 690);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCloneRecipe";
            Text = "Clone Recipe";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSelectRecipe;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnClone;
        private ComboBox lstRecipeName;
    }
}