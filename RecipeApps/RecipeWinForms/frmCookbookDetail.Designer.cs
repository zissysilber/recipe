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
            tblMain = new TableLayoutPanel();
            tblCookbookBtn = new TableLayoutPanel();
            btnCookbookSave = new Button();
            btnCookbookDelete = new Button();
            lblName = new Label();
            label1 = new Label();
            lblCookbookName = new Label();
            lblUserName = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            cbxIsActive = new CheckBox();
            lstUsersName = new ComboBox();
            lblDateCreateCaption = new Label();
            lblDateCreated = new Label();
            txtPrice = new TextBox();
            txtCookbookName = new TextBox();
            boxCookbookDetail = new GroupBox();
            tblCookbookDetail = new TableLayoutPanel();
            btnCookbookDetailSave = new Button();
            gCookbookDetail = new DataGridView();
            tblButton = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tblMain.SuspendLayout();
            tblCookbookBtn.SuspendLayout();
            boxCookbookDetail.SuspendLayout();
            tblCookbookDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gCookbookDetail).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.White;
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 29F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.5925922F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.40741F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tblMain.Controls.Add(tblCookbookBtn, 1, 1);
            tblMain.Controls.Add(lblName, 4, 2);
            tblMain.Controls.Add(label1, 4, 0);
            tblMain.Controls.Add(lblCookbookName, 1, 3);
            tblMain.Controls.Add(lblUserName, 1, 4);
            tblMain.Controls.Add(lblPrice, 1, 5);
            tblMain.Controls.Add(lblActive, 1, 6);
            tblMain.Controls.Add(cbxIsActive, 2, 6);
            tblMain.Controls.Add(lstUsersName, 2, 4);
            tblMain.Controls.Add(lblDateCreateCaption, 1, 7);
            tblMain.Controls.Add(lblDateCreated, 2, 7);
            tblMain.Controls.Add(txtPrice, 2, 5);
            tblMain.Controls.Add(txtCookbookName, 2, 3);
            tblMain.Controls.Add(boxCookbookDetail, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.84210539F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.894737F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.140351F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.96491241F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.96491241F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.96491241F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.91228056F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5.614035F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 46.4912262F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 3.966435F));
            tblMain.Size = new Size(601, 570);
            tblMain.TabIndex = 0;
            // 
            // tblCookbookBtn
            // 
            tblCookbookBtn.ColumnCount = 3;
            tblMain.SetColumnSpan(tblCookbookBtn, 2);
            tblCookbookBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3048019F));
            tblCookbookBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.7995815F));
            tblCookbookBtn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.8956146F));
            tblCookbookBtn.Controls.Add(btnCookbookSave, 0, 0);
            tblCookbookBtn.Controls.Add(btnCookbookDelete, 1, 0);
            tblCookbookBtn.Dock = DockStyle.Fill;
            tblCookbookBtn.Location = new Point(32, 42);
            tblCookbookBtn.Name = "tblCookbookBtn";
            tblCookbookBtn.RowCount = 1;
            tblCookbookBtn.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblCookbookBtn.Size = new Size(490, 39);
            tblCookbookBtn.TabIndex = 6;
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
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(188, 200, 135);
            lblName.Dock = DockStyle.Fill;
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(559, 84);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            tblMain.SetRowSpan(lblName, 8);
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
            tblMain.SetRowSpan(label1, 2);
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
            cbxIsActive.TabIndex = 3;
            cbxIsActive.TextAlign = ContentAlignment.BottomLeft;
            cbxIsActive.UseVisualStyleBackColor = true;
            // 
            // lstUsersName
            // 
            lstUsersName.Dock = DockStyle.Fill;
            lstUsersName.FormattingEnabled = true;
            lstUsersName.Location = new Point(169, 156);
            lstUsersName.Name = "lstUsersName";
            lstUsersName.Size = new Size(353, 29);
            lstUsersName.TabIndex = 1;
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
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 190);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(345, 29);
            txtPrice.TabIndex = 2;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(169, 122);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(353, 29);
            txtCookbookName.TabIndex = 0;
            // 
            // boxCookbookDetail
            // 
            tblMain.SetColumnSpan(boxCookbookDetail, 2);
            boxCookbookDetail.Controls.Add(tblCookbookDetail);
            boxCookbookDetail.Dock = DockStyle.Fill;
            boxCookbookDetail.Location = new Point(29, 281);
            boxCookbookDetail.Margin = new Padding(0);
            boxCookbookDetail.Name = "boxCookbookDetail";
            boxCookbookDetail.Size = new Size(496, 265);
            boxCookbookDetail.TabIndex = 11;
            boxCookbookDetail.TabStop = false;
            // 
            // tblCookbookDetail
            // 
            tblCookbookDetail.ColumnCount = 1;
            tblCookbookDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCookbookDetail.Controls.Add(btnCookbookDetailSave, 0, 0);
            tblCookbookDetail.Controls.Add(gCookbookDetail, 0, 1);
            tblCookbookDetail.Dock = DockStyle.Fill;
            tblCookbookDetail.Location = new Point(3, 25);
            tblCookbookDetail.Name = "tblCookbookDetail";
            tblCookbookDetail.RowCount = 2;
            tblCookbookDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 19.791666F));
            tblCookbookDetail.RowStyles.Add(new RowStyle(SizeType.Percent, 80.2083359F));
            tblCookbookDetail.Size = new Size(490, 237);
            tblCookbookDetail.TabIndex = 0;
            // 
            // btnCookbookDetailSave
            // 
            btnCookbookDetailSave.Location = new Point(3, 3);
            btnCookbookDetailSave.Name = "btnCookbookDetailSave";
            btnCookbookDetailSave.Size = new Size(99, 32);
            btnCookbookDetailSave.TabIndex = 0;
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
            gCookbookDetail.TabIndex = 1;
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
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "frmCookbookDetail";
            Text = "Cookbook Detail";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblCookbookBtn.ResumeLayout(false);
            boxCookbookDetail.ResumeLayout(false);
            tblCookbookDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gCookbookDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCookbookName;
        private Label lblUserName;
        private Label lblPrice;
        private Label lblActive;
        private CheckBox cbxIsActive;
        private TableLayoutPanel tblCookbookBtn;
        private Button btnCookbookSave;
        private Button btnCookbookDelete;
        private TableLayoutPanel tblButton;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox lstUsersName;
        private Label lblDateCreateCaption;
        private Label lblDateCreated;
        private GroupBox boxCookbookDetail;
        private TableLayoutPanel tblCookbookDetail;
        private Button btnCookbookDetailSave;
        private DataGridView gCookbookDetail;
        private Label label1;
        private Label lblName;
        private TextBox txtPrice;
        private TextBox txtCookbookName;
    }
}