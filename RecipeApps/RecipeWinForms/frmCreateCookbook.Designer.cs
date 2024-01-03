namespace RecipeWinForms
{
    partial class frmCreateCookbook
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
            lblAutoCreate = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCreate = new Button();
            lstUsersName = new ComboBox();
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
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblAutoCreate, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(lstUsersName, 0, 1);
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
            // lblAutoCreate
            // 
            lblAutoCreate.AutoSize = true;
            lblAutoCreate.Dock = DockStyle.Fill;
            lblAutoCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutoCreate.Location = new Point(3, 0);
            lblAutoCreate.Name = "lblAutoCreate";
            lblAutoCreate.Size = new Size(398, 68);
            lblAutoCreate.TabIndex = 1;
            lblAutoCreate.Text = "Auto-Create a Cookbook";
            lblAutoCreate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnCreate, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 109);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 28.0701752F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 71.9298248F));
            tableLayoutPanel3.Size = new Size(398, 57);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(263, 19);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(132, 35);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "&Create!";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // lstUsersName
            // 
            lstUsersName.Dock = DockStyle.Fill;
            lstUsersName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsersName.FormattingEnabled = true;
            lstUsersName.Location = new Point(3, 71);
            lstUsersName.Name = "lstUsersName";
            lstUsersName.Size = new Size(398, 29);
            lstUsersName.TabIndex = 3;
            // 
            // frmCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 690);
            Controls.Add(tableLayoutPanel1);
            Name = "frmCreateCookbook";
            Text = "Auto-Create a Cookbook";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblAutoCreate;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCreate;
        private ComboBox lstUsersName;
    }
}