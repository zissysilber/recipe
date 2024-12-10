﻿using System.Configuration;
using RecipeWinForms.Properties;

namespace RecipeWinForms
{

    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;
#if DEBUG
            txtUserId.Text = "appadmin";
            txtPassword.Text = "8Northoak!";
#endif
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + "-DEV";
#endif
            txtUserId.Text = Settings.Default.userid;
            this.ShowDialog();
            return loginsuccess;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
                //connstringkey = "liveconn";

#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUserId.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.userid = txtUserId.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid login. Try again.", Application.ProductName);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
