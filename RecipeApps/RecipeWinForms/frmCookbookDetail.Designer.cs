namespace RecipeWinForms
{
    partial class frmCookbookDetail
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
            lblName = new Label();
            label1 = new Label();
            lblCookbookName = new Label();
            lblUserName = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            cbxIsActive = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnCookbookSave = new Button();
            btnCookbookDelete = new Button();
            lstUsersName = new ComboBox();
            lblDateCreateCaption = new Label();
            lblDateCreated = new Label();
            boxCookbookDetail = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCookbookDetailSave = new Button();
            gCookbookDetail = new DataGridView();
            txtPrice = new TextBox();
            txtCookbookName = new TextBox();
            tblButton = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            boxCookbookDetail.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookDetail).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5925922F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.40741F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.Controls.Add(lblName, 4, 2);
            tableLayoutPanel1.Controls.Add(label1, 4, 0);
            tableLayoutPanel1.Controls.Add(lblCookbookName, 1, 3);
            tableLayoutPanel1.Controls.Add(lblUserName, 1, 4);
            tableLayoutPanel1.Controls.Add(lblPrice, 1, 5);
            tableLayoutPanel1.Controls.Add(lblActive, 1, 6);
            tableLayoutPanel1.Controls.Add(cbxIsActive, 2, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(lstUsersName, 2, 4);
            tableLayoutPanel1.Controls.Add(lblDateCreateCaption, 1, 7);
            tableLayoutPanel1.Controls.Add(lblDateCreated, 2, 7);
            tableLayoutPanel1.Controls.Add(boxCookbookDetail, 1, 8);
            tableLayoutPanel1.Controls.Add(txtPrice, 2, 5);
            tableLayoutPanel1.Controls.Add(txtCookbookName, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.84210539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.894737F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.140351F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.96491241F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.96491241F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.96491241F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.91228056F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.614035F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.4912262F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.966435F));
            tableLayoutPanel1.Size = new Size(601, 570);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(188, 200, 135);
            lblName.Dock = DockStyle.Fill;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(559, 84);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            tableLayoutPanel1.SetRowSpan(lblName, 8);
            lblName.Size = new Size(42, 486);
            lblName.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(59, 74, 46);
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(559, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            tableLayoutPanel1.SetRowSpan(label1, 2);
            label1.Size = new Size(42, 84);
            label1.TabIndex = 48;
            // 
            // lblCookbookName
            // 
            lblCookbookName.AutoSize = true;
            lblCookbookName.Dock = DockStyle.Fill;
            lblCookbookName.Location = new Point(33, 119);
            lblCookbookName.Margin = new Padding(4, 0, 4, 0);
            lblCookbookName.Name = "lblCookbookName";
            lblCookbookName.Size = new Size(129, 34);
            lblCookbookName.TabIndex = 0;
            lblCookbookName.Text = "Cookbook Name";
            lblCookbookName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.Location = new Point(33, 153);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(129, 34);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(33, 187);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(129, 34);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Dock = DockStyle.Fill;
            lblActive.Location = new Point(33, 221);
            lblActive.Margin = new Padding(4, 0, 4, 0);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(129, 28);
            lblActive.TabIndex = 3;
            lblActive.Text = "Active";
            lblActive.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxIsActive
            // 
            cbxIsActive.AutoSize = true;
            cbxIsActive.Dock = DockStyle.Fill;
            cbxIsActive.Location = new Point(170, 225);
            cbxIsActive.Margin = new Padding(4);
            cbxIsActive.Name = "cbxIsActive";
            cbxIsActive.Size = new Size(351, 20);
            cbxIsActive.TabIndex = 4;
            cbxIsActive.TextAlign = ContentAlignment.BottomLeft;
            cbxIsActive.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel4, 2);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3048019F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.7995815F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8956146F));
            tableLayoutPanel4.Controls.Add(btnCookbookSave, 0, 0);
            tableLayoutPanel4.Controls.Add(btnCookbookDelete, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(32, 42);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(490, 39);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // btnCookbookSave
            // 
            btnCookbookSave.Dock = DockStyle.Fill;
            btnCookbookSave.Location = new Point(3, 3);
            btnCookbookSave.Name = "btnCookbookSave";
            btnCookbookSave.Size = new Size(122, 33);
            btnCookbookSave.TabIndex = 0;
            btnCookbookSave.Text = "&Save";
            btnCookbookSave.UseVisualStyleBackColor = true;
            // 
            // btnCookbookDelete
            // 
            btnCookbookDelete.Dock = DockStyle.Fill;
            btnCookbookDelete.Location = new Point(131, 3);
            btnCookbookDelete.Name = "btnCookbookDelete";
            btnCookbookDelete.Size = new Size(110, 33);
            btnCookbookDelete.TabIndex = 1;
            btnCookbookDelete.Text = "&Delete";
            btnCookbookDelete.UseVisualStyleBackColor = true;
            // 
            // lstUsersName
            // 
            lstUsersName.Dock = DockStyle.Fill;
            lstUsersName.FormattingEnabled = true;
            lstUsersName.Location = new Point(169, 156);
            lstUsersName.Name = "lstUsersName";
            lstUsersName.Size = new Size(353, 29);
            lstUsersName.TabIndex = 8;
            // 
            // lblDateCreateCaption
            // 
            lblDateCreateCaption.AutoSize = true;
            lblDateCreateCaption.Dock = DockStyle.Fill;
            lblDateCreateCaption.Location = new Point(32, 249);
            lblDateCreateCaption.Name = "lblDateCreateCaption";
            lblDateCreateCaption.Size = new Size(131, 32);
            lblDateCreateCaption.TabIndex = 9;
            lblDateCreateCaption.Text = "Date Created";
            lblDateCreateCaption.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDateCreated.BackColor = Color.WhiteSmoke;
            lblDateCreated.Location = new Point(169, 249);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(121, 32);
            lblDateCreated.TabIndex = 10;
            lblDateCreated.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boxCookbookDetail
            // 
            tableLayoutPanel1.SetColumnSpan(boxCookbookDetail, 2);
            boxCookbookDetail.Controls.Add(tableLayoutPanel2);
            boxCookbookDetail.Dock = DockStyle.Fill;
            boxCookbookDetail.Location = new Point(29, 281);
            boxCookbookDetail.Margin = new Padding(0);
            boxCookbookDetail.Name = "boxCookbookDetail";
            boxCookbookDetail.Size = new Size(496, 265);
            boxCookbookDetail.TabIndex = 11;
            boxCookbookDetail.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnCookbookDetailSave, 0, 0);
            tableLayoutPanel2.Controls.Add(gCookbookDetail, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 25);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.791666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80.2083359F));
            tableLayoutPanel2.Size = new Size(490, 237);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCookbookDetailSave
            // 
            btnCookbookDetailSave.Location = new Point(3, 3);
            btnCookbookDetailSave.Name = "btnCookbookDetailSave";
            btnCookbookDetailSave.Size = new Size(99, 32);
            btnCookbookDetailSave.TabIndex = 1;
            btnCookbookDetailSave.Text = "&Save";
            btnCookbookDetailSave.UseVisualStyleBackColor = true;
            // 
            // gCookbookDetail
            // 
            gCookbookDetail.BackgroundColor = Color.WhiteSmoke;
            gCookbookDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gCookbookDetail.Dock = DockStyle.Fill;
            gCookbookDetail.Location = new Point(3, 49);
            gCookbookDetail.Name = "gCookbookDetail";
            gCookbookDetail.RowTemplate.Height = 25;
            gCookbookDetail.Size = new Size(484, 185);
            gCookbookDetail.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 190);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(345, 29);
            txtPrice.TabIndex = 50;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(169, 122);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(353, 29);
            txtCookbookName.TabIndex = 51;
            // 
            // tblButton
            // 
            tblButton.ColumnCount = 2;
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0337086F));
            tblButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblButton.Dock = DockStyle.Fill;
            tblButton.Location = new Point(0, 0);
            tblButton.Name = "tblButton";
            tblButton.RowCount = 1;
            tblButton.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblButton.Size = new Size(200, 100);
            tblButton.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.0337086F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // frmCookbookDetail
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 570);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmCookbookDetail";
            Text = "Cookbook Detail";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            boxCookbookDetail.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblCookbookName;
        private Label lblUserName;
        private Label lblPrice;
        private Label lblActive;
        private CheckBox cbxIsActive;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCookbookSave;
        private Button btnCookbookDelete;
        private TableLayoutPanel tblButton;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox lstUsersName;
        private Label lblDateCreateCaption;
        private Label lblDateCreated;
        private GroupBox boxCookbookDetail;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCookbookDetailSave;
        private DataGridView gCookbookDetail;
        private Label label1;
        private Label lblName;
        private TextBox txtPrice;
        private TextBox txtCookbookName;
    }
}