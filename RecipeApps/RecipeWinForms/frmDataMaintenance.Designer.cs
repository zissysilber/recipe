namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            tblMain = new TableLayoutPanel();
            lblDataMaintenance = new Label();
            lblColorLight = new Label();
            pnlOptionButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisine = new RadioButton();
            optIngredient = new RadioButton();
            optMeasurement = new RadioButton();
            optCourse = new RadioButton();
            gData = new DataGridView();
            tblSaveButton = new TableLayoutPanel();
            btnSave = new Button();
            tblMain.SuspendLayout();
            pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            tblSaveButton.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.13613F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 24F));
            tblMain.Controls.Add(lblDataMaintenance, 0, 0);
            tblMain.Controls.Add(lblColorLight, 2, 0);
            tblMain.Controls.Add(pnlOptionButtons, 1, 2);
            tblMain.Controls.Add(gData, 2, 2);
            tblMain.Controls.Add(tblSaveButton, 2, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55441141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.867974F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 77.51419F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.5121007F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.55131626F));
            tblMain.Size = new Size(695, 690);
            tblMain.TabIndex = 0;
            // 
            // lblDataMaintenance
            // 
            lblDataMaintenance.AutoSize = true;
            lblDataMaintenance.BackColor = Color.FromArgb(59, 74, 46);
            tblMain.SetColumnSpan(lblDataMaintenance, 2);
            lblDataMaintenance.Dock = DockStyle.Fill;
            lblDataMaintenance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDataMaintenance.ForeColor = Color.White;
            lblDataMaintenance.Location = new Point(0, 0);
            lblDataMaintenance.Margin = new Padding(0);
            lblDataMaintenance.Name = "lblDataMaintenance";
            lblDataMaintenance.Size = new Size(200, 38);
            lblDataMaintenance.TabIndex = 0;
            lblDataMaintenance.Text = "   Data Maintenance";
            lblDataMaintenance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblColorLight
            // 
            lblColorLight.AutoSize = true;
            lblColorLight.BackColor = Color.FromArgb(188, 200, 135);
            tblMain.SetColumnSpan(lblColorLight, 2);
            lblColorLight.Dock = DockStyle.Fill;
            lblColorLight.Location = new Point(200, 0);
            lblColorLight.Margin = new Padding(0);
            lblColorLight.Name = "lblColorLight";
            lblColorLight.Size = new Size(495, 38);
            lblColorLight.TabIndex = 5;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.Controls.Add(optUsers);
            pnlOptionButtons.Controls.Add(optCuisine);
            pnlOptionButtons.Controls.Add(optIngredient);
            pnlOptionButtons.Controls.Add(optMeasurement);
            pnlOptionButtons.Controls.Add(optCourse);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(32, 67);
            pnlOptionButtons.Name = "pnlOptionButtons";
            pnlOptionButtons.Size = new Size(165, 528);
            pnlOptionButtons.TabIndex = 1;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optUsers.Location = new Point(3, 3);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(67, 25);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "&Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            optCuisine.AutoSize = true;
            optCuisine.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optCuisine.Location = new Point(3, 34);
            optCuisine.Name = "optCuisine";
            optCuisine.Size = new Size(86, 25);
            optCuisine.TabIndex = 1;
            optCuisine.TabStop = true;
            optCuisine.Text = "&Cuisines";
            optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.AutoSize = true;
            optIngredient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optIngredient.Location = new Point(3, 65);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(106, 25);
            optIngredient.TabIndex = 2;
            optIngredient.TabStop = true;
            optIngredient.Text = "&Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.AutoSize = true;
            optMeasurement.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optMeasurement.Location = new Point(3, 96);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(131, 25);
            optMeasurement.TabIndex = 3;
            optMeasurement.TabStop = true;
            optMeasurement.Text = "&Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            optCourse.Location = new Point(3, 127);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(84, 25);
            optCourse.TabIndex = 4;
            optCourse.TabStop = true;
            optCourse.Text = "&Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gData.DefaultCellStyle = dataGridViewCellStyle2;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(203, 67);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(465, 528);
            gData.TabIndex = 2;
            // 
            // tblSaveButton
            // 
            tblSaveButton.ColumnCount = 2;
            tblSaveButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSaveButton.ColumnStyles.Add(new ColumnStyle());
            tblSaveButton.Controls.Add(btnSave, 1, 0);
            tblSaveButton.Dock = DockStyle.Fill;
            tblSaveButton.Location = new Point(203, 601);
            tblSaveButton.Name = "tblSaveButton";
            tblSaveButton.RowCount = 1;
            tblSaveButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSaveButton.Size = new Size(465, 45);
            tblSaveButton.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(321, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 39);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 690);
            Controls.Add(tblMain);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            tblSaveButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblDataMaintenance;
        private Label lblColorLight;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUsers;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private RadioButton optCourse;
        private DataGridView gData;
        private TableLayoutPanel tblSaveButton;
        private Button btnSave;
    }
}