using System;
using System.Windows.Forms;
using JPRagTools.Utils;

namespace JPRagTools.Forms
{
    public partial class LoginForm : Form
    {
        public bool IsAuthenticated { get; private set; }
        public string UserEmail { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            LoadSavedEmail();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string validationMessage = Database.ValidateUser(email);

            if (validationMessage == "OK")
            {
                IsAuthenticated = true;
                UserEmail = email;

                if (chkSaveEmail.Checked)
                {
                    Properties.Settings.Default.SavedEmail = email;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.SavedEmail = "";
                    Properties.Settings.Default.Save();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show(validationMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsAuthenticated = false;
            this.Close();
        }

        private void LoadSavedEmail()
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SavedEmail))
            {
                txtEmail.Text = Properties.Settings.Default.SavedEmail;
                chkSaveEmail.Checked = true;
            }
        }
    }
}
